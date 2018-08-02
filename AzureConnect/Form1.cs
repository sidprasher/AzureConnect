using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AzureConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var sequence = long.Parse(textBox1.Text);
            //textBox2.Text = GetFibonacci(sequence).ToString();
            var op = Task.Run(() => GetFibonacci(sequence));
            var r = await op;
            textBox2.Text = op.Result.ToString();
        }

        private long GetFibonacci(long sequence)
        {
            if (sequence == 0 || sequence == 1)
                return sequence;

            return GetFibonacci(sequence - 1) + GetFibonacci(sequence - 2);
        }

        private void BlobStorageClick(object sender, EventArgs e)
        {
            BlobStorageSample.WriteaBlob();

        }

        private void CorsConfigClick(object sender, EventArgs e)
        {
            BlobStorageSample.AddCORS();
        }
    }
}
