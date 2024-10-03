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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_ADMIN Where kullaniciAd=@p1 and sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) 
            { 
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adi veya sifre");
            }
        }
    }
}
