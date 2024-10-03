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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txid.Text = "";
            txseri.Text = "";
            txsirano.Text = "";
            txtarih.Text = " ";
            txsaat.Text = "";
            txvergid.Text = "";
            txalici.Text =  "";
            txteden.Text = "";
            txtalan.Text = "";

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();

            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txfaturaid.Text == "")
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_FATURABILGI (SERI, SIRANO, TARIH, SAAT, VERGIDAIRE, ALICI, TESLIMEDEN, TESLIMALAN) " +
                                  "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txseri.Text);
                komut.Parameters.AddWithValue("@p2", txsirano.Text);
                komut.Parameters.AddWithValue("@p3", txtarih.Text);
                komut.Parameters.AddWithValue("@p4", txsaat.Text);
                komut.Parameters.AddWithValue("@p5", txvergid.Text);
                komut.Parameters.AddWithValue("@p6", txalici.Text);
                komut.Parameters.AddWithValue("@p7", txteden.Text);
                komut.Parameters.AddWithValue("@p8", txtalan.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else if (txfaturaid.Text != " ")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txfiyat.Text);
                miktar = Convert.ToDouble(txmiktar.Text);
                tutar = miktar * fiyat;
                txtutar.Text = tutar.ToString(); 

                SqlCommand komut = new SqlCommand("INSERT INTO TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID) " +
                                  "VALUES (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txurunad.Text);
                komut.Parameters.AddWithValue("@p2", txmiktar.Text);
                komut.Parameters.AddWithValue("@p3", txfiyat.Text);
                komut.Parameters.AddWithValue("@p4", txtutar.Text);
                komut.Parameters.AddWithValue("@p5", txfaturaid.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Detayı Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["FATURABILGIID"].ToString();
                txseri.Text = dr["SERI"].ToString();
                txsirano.Text = dr["SIRANO"].ToString();
                txtarih.Text = dr["TARIH"].ToString();
                txsaat.Text = dr["SAAT"].ToString();
                txvergid.Text = dr["VERGIDAIRE"].ToString();
                txalici.Text = dr["ALICI"].ToString();
                txteden.Text = dr["TESLIMEDEN"].ToString();
                txtalan.Text = dr["TESLIMALAN"].ToString();
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_FATURABILGI Where FATURABILGIID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_FATURABILGI " +
                                  "SET SERI = @p1, SIRANO = @p2, TARIH = @p3, SAAT = @p4, VERGIDAIRE = @p5, ALICI = @p6, TESLIMEDEN = @p7, TESLIMALAN = @p8 " +
                                  "WHERE FATURABILGIID = @p9", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txseri.Text);
            komut.Parameters.AddWithValue("@p2", txsirano.Text);
            komut.Parameters.AddWithValue("@p3", txtarih.Text);
            komut.Parameters.AddWithValue("@p4", txsaat.Text);
            komut.Parameters.AddWithValue("@p5", txvergid.Text);
            komut.Parameters.AddWithValue("@p6", txalici.Text);
            komut.Parameters.AddWithValue("@p7", txteden.Text);
            komut.Parameters.AddWithValue("@p8", txtalan.Text);
            komut.Parameters.AddWithValue("@p9", txid.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunler fr = new FrmFaturaUrunler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null )
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }
    }
}
