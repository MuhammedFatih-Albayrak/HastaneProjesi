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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            //Ad Soyad çekme
            SqlCommand cmd = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();//Veri okuma işlemi için
            while (dr.Read())
            {
                LblNullNull.Text = " "+dr[0] +"\n"+ dr[1];//Bize iki tane sütun döndürücek.Birincisi HastaAd,diğeri de HastaSoyad.
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand cmd2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand cmd3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "'" + "and RandevuDoktor='" + CmbDoktor.Text+"'"+"and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int slctd = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[slctd].Cells[0].Value.ToString();
            CmbBrans.Text = dataGridView2.Rows[slctd].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView2.Rows[slctd].Cells[4].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {            
            SqlCommand cmd = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            cmd.Parameters.AddWithValue("@p2", RİchTxtSikayet.Text);
            cmd.Parameters.AddWithValue("@p3", Txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
        }

        private void Btn_Cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
