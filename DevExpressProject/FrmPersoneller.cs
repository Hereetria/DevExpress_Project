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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void personelListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER", bgl.baglanti());
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
        
        void temizle()
        {
            txid.Text = " ";
            txad.Text = " ";
            txsoyad.Text = " ";
            txtel1.Text = " ";
            txtc.Text = " ";
            txmail.Text = " ";
            txil.Text = " ";
            txilce.Text = " ";
            txgorev.Text = " ";
            txadres.Text = " ";

        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            personelListele();

            sehirListesi();

            temizle();
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_PERSONELLER (AD, SOYAD, TELEFON, TC, MAIL, IL, ILCE, ADRES, GOREV)" +
                                              "Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtel1.Text);
            komut.Parameters.AddWithValue("@p4", txtc.Text);
            komut.Parameters.AddWithValue("@p5", txmail.Text);
            komut.Parameters.AddWithValue("@p6", txil.Text);
            komut.Parameters.AddWithValue("@p7", txilce.Text);
            komut.Parameters.AddWithValue("@p8", txadres.Text);
            komut.Parameters.AddWithValue("@p9", txgorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_PERSONELLER Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            personelListele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_PERSONELLER SET " +
                                                       "AD=@p1, SOYAD=@p2, TELEFON=@p3, TC=@p4, MAIL=@p5, IL=@p6, ILCE=@p7, ADRES=@p8, GOREV=@p9 " +
                                                       "WHERE ID=@p10", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtel1.Text);
            komut.Parameters.AddWithValue("@p4", txtc.Text);
            komut.Parameters.AddWithValue("@p5", txmail.Text);
            komut.Parameters.AddWithValue("@p6", txil.Text);
            komut.Parameters.AddWithValue("@p7", txilce.Text);
            komut.Parameters.AddWithValue("@p8", txadres.Text);
            komut.Parameters.AddWithValue("@p9", txgorev.Text);
            komut.Parameters.AddWithValue("@p10", txid.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["ID"].ToString();
                txad.Text = dr["AD"].ToString();
                txsoyad.Text = dr["SOYAD"].ToString();
                txtel1.Text = dr["TELEFON"].ToString();
                txtc.Text = dr["TC"].ToString();
                txmail.Text = dr["MAIL"].ToString();
                txil.Text = dr["IL"].ToString();
                txilce.Text = dr["ILCE"].ToString();
                txgorev.Text = dr["GOREV"].ToString();
                txadres.Text = dr["ADRES"].ToString();

            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
