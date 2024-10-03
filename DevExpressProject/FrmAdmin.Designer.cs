namespace DevExpressProject
{
    partial class FrmAdmin
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
            this.txkullaniciad = new DevExpress.XtraEditors.TextEdit();
            this.txsifre = new DevExpress.XtraEditors.TextEdit();
            this.kullaniciad = new DevExpress.XtraEditors.LabelControl();
            this.sifre = new DevExpress.XtraEditors.LabelControl();
            this.btngiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txkullaniciad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txkullaniciad
            // 
            this.txkullaniciad.Location = new System.Drawing.Point(115, 48);
            this.txkullaniciad.Name = "txkullaniciad";
            this.txkullaniciad.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txkullaniciad.Properties.Appearance.Options.UseFont = true;
            this.txkullaniciad.Size = new System.Drawing.Size(123, 24);
            this.txkullaniciad.TabIndex = 0;
            // 
            // txsifre
            // 
            this.txsifre.Location = new System.Drawing.Point(115, 76);
            this.txsifre.Name = "txsifre";
            this.txsifre.Properties.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txsifre.Properties.Appearance.Options.UseFont = true;
            this.txsifre.Size = new System.Drawing.Size(123, 24);
            this.txsifre.TabIndex = 1;
            // 
            // kullaniciad
            // 
            this.kullaniciad.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciad.Appearance.Options.UseFont = true;
            this.kullaniciad.Location = new System.Drawing.Point(30, 47);
            this.kullaniciad.Name = "kullaniciad";
            this.kullaniciad.Size = new System.Drawing.Size(79, 18);
            this.kullaniciad.TabIndex = 2;
            this.kullaniciad.Text = "Kullanıcı Adı:";
            // 
            // sifre
            // 
            this.sifre.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Appearance.Options.UseFont = true;
            this.sifre.Location = new System.Drawing.Point(77, 82);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(32, 18);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre:";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(115, 106);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(123, 29);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 195);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciad);
            this.Controls.Add(this.txsifre);
            this.Controls.Add(this.txkullaniciad);
            this.Name = "FrmAdmin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txkullaniciad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txkullaniciad;
        private DevExpress.XtraEditors.TextEdit txsifre;
        private DevExpress.XtraEditors.LabelControl kullaniciad;
        private DevExpress.XtraEditors.LabelControl sifre;
        private System.Windows.Forms.Button btngiris;
    }
}