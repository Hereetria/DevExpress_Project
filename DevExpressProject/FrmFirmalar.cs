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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmaListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
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

        void cariKodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 From TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txkodanlam1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            txid.Text = " ";
            txad.Text = " ";
            txsektor.Text = " ";
            txyetkili.Text = " ";
            txygorev.Text = " ";
            txtc.Text = " ";
            txtel1.Text = " ";
            txtel2.Text = " ";
            txtel3.Text = " ";
            txfax.Text = " ";
            txmail.Text = " ";
            txil.Text = " ";
            txilce.Text = " ";
            txvergid.Text = " ";
            txadres.Text = " ";
            txkod1.Text = " ";
            txkod2.Text = " ";
            txkod3.Text = " ";
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListe();

            sehirListesi();

            cariKodAciklamalar();

            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["ID"].ToString();
                txad.Text = dr["AD"].ToString();
                txsektor.Text = dr["YETKILISTATU"].ToString();
                txyetkili.Text = dr["YETKILIADSOYAD"].ToString();
                txygorev.Text = dr["YETKILITC"].ToString();
                txtc.Text = dr["SEKTOR"].ToString();
                txtel1.Text = dr["TELEFON1"].ToString();
                txtel2.Text = dr["TELEFON2"].ToString();
                txtel3.Text = dr["TELEFON3"].ToString();
                txfax.Text = dr["FAX"].ToString();
                txmail.Text = dr["MAIL"].ToString();
                txil.Text = dr["IL"].ToString();
                txilce.Text = dr["ILCE"].ToString();
                txvergid.Text = dr["VERGIDAIRE"].ToString();
                txadres.Text = dr["ADRES"].ToString();
                txkod1.Text = dr["OZELKOD1"].ToString();
                txkod2.Text = dr["OZELKOD2"].ToString();
                txkod3.Text = dr["OZELKOD3"].ToString();

            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_FIRMALAR (AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR, TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRE, ADRES, OZELKOD1, OZELKOD2, OZELKOD3)" +
                                                  "Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsektor.Text);
            komut.Parameters.AddWithValue("@p3", txyetkili.Text);
            komut.Parameters.AddWithValue("@p4", txygorev.Text);
            komut.Parameters.AddWithValue("@p5", txtc.Text);
            komut.Parameters.AddWithValue("@p6", txtel1.Text);
            komut.Parameters.AddWithValue("@p7", txtel2.Text);
            komut.Parameters.AddWithValue("@p8", txtel3.Text);
            komut.Parameters.AddWithValue("@p9", txfax.Text);
            komut.Parameters.AddWithValue("@p10", txmail.Text);
            komut.Parameters.AddWithValue("@p11", txil.Text);
            komut.Parameters.AddWithValue("@p12", txilce.Text);
            komut.Parameters.AddWithValue("@p13", txvergid.Text);
            komut.Parameters.AddWithValue("@p14", txadres.Text);
            komut.Parameters.AddWithValue("@p15", txkod1.Text);
            komut.Parameters.AddWithValue("@p16", txkod2.Text);
            komut.Parameters.AddWithValue("@p17", txkod3.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListe();
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_FIRMALAR Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            firmaListe();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_FIRMALAR SET " +
                                  "AD=@p1, YETKILISTATU=@p2, YETKILIADSOYAD=@p3, YETKILITC=@p4, SEKTOR=@p5, TELEFON1=@p6, TELEFON2=@p7, TELEFON3=@p8, " +
                                  "MAIL=@p9, FAX=@p10, IL=@p11, ILCE=@p12, VERGIDAIRE=@p13, ADRES=@p14, OZELKOD1=@p15, OZELKOD2=@p16, OZELKOD3=@p17 " +
                                  "WHERE ID=@p18", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsektor.Text);
            komut.Parameters.AddWithValue("@p3", txyetkili.Text);
            komut.Parameters.AddWithValue("@p4", txygorev.Text);
            komut.Parameters.AddWithValue("@p5", txtc.Text);
            komut.Parameters.AddWithValue("@p6", txtel1.Text);
            komut.Parameters.AddWithValue("@p7", txtel2.Text);
            komut.Parameters.AddWithValue("@p8", txtel3.Text);
            komut.Parameters.AddWithValue("@p9", txfax.Text);
            komut.Parameters.AddWithValue("@p10", txmail.Text);
            komut.Parameters.AddWithValue("@p11", txil.Text);
            komut.Parameters.AddWithValue("@p12", txilce.Text);
            komut.Parameters.AddWithValue("@p13", txvergid.Text);
            komut.Parameters.AddWithValue("@p14", txadres.Text);
            komut.Parameters.AddWithValue("@p15", txkod1.Text);
            komut.Parameters.AddWithValue("@p16", txkod2.Text);
            komut.Parameters.AddWithValue("@p17", txkod3.Text);
            komut.Parameters.AddWithValue("@p18", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firmaListe();
            temizle();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
