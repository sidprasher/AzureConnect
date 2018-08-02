using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Shared.Protocol;

namespace AzureConnect
{
    class BlobStorageService
    {
        static string storageConnectionString = "DefaultEndpointsProtocol=https;"
    + "AccountName=gpv2sa2"
    + ";AccountKey=+Kns/Y3tmHalVZ7hIkavwVW7eOcKTSmKo6KOYqxRCymXbSfSutJLCUCCAzMkCfHWBslXdDKTFxLxJXeMC7rQ1Q=="
    + ";EndpointSuffix=core.windows.net";

        public static void WriteaBlob()
        {
            // Create container. Name must be lower case.
            Console.WriteLine("Creating container...");
            var serviceClient = GetBlobClient();

            var container = serviceClient.GetContainerReference("text");
            container.CreateIfNotExistsAsync().Wait();

            // write a blob to the container
            CloudBlockBlob blob = container.GetBlockBlobReference("helloworld.txt");
            blob.UploadTextAsync("Hello, World!").Wait();
        }

        private static CloudBlobClient GetBlobClient()
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(storageConnectionString);
            return account.CreateCloudBlobClient();
        }

        public static void AddCORS()
        {
            var serviceClient = GetBlobClient();
            ServiceProperties blobServiceProperties = serviceClient.GetServiceProperties();
            ConfigureCors(blobServiceProperties);

            serviceClient.SetServiceProperties(blobServiceProperties);
        }


        private static void ConfigureCors(ServiceProperties serviceProperties)
        {
            serviceProperties.Cors = new CorsProperties();
            serviceProperties.Cors.CorsRules.Add(new CorsRule()
            {
                AllowedHeaders = new List<string>() { "*" },
                AllowedMethods = CorsHttpMethods.Put | CorsHttpMethods.Get | CorsHttpMethods.Head | CorsHttpMethods.Post,
                AllowedOrigins = new List<string>() { "www.example.com" },
                ExposedHeaders = new List<string>() { "*" },
                MaxAgeInSeconds = 1800 // 30 minutes
            });
        }

        internal static void CreateContainer(string containerName)
        {
            var serviceClient = GetBlobClient();

            var container = serviceClient.GetContainerReference(containerName.ToLower());
            
            container.CreateIfNotExistsAsync().Wait();
        }

        static string GetContainerSasUri(CloudBlobContainer container)
        {
            //Set the expiry time and permissions for the container.
            //In this case no start time is specified, so the shared access signature becomes valid immediately.
            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.List | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the container, setting the constraints directly on the signature.
            string sasContainerToken = container.GetSharedAccessSignature(sasConstraints);

            //Return the URI string for the container, including the SAS token.
            return container.Uri + sasContainerToken;
        }

        public static IEnumerable<string> GetContainers()
        {
            List<string> containers = new List<string>();

            var serviceClient = GetBlobClient();
            foreach (var c in serviceClient.ListContainers(null, ContainerListingDetails.None, null, null))
            {
                containers.Add(c.Name);
            }

            return containers;
        }
    }
}
