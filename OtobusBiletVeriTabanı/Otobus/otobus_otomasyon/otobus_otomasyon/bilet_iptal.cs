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
    public partial class bilet_iptal : Form
    {
        public bilet_iptal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.; initial Catalog=otobus; Integrated Security=true");
        DataSet dset = new DataSet();

        public void doldur()
        {
            baglanti.Open();
            dset.Clear();

            SqlDataAdapter adtr2 = new SqlDataAdapter("select * From  satis ORDER BY id DESC", baglanti);

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

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from satis where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
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

        private void bilet_iptal_Load(object sender, EventArgs e)
        {
            doldur();
        }
    }
}
