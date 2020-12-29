using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace VtysProje
{
    public partial class frmAlisVeris : Form
    {
        public frmAlisVeris()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=AlisVeris;User Id=postgres;Password=1999/*-+");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM \"Insan\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (tbxId.Text != "")
            {
                MessageBox.Show("Id alanı otomatik belirlenir. Lütfen boş bırakınız.");
            }
            else 
            {
                string sqlEkle = "INSERT INTO \"Insan\"(\"siparisNo\",\"iletisimNo\",\"adi\",\"soyAdi\",\"kisiTuru\",\"durumId\",\"cinsiyet\")" + "VALUES(@p1 ,@p2,@p3,@p4,@p5,@p6,@p7)";

                NpgsqlCommand ekle = new NpgsqlCommand(sqlEkle, baglanti);
                ekle.Parameters.AddWithValue("@p1", int.Parse(tbxSiparisNo.Text));
                ekle.Parameters.AddWithValue("@p2", int.Parse(tbxIletisimNo.Text));
                ekle.Parameters.AddWithValue("@p3", tbxAdi.Text);
                ekle.Parameters.AddWithValue("@p4", tbxSoyAdi.Text);
                ekle.Parameters.AddWithValue("@p5", tbxKisiTuru.Text);
                ekle.Parameters.AddWithValue("@p6", int.Parse(tbxDurumId.Text));
                ekle.Parameters.AddWithValue("@p7", tbxCinsiyet.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme işlemi gerçekleşti.");
                    
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = int.Parse(tbxId.Text);
            string sqlSil = "DELETE FROM \"Insan\" WHERE \"Id\" =" + id + "";
         
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                NpgsqlCommand sil = new NpgsqlCommand(sqlSil, baglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            baglanti.Close();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox tbx = (TextBox)item;
                    tbx.Clear();
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sqlGuncelle = "UPDATE \"Insan\" SET \"siparisNo\"=  @p1  ,\"iletisimNo\"=@p2,\"adi\"=@p3,\"soyAdi\"=@p4,\"kisiTuru\"=@p5,\"durumId\"=@p6,\"cinsiyet\"=@p7 WHERE \"Id\"=@p8";

            NpgsqlCommand guncelle = new NpgsqlCommand(sqlGuncelle, baglanti);
            guncelle.Parameters.AddWithValue("@p1", int.Parse(tbxSiparisNo.Text));
            guncelle.Parameters.AddWithValue("@p2", int.Parse(tbxIletisimNo.Text));
            guncelle.Parameters.AddWithValue("@p3", tbxAdi.Text);
            guncelle.Parameters.AddWithValue("@p4", tbxSoyAdi.Text);
            guncelle.Parameters.AddWithValue("@p5", tbxKisiTuru.Text);
            guncelle.Parameters.AddWithValue("@p6", int.Parse(tbxDurumId.Text));
            guncelle.Parameters.AddWithValue("@p7", tbxCinsiyet.Text);
            guncelle.Parameters.AddWithValue("@p8", int.Parse(tbxId.Text));
       
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tbxAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("SELECT * FROM \"Insan\" WHERE \"adi\" LIKE '%" + tbxAra.Text + "%' ", baglanti);
            ara.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        
    }
}
