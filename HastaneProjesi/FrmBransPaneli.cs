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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);//SELECT SORGUSU İLE VERİYİ, VERİ TABANINDAN DATATABLE A DOLDURUYORUZZ.
            dataGridView1.DataSource = dt;//VERİ KAYNAĞINI BELİRTİYORUZZ.
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni branş eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Delete from Tbl_Branslar where Bransid=@b1",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@b1", TxtBransid.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş kaydı silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int slctd = dataGridView1.SelectedCells[0].RowIndex;
            TxtBransid.Text = dataGridView1.Rows[slctd].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[slctd].Cells[1].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("update Tbl_Branslar set BransAd=@c1 where Bransid=@c2",bgl.baglanti());
            cmd3.Parameters.AddWithValue("@c1", TxtBransAd.Text);
            cmd3.Parameters.AddWithValue("@c2", TxtBransid.Text);
            cmd3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
