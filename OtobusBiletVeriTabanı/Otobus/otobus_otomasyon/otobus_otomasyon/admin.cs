﻿using System;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.; initial Catalog=otobus; Integrated Security=true");
        DataSet dset = new DataSet();
        public void doldur()
        {
            baglanti.Open();
            dset.Clear();

            SqlDataAdapter adtr2 = new SqlDataAdapter("select * From  admin ORDER BY id DESC", baglanti);

            adtr2.Fill(dset, "kullanici");

            dataGridView1.DataSource = dset.Tables["kullanici"];

            adtr2.Dispose();
            dataGridView1.RowHeadersVisible = false; //En Baştaki Boş Kolonun Gizlenmesini sağlar 
            dataGridView1.Columns[0].Visible = false;
           //bazı gereksiz kısımları görünmez yaptık görüntü güzelleştirmek açısından "id şifre gibi."
            dataGridView1.MultiSelect = false;//birden fazla satır seçielemez
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // seçdiğimiz datagrid satırı tamamen satırca seçilmiş görülür
           

            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into admin(k_adi,sifre) values('"+textBox1.Text+"','"+textBox2.Text+"')",baglanti);
            ekle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            doldur();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                 SqlCommand   komut = new SqlCommand("delete from admin where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşleme Başarıyla Tamamlandı");
                baglanti.Close();
                doldur();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message); ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_panel ap = new admin_panel();
            ap.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("UPDATE admin set k_adi='"+textBox1.Text+"',sifre='"+textBox2.Text+"' where id ='"+ dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'",baglanti);
            guncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["k_adi"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
