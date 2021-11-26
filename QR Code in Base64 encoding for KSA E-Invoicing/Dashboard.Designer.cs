namespace QR_Code_in_Base64_encoding_for_KSA_E_Invoicing
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVATNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeStamp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVATTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pboxQrImage = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(18, 37);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(248, 23);
            this.txtSellerName.TabIndex = 0;
            this.txtSellerName.Tag = "1";
            this.txtSellerName.Text = "Top Notepad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seller name";
            // 
            // txtVATNumber
            // 
            this.txtVATNumber.Location = new System.Drawing.Point(18, 92);
            this.txtVATNumber.Name = "txtVATNumber";
            this.txtVATNumber.Size = new System.Drawing.Size(248, 23);
            this.txtVATNumber.TabIndex = 0;
            this.txtVATNumber.Tag = "2";
            this.txtVATNumber.Text = "310122393500003";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "VAT Number";
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Location = new System.Drawing.Point(18, 149);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(248, 23);
            this.txtTimeStamp.TabIndex = 0;
            this.txtTimeStamp.Tag = "3";
            this.txtTimeStamp.Text = "2022-04-25T15:30:00Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time Stamp";
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(18, 207);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(248, 23);
            this.txtInvoiceTotal.TabIndex = 0;
            this.txtInvoiceTotal.Tag = "4";
            this.txtInvoiceTotal.Text = "1000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Invoice Total";
            // 
            // txtVATTotal
            // 
            this.txtVATTotal.Location = new System.Drawing.Point(18, 266);
            this.txtVATTotal.Name = "txtVATTotal";
            this.txtVATTotal.Size = new System.Drawing.Size(248, 23);
            this.txtVATTotal.TabIndex = 0;
            this.txtVATTotal.Tag = "5";
            this.txtVATTotal.Text = "150.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "VAT Total";
            // 
            // pboxQrImage
            // 
            this.pboxQrImage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pboxQrImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxQrImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxQrImage.Location = new System.Drawing.Point(281, 37);
            this.pboxQrImage.Name = "pboxQrImage";
            this.pboxQrImage.Size = new System.Drawing.Size(250, 252);
            this.pboxQrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxQrImage.TabIndex = 2;
            this.pboxQrImage.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(456, 295);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBase64
            // 
            this.txtBase64.Location = new System.Drawing.Point(18, 331);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ReadOnly = true;
            this.txtBase64.Size = new System.Drawing.Size(513, 76);
            this.txtBase64.TabIndex = 4;
            this.txtBase64.Tag = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Base64";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pboxQrImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVATTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimeStamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVATNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSellerName);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code - Base64 Encoding for KSA E-Invoicing";
            ((System.ComponentModel.ISupportInitialize)(this.pboxQrImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSellerName;
        private Label label1;
        private TextBox txtVATNumber;
        private Label label2;
        private TextBox txtTimeStamp;
        private Label label3;
        private TextBox txtInvoiceTotal;
        private Label label4;
        private TextBox txtVATTotal;
        private Label label5;
        private PictureBox pboxQrImage;
        private Button btnStart;
        private TextBox txtBase64;
        private Label label6;
    }
}