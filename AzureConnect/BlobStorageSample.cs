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
    class BlobStorageSample
    {
        static string storageConnectionString = "DefaultEndpointsProtocol=https;"
    + "AccountName=gpv2sa2"
    + ";AccountKey=+Kns/Y3tmHalVZ7hIkavwVW7eOcKTSmKo6KOYqxRCymXbSfSutJLCUCCAzMkCfHWBslXdDKTFxLxJXeMC7rQ1Q=="
    + ";EndpointSuffix=core.windows.net";
        public static void WriteaBlob()
        {


            // Create container. Name must be lower case.
            Console.WriteLine("Creating container...");
            var serviceClient = CreateBlobClient();

            var container = serviceClient.GetContainerReference("text");
            container.CreateIfNotExistsAsync().Wait();

            // write a blob to the container
            CloudBlockBlob blob = container.GetBlockBlobReference("helloworld.txt");
            blob.UploadTextAsync("Hello, World!").Wait();
        }

        private static CloudBlobClient CreateBlobClient()
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(storageConnectionString);
            return account.CreateCloudBlobClient();
        }

        public static void AddCORS()
        {
            var serviceClient = CreateBlobClient();
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
    }
}
