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

namespace HastaneProjesi
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();//0. indexi(Hastaid) yazdırmamıza gerek yok.
                TxtSoyad.Text = dr[2].ToString();
                //TCno yu daha önce çektiğimiz için tekrar çekmeye gerek yok.
                MskTelefon.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
                MskTC.Enabled = false;
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd2.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            cmd2.Parameters.AddWithValue("@p3",MskTelefon.Text);
            cmd2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            cmd2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            cmd2.Parameters.AddWithValue("@p6", MskTC.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
