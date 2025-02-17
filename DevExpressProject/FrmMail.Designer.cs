﻿namespace DevExpressProject
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txadres = new DevExpress.XtraEditors.TextEdit();
            this.txkonu = new DevExpress.XtraEditors.TextEdit();
            this.txmesaj = new System.Windows.Forms.RichTextBox();
            this.btngonder = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txkonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 108);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mesaj:";
            // 
            // txadres
            // 
            this.txadres.Location = new System.Drawing.Point(134, 138);
            this.txadres.Name = "txadres";
            this.txadres.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txadres.Properties.Appearance.Options.UseFont = true;
            this.txadres.Size = new System.Drawing.Size(222, 26);
            this.txadres.TabIndex = 4;
            // 
            // txkonu
            // 
            this.txkonu.Location = new System.Drawing.Point(134, 176);
            this.txkonu.Name = "txkonu";
            this.txkonu.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txkonu.Properties.Appearance.Options.UseFont = true;
            this.txkonu.Size = new System.Drawing.Size(222, 26);
            this.txkonu.TabIndex = 5;
            // 
            // txmesaj
            // 
            this.txmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txmesaj.Location = new System.Drawing.Point(134, 215);
            this.txmesaj.Name = "txmesaj";
            this.txmesaj.Size = new System.Drawing.Size(222, 126);
            this.txmesaj.TabIndex = 6;
            this.txmesaj.Text = "";
            // 
            // btngonder
            // 
            this.btngonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btngonder.Location = new System.Drawing.Point(205, 350);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(138, 33);
            this.btngonder.TabIndex = 7;
            this.btngonder.Text = "Gönder";
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(73, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail Gönderme Paneli";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 392);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.txmesaj);
            this.Controls.Add(this.txkonu);
            this.Controls.Add(this.txadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMail";
            this.Text = "FrmMail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txkonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txadres;
        private DevExpress.XtraEditors.TextEdit txkonu;
        private System.Windows.Forms.RichTextBox txmesaj;
        private DevExpress.XtraEditors.SimpleButton btngonder;
        private System.Windows.Forms.Label label4;
    }
}