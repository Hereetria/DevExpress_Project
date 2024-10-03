using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressProject
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            txfirma.Properties.ValueMember = "ID";
            txfirma.Properties.DisplayMember = "AD";
            txfirma.Properties.DataSource = dt;
        }
        void temizle()
        {
            txbankaadi.Text = " ";
            txsube.Text = " ";
            txiban.Text = " ";
            txhesapno.Text = " ";
            txyetkili.Text = " ";
            txtarih.Text = " ";
            txhesap.Text = " ";
            txil.Text = " ";
            txilce.Text = " ";
            txtel.Text = " ";
            txid.Text = " ";
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();

            sehirListesi();

            firmaListesi();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_BANKALAR (BANKAADI, SUBE, IBAN, HESAPNO, YETKILI, TARIH, HESAPTURU, FIRMAID, IL, ILCE, TELEFON) " +
                                   "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txbankaadi.Text);
            komut.Parameters.AddWithValue("@p2", txsube.Text);
            komut.Parameters.AddWithValue("@p3", txiban.Text);
            komut.Parameters.AddWithValue("@p4", txhesapno.Text);
            komut.Parameters.AddWithValue("@p5", txyetkili.Text);
            komut.Parameters.AddWithValue("@p6", txtarih.Text);
            komut.Parameters.AddWithValue("@p7", txhesap.Text);
            komut.Parameters.AddWithValue("@p8", txfirma.EditValue);
            komut.Parameters.AddWithValue("@p9", txil.Text);
            komut.Parameters.AddWithValue("@p10", txilce.Text);
            komut.Parameters.AddWithValue("@p11", txtel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka bilgileri sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void txil_SelectedIndexChanged(object sender, EventArgs e)
        {
            txilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE From TBL_ILCELER Where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txil.SelectedIndex + 1);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["ID"].ToString();
                txbankaadi.Text = dr["BANKAADI"].ToString();
                txsube.Text = dr["SUBE"].ToString();
                txiban.Text = dr["IBAN"].ToString();
                txhesapno.Text = dr["HESAPNO"].ToString();
                txyetkili.Text = dr["YETKILI"].ToString();
                txtarih.Text = dr["TARIH"].ToString();
                txhesap.Text = dr["HESAPTURU"].ToString();
                txil.Text = dr["IL"].ToString();
                txilce.Text = dr["ILCE"].ToString();
                txtel.Text = dr["TELEFON"].ToString();
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_BANKALAR Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_BANKALAR SET " +
                                               "BANKAADI=@p1, SUBE=@p2, IBAN=@p3, HESAPNO=@p4, YETKILI=@p5, TARIH=@p6, HESAPTURU=@p7, IL=@p8, ILCE=@p9, TELEFON=@p10 " +
                                               "WHERE ID=@p11", bgl.baglanti());


            komut.Parameters.AddWithValue("@p1", txbankaadi.Text);
            komut.Parameters.AddWithValue("@p2", txsube.Text);
            komut.Parameters.AddWithValue("@p3", txiban.Text);
            komut.Parameters.AddWithValue("@p4", txhesapno.Text);
            komut.Parameters.AddWithValue("@p5", txyetkili.Text);
            komut.Parameters.AddWithValue("@p6", txtarih.Text);
            komut.Parameters.AddWithValue("@p7", txhesap.Text);
            komut.Parameters.AddWithValue("@p8", txil.Text);
            komut.Parameters.AddWithValue("@p9", txilce.Text);
            komut.Parameters.AddWithValue("@p10", txtel.Text);
            komut.Parameters.AddWithValue("@p11", txid.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
