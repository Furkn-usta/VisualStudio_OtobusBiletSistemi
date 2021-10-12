using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace otobus_otomasyon
{
    public partial class biletal : Form
    {
        public biletal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.; initial Catalog=otobus; Integrated Security=true");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        public static string tc = "";
        public static string ad = "";
        public static string soyad = "";
        public static string biletsatan = "";
        public static string yas = "";
        public static string telefon = "";
        public static string cinsiyet = "";
        public static string sefernereden = "";
        public static string sefernereye = "";
        public static string adı = "";
        public static string sefersaat = "";
        public static string sefertarih = "";
        public static string arac = "";
        public static string arac_fiyat = "";
        public static string seferid = "";
        public static string bilet_nom = "";
        void griddoldur()
        {
            
            da = new SqlDataAdapter("select * from sefer", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "sefer");
            dataGridView1.DataSource = ds.Tables["sefer"];
            baglanti.Close();
            dataGridView1.Columns[0].Visible = false; //KOLON GİZLEME
            dataGridView1.Columns[1].Visible = false; //KOLON GİZLEME
            dataGridView1.Columns[2].Visible = false; //KOLON GİZLEME

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tc = textBox1.Text;

            sefersaat = comboBox5.Text;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            biletsatan = "Admin";
            yas = comboBox1.Text;
            cinsiyet = comboBox2.Text;
            telefon = textBox4.Text;
            sefernereden = comboBox3.Text.ToLower();
            sefernereye = comboBox4.Text.ToLower();
            sefertarih = textBox5.Text;
            arac = comboBox6.Text;

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from sefer where sefer_saati = '" + sefersaat + "'and sefer_tarihi = '" + sefertarih + "'and sefer_nereden = '" + sefernereden + "'and sefer_nereye = '" + sefernereye + "'and arac_adi='" + arac + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                seferid = oku[1].ToString();
                koltuk_Sec koltuk = new koltuk_Sec();
                koltuk.Show();



            }
            else
            {
                MessageBox.Show("Böyle bir sefer bulunmamaktadır  !");
                button3.Enabled = true;
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string aracid = "";
            SqlCommand komut = new SqlCommand("SELECT * FROM arac WHERE arac_adi='" + comboBox6.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                aracid = oku["id"].ToString();



            }


            baglanti.Close();
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into sefer (arac_id,arac_adi,sefer_saati,sefer_tarihi,sefer_nereden,sefer_nereye ) values ('" + aracid + "','" + arac + "','" + sefersaat + "','" + sefertarih + "','" + sefernereden + "','" + sefernereye + "')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                button3.Enabled = false;
                griddoldur();
                MessageBox.Show("işleminiz başarılı");
                

            }
            catch (Exception hata)
            {

                MessageBox.Show("sefer ekleme başarısız!!!" + hata.Message);
                button3.Enabled = false;
            }
        }

        private void biletal_Load(object sender, EventArgs e)
        {

            griddoldur();


           // textBox6.Text = Login.k_adi;
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("Select * from City", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                comboBox3.Items.Add(oku["name"].ToString());
                comboBox4.Items.Add(oku["name"].ToString());



            }
            baglanti.Close();
            comboBox6.Items.Clear();
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("Select * from arac", baglanti);
            SqlDataReader oku2 = komutt.ExecuteReader();
            while (oku2.Read())
            {

                comboBox6.Items.Add(oku2["arac_adi"].ToString());




            }
            baglanti.Close();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker2.Value.Date.ToString("dd/MM/yyyy");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("Select * from arac where arac_adi='" + comboBox6.Text + "'", baglanti);
            SqlDataReader oku2 = komutt.ExecuteReader();
            while (oku2.Read())
            {

                arac_fiyat = oku2["bilet_fiyat"].ToString();




            }
            baglanti.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
