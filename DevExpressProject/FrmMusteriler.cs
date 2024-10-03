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
using DevExpress.XtraDashboardLayout;


namespace DevExpressProject
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();

            sehirListesi();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRE,ADRES)" +
                                  "Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtel1.Text);
            komut.Parameters.AddWithValue("@p4", txtel2.Text);
            komut.Parameters.AddWithValue("@p5", txtc.Text);
            komut.Parameters.AddWithValue("@p6", txmail.Text);
            komut.Parameters.AddWithValue("@p7", txil.Text);
            komut.Parameters.AddWithValue("@p8", txilce.Text);
            komut.Parameters.AddWithValue("@p9", txvergid.Text);
            komut.Parameters.AddWithValue("@p10", txadres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_MUSTERILER Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
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
                txtel2.Text = dr["TELEFON2"].ToString();
                txtc.Text = dr["TC"].ToString();
                txmail.Text = dr["MAIL"].ToString();
                txil.Text = dr["IL"].ToString();
                txilce.Text = dr["ILCE"].ToString();
                txvergid.Text = dr["VERGIDAIRE"].ToString();
                txadres.Text = dr["ADRES"].ToString();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_MUSTERILER SET " +
                                  "AD=@p1, SOYAD=@p2, TELEFON=@p3, TELEFON2=@p4, TC=@p5, MAIL=@p6, IL=@p7, ILCE=@p8, VERGIDAIRE=@p9, ADRES=@p10 " +
                                  "WHERE ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtel1.Text);
            komut.Parameters.AddWithValue("@p4", txtel2.Text);
            komut.Parameters.AddWithValue("@p5", txtc.Text);
            komut.Parameters.AddWithValue("@p6", txmail.Text);
            komut.Parameters.AddWithValue("@p7", txil.Text);
            komut.Parameters.AddWithValue("@p8", txilce.Text);
            komut.Parameters.AddWithValue("@p9", txvergid.Text);
            komut.Parameters.AddWithValue("@p10", txadres.Text);
            komut.Parameters.AddWithValue("@p11", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
