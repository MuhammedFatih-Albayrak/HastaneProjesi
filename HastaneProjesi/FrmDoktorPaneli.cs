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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();



        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Doktorlar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Comboboxa Veri Çekme
            SqlCommand cmd3 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", MskTC.Text);
            cmd.Parameters.AddWithValue("@p5", TxtSifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor kaydı oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbBrans.Text = "";
            MskTC.Text = "";
            TxtSifre.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int slctd = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[slctd].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[slctd].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[slctd].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[slctd].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[slctd].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor kaydı silindi.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@d1", TxtAd.Text);
            cmd2.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            cmd2.Parameters.AddWithValue("@d3", CmbBrans.Text);
            cmd2.Parameters.AddWithValue("@d4", MskTC.Text);
            cmd2.Parameters.AddWithValue("@d5", TxtSifre.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
