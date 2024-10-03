namespace DevExpressProject
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txiban = new DevExpress.XtraEditors.TextEdit();
            this.txsube = new DevExpress.XtraEditors.TextEdit();
            this.txil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtarih = new System.Windows.Forms.MaskedTextBox();
            this.txtel = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txhesap = new DevExpress.XtraEditors.TextEdit();
            this.txbankaadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txfirma = new DevExpress.XtraEditors.LookUpEdit();
            this.txhesapno = new DevExpress.XtraEditors.TextEdit();
            this.txyetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txiban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txsube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txhesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbankaadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txfirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txhesapno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txyetkili.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(103, 447);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(154, 27);
            this.btntemizle.TabIndex = 30;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // txiban
            // 
            this.txiban.Location = new System.Drawing.Point(103, 149);
            this.txiban.Name = "txiban";
            this.txiban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txiban.Properties.Appearance.Options.UseFont = true;
            this.txiban.Size = new System.Drawing.Size(154, 22);
            this.txiban.TabIndex = 10;
            // 
            // txsube
            // 
            this.txsube.Location = new System.Drawing.Point(103, 121);
            this.txsube.Name = "txsube";
            this.txsube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txsube.Properties.Appearance.Options.UseFont = true;
            this.txsube.Size = new System.Drawing.Size(154, 22);
            this.txsube.TabIndex = 7;
            // 
            // txil
            // 
            this.txil.Location = new System.Drawing.Point(103, 65);
            this.txil.Name = "txil";
            this.txil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txil.Properties.Appearance.Options.UseFont = true;
            this.txil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txil.Size = new System.Drawing.Size(154, 22);
            this.txil.TabIndex = 8;
            this.txil.SelectedIndexChanged += new System.EventHandler(this.txil_SelectedIndexChanged);
            // 
            // txilce
            // 
            this.txilce.Location = new System.Drawing.Point(103, 93);
            this.txilce.Name = "txilce";
            this.txilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txilce.Properties.Appearance.Options.UseFont = true;
            this.txilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txilce.Size = new System.Drawing.Size(154, 22);
            this.txilce.TabIndex = 9;
            // 
            // txtarih
            // 
            this.txtarih.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarih.Location = new System.Drawing.Point(103, 263);
            this.txtarih.Mask = "00000000000";
            this.txtarih.Name = "txtarih";
            this.txtarih.Size = new System.Drawing.Size(154, 23);
            this.txtarih.TabIndex = 6;
            this.txtarih.ValidatingType = typeof(int);
            // 
            // txtel
            // 
            this.txtel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtel.Location = new System.Drawing.Point(103, 234);
            this.txtel.Mask = "(999) 000-0000";
            this.txtel.Name = "txtel";
            this.txtel.Size = new System.Drawing.Size(154, 23);
            this.txtel.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(28, 207);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 18);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "YETKILI:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(41, 321);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 18);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "FIRMA:";
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(103, 381);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(154, 27);
            this.btnsil.TabIndex = 22;
            this.btnsil.Text = " Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(103, 414);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(154, 27);
            this.btnguncelle.TabIndex = 21;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(103, 348);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(154, 27);
            this.btnkaydet.TabIndex = 20;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 178);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(74, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "HESAP NO:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(54, 97);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 18);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "ILCE:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(71, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "IL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "IBAN:";
            // 
            // txhesap
            // 
            this.txhesap.Location = new System.Drawing.Point(103, 292);
            this.txhesap.Name = "txhesap";
            this.txhesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txhesap.Properties.Appearance.Options.UseFont = true;
            this.txhesap.Size = new System.Drawing.Size(154, 22);
            this.txhesap.TabIndex = 3;
            // 
            // txbankaadi
            // 
            this.txbankaadi.Location = new System.Drawing.Point(103, 37);
            this.txbankaadi.Name = "txbankaadi";
            this.txbankaadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbankaadi.Properties.Appearance.Options.UseFont = true;
            this.txbankaadi.Size = new System.Drawing.Size(154, 22);
            this.txbankaadi.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "SUBE:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "BANKAADI:";
            // 
            // txid
            // 
            this.txid.Location = new System.Drawing.Point(103, 8);
            this.txid.Name = "txid";
            this.txid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txid.Properties.Appearance.Options.UseFont = true;
            this.txid.Size = new System.Drawing.Size(154, 22);
            this.txid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(65, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(705, 489);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txfirma);
            this.groupControl1.Controls.Add(this.txhesapno);
            this.groupControl1.Controls.Add(this.txyetkili);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.txiban);
            this.groupControl1.Controls.Add(this.txsube);
            this.groupControl1.Controls.Add(this.txil);
            this.groupControl1.Controls.Add(this.txilce);
            this.groupControl1.Controls.Add(this.txtarih);
            this.groupControl1.Controls.Add(this.txtel);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txhesap);
            this.groupControl1.Controls.Add(this.txbankaadi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(711, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(289, 489);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "groupControl1";
            // 
            // txfirma
            // 
            this.txfirma.Location = new System.Drawing.Point(103, 320);
            this.txfirma.Name = "txfirma";
            this.txfirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txfirma.Properties.Appearance.Options.UseFont = true;
            this.txfirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txfirma.Properties.NullText = "Bir Firma Secin";
            this.txfirma.Size = new System.Drawing.Size(154, 24);
            this.txfirma.TabIndex = 36;
            // 
            // txhesapno
            // 
            this.txhesapno.Location = new System.Drawing.Point(103, 177);
            this.txhesapno.Name = "txhesapno";
            this.txhesapno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txhesapno.Properties.Appearance.Options.UseFont = true;
            this.txhesapno.Size = new System.Drawing.Size(154, 22);
            this.txhesapno.TabIndex = 35;
            // 
            // txyetkili
            // 
            this.txyetkili.Location = new System.Drawing.Point(103, 206);
            this.txyetkili.Name = "txyetkili";
            this.txyetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txyetkili.Properties.Appearance.Options.UseFont = true;
            this.txyetkili.Size = new System.Drawing.Size(154, 22);
            this.txyetkili.TabIndex = 34;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(41, 293);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 18);
            this.labelControl13.TabIndex = 33;
            this.labelControl13.Text = "HESAP:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(40, 264);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(49, 18);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "TARIH:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 238);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 18);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "TELEFON:";
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 494);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBankalar";
            this.Text = "FrmBankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txiban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txsube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txhesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbankaadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txfirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txhesapno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txyetkili.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.TextEdit txiban;
        private DevExpress.XtraEditors.TextEdit txsube;
        private DevExpress.XtraEditors.ComboBoxEdit txil;
        private DevExpress.XtraEditors.ComboBoxEdit txilce;
        private System.Windows.Forms.MaskedTextBox txtarih;
        private System.Windows.Forms.MaskedTextBox txtel;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txhesap;
        private DevExpress.XtraEditors.TextEdit txbankaadi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txhesapno;
        private DevExpress.XtraEditors.TextEdit txyetkili;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit txfirma;
    }
}