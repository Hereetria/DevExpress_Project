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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void txkaydet_Click(object sender, EventArgs e)
        {
            //Veri Kaydet
            SqlCommand komut = new SqlCommand("Insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY)" +
                                              "Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txmarka.Text);
            komut.Parameters.AddWithValue("@p3", txmodel.Text);
            komut.Parameters.AddWithValue("@p4", txyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((txadet.Value).ToString())); 
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txalisfiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txsatisfiyat.Text));
            komut.Parameters.AddWithValue("@p8", txdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txid.Text = dr["ID"].ToString();
            txad.Text = dr["URUNAD"].ToString();
            txmarka.Text = dr["MARKA"].ToString();
            txmodel.Text = dr["MODEL"].ToString();
            txyil.Text = dr["YIL"].ToString();
            txadet.Value = decimal.Parse(dr["ADET"].ToString());
            txalisfiyat.Text = dr["ALISFIYAT"].ToString();
            txsatisfiyat.Text = dr["SATISFIYAT"].ToString();
            txdetay.Text = dr["DETAY"].ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_URUNLER SET " +
                                              "URUNAD=@P1, MARKA=@P2, MODEL=@P3, YIL=@P4, ADET=@P5, ALISFIYAT=@P6, SATISFIYAT=@P7, DETAY=@P8 " +
                                              "WHERE ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txmarka.Text);
            komut.Parameters.AddWithValue("@p3", txmodel.Text);
            komut.Parameters.AddWithValue("@p4", txyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((txadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txalisfiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txsatisfiyat.Text));
            komut.Parameters.AddWithValue("@p8", txdetay.Text);
            komut.Parameters.AddWithValue("@p9", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
