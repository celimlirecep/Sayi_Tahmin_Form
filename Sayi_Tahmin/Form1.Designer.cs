
namespace Sayi_Tahmin
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
            this.txtConstant1 = new System.Windows.Forms.Label();
            this.txtTahminGirdi = new System.Windows.Forms.TextBox();
            this.tblGirdiOnay = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblHile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblUserEstimate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConstant1
            // 
            this.txtConstant1.AutoSize = true;
            this.txtConstant1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConstant1.Location = new System.Drawing.Point(96, 59);
            this.txtConstant1.Name = "txtConstant1";
            this.txtConstant1.Size = new System.Drawing.Size(201, 23);
            this.txtConstant1.TabIndex = 0;
            this.txtConstant1.Text = "ENTER YOUR ESTİMATE :";
            // 
            // txtTahminGirdi
            // 
            this.txtTahminGirdi.Location = new System.Drawing.Point(133, 99);
            this.txtTahminGirdi.Name = "txtTahminGirdi";
            this.txtTahminGirdi.Size = new System.Drawing.Size(127, 20);
            this.txtTahminGirdi.TabIndex = 1;
            this.txtTahminGirdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTahminGirdi_KeyDown);
            // 
            // tblGirdiOnay
            // 
            this.tblGirdiOnay.Location = new System.Drawing.Point(162, 149);
            this.tblGirdiOnay.Name = "tblGirdiOnay";
            this.tblGirdiOnay.Size = new System.Drawing.Size(69, 35);
            this.tblGirdiOnay.TabIndex = 2;
            this.tblGirdiOnay.Text = "OK";
            this.tblGirdiOnay.UseVisualStyleBackColor = true;
            this.tblGirdiOnay.Click += new System.EventHandler(this.tblGirdiOnay_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.Tomato;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(89, 9);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(208, 38);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "START";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSonuc.Location = new System.Drawing.Point(49, 196);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(295, 28);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "YOU CLİCK ON THE START BUTTON FOR START GAME";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHile
            // 
            this.lblHile.AutoSize = true;
            this.lblHile.Location = new System.Drawing.Point(298, 262);
            this.lblHile.Name = "lblHile";
            this.lblHile.Size = new System.Drawing.Size(0, 13);
            this.lblHile.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PUAN :";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(169, 245);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(13, 13);
            this.lblPuan.TabIndex = 7;
            this.lblPuan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "HAK : ";
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(251, 245);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(13, 13);
            this.lblHak.TabIndex = 7;
            this.lblHak.Text = "0";
            // 
            // lblUserEstimate
            // 
            this.lblUserEstimate.AutoSize = true;
            this.lblUserEstimate.Location = new System.Drawing.Point(78, 224);
            this.lblUserEstimate.Name = "lblUserEstimate";
            this.lblUserEstimate.Size = new System.Drawing.Size(104, 13);
            this.lblUserEstimate.TabIndex = 8;
            this.lblUserEstimate.Text = "YOUR ESTİMATE : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(372, 284);
            this.Controls.Add(this.lblUserEstimate);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHile);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.tblGirdiOnay);
            this.Controls.Add(this.txtTahminGirdi);
            this.Controls.Add(this.txtConstant1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConstant1;
        private System.Windows.Forms.TextBox txtTahminGirdi;
        private System.Windows.Forms.Button tblGirdiOnay;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblHile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblUserEstimate;
    }
}

