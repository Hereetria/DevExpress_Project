using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        void giderListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txid.Text = " "; // ID
            txay.Text = " "; // AY
            txyil.Text = " "; // YIL
            txelektrik.Text = " "; // ELEKTRIK
            txsu.Text = "  "; // SU
            txdogalgaz.Text = "  "; // DOGALGAZ
            txinternet.Text = "  "; // INTERNET
            txmaaslar.Text = "  "; // MAASLAR
            txextra.Text = "  "; // EXTRA
            txnotlar.Text = "  "; // NOTLAR

        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListele();

            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_GIDERLER (AY, YIL, ELEKTRIK, SU, DOGALGAZ, INTERNET, MAASLAR, EXTRA, NOTLAR) " +
                                   "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txay.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p2", txyil.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txelektrik.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(txsu.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(txdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(txinternet.Text));
            komut.Parameters.AddWithValue("@p7", Convert.ToDecimal(txmaaslar.Text));
            komut.Parameters.AddWithValue("@p8", Convert.ToDecimal(txextra.Text));
            komut.Parameters.AddWithValue("@p9", txnotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListele();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_GIDERLER Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            giderListele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_GIDERLER SET " +
                                   "AY=@p1, YIL=@p2, ELEKTRIK=@p3, SU=@p4, DOGALGAZ=@p5, INTERNET=@p6, MAASLAR=@p7, EXTRA=@p8, NOTLAR=@p9 " +
                                   "WHERE ID=@p10", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txay.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p2", txyil.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txelektrik.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(txsu.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(txdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(txinternet.Text));
            komut.Parameters.AddWithValue("@p7", Convert.ToDecimal(txmaaslar.Text));
            komut.Parameters.AddWithValue("@p8", Convert.ToDecimal(txextra.Text));
            komut.Parameters.AddWithValue("@p9", txnotlar.Text);
            komut.Parameters.AddWithValue("@p10", txid.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["ID"].ToString();
                txay.SelectedItem = dr["AY"].ToString();
                txyil.SelectedItem = dr["YIL"].ToString();
                txelektrik.Text = dr["ELEKTRIK"].ToString();
                txsu.Text = dr["SU"].ToString();
                txdogalgaz.Text = dr["DOGALGAZ"].ToString();
                txinternet.Text = dr["INTERNET"].ToString();
                txmaaslar.Text = dr["MAASLAR"].ToString();
                txextra.Text = dr["EXTRA"].ToString();
                txnotlar.Text = dr["NOTLAR"].ToString();
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}