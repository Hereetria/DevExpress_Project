using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DevExpressProject
{
    public partial class FrmFaturaDetayGuncelleme : Form
    {
        public FrmFaturaDetayGuncelleme()
        {
            InitializeComponent();
        }

        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FaturaDetayGuncelleme_Load(object sender, EventArgs e)
        {
            txurunid.Text = urunid; 
            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FATURAURUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txurunid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txfiyat.Text = dr[3].ToString();
                txmiktar.Text = dr[2].ToString();
                txtutar.Text = dr[4].ToString();
                txurunad.Text = dr[1].ToString();

                bgl.baglanti().Close();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_FATURADETAY SET URUNAD = @p1, MIKTAR = @p2, FIYAT = @p3, TUTAR = @p4 WHERE FATURAURUNID = @p5", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txurunad.Text);
            komut.Parameters.AddWithValue("@p2", txmiktar.Text); 
            komut.Parameters.AddWithValue("@p3", txfiyat.Text);
            komut.Parameters.AddWithValue("@p4", txtutar.Text); 
            komut.Parameters.AddWithValue("@p5", txurunid.Text); 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Detayı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_FATURADETAY Where FATURAURUNID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txurunid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urun Detayı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
