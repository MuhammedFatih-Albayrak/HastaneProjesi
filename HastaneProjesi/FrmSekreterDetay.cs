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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            MskSaat.Text = DateTime.Now.ToLongTimeString();

            LblTC.Text = TCno;

            //Ad Soyad Çekme
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride aktarma
            DataTable dt1 = new DataTable();//dt1 nesnesi yardımıyla aktarma işlemi gerçekleşicek.
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Branslar",bgl.baglanti());
            da1.Fill(dt1);//DataAdpaterı datatable ile doldur.
            dataGridViewBranslar.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select(DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridViewDoktorlar.DataSource = dt2;

            //Branşları comboxa çekme
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Randevu Kayıt
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuDoktor,RandevuBrans) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", CmbDoktor.Text);
            komutKaydet.Parameters.AddWithValue("@r4", CmbBrans.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu kayıt oluşturuldu.");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void MskSaat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", richTextBoxDuyuru.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fbp = new FrmBransPaneli();
            fbp.Show();
        }

        private void BtnRandevuPaneli_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
    }
}
