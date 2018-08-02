namespace AzureConnect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.blobStorage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "await async";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1005, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 35);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1005, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 35);
            this.textBox2.TabIndex = 2;
            // 
            // blobStorage
            // 
            this.blobStorage.Location = new System.Drawing.Point(86, 380);
            this.blobStorage.Name = "blobStorage";
            this.blobStorage.Size = new System.Drawing.Size(285, 71);
            this.blobStorage.TabIndex = 3;
            this.blobStorage.Text = "blob";
            this.blobStorage.UseVisualStyleBackColor = true;
            this.blobStorage.Click += new System.EventHandler(this.BlobStorageClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "CORS Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CorsConfigClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "GetContainers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 35);
            this.textBox3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 71);
            this.button4.TabIndex = 7;
            this.button4.Text = "Create Container";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 628);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.blobStorage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button blobStorage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
    }
}

