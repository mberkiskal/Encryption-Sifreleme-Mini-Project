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

namespace p13EncryptedData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p13Sifreleme;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Veriler", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID");
            dt2.Columns.Add("AD");
            dt2.Columns.Add("SOYAD");
            dt2.Columns.Add("MAIL");
            dt2.Columns.Add("SIFRE");
            dt2.Columns.Add("HESAPNO");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataRow r = dt2.NewRow();
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        string cozum = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        byte[] cozumdizi = Convert.FromBase64String(cozum);
                        string cozumveri = ASCIIEncoding.ASCII.GetString(cozumdizi);
                        r[j] = cozumveri;
                    }
                    catch (Exception)
                    {
                        r[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                dt2.Rows.Add(r);
            }
            dataGridView2.DataSource = dt2;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = txtSoyad.Text;
            byte[] soyaddizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizisi);

            string mail = txtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = txtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string acnu = txtHesapNo.Text;
            byte[] acnudizi = ASCIIEncoding.ASCII.GetBytes(acnu);
            string acnusifre = Convert.ToBase64String(acnudizi);

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Veriler (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1",adsifre);
            cmd.Parameters.AddWithValue("@p2", soyadsifre);
            cmd.Parameters.AddWithValue("@p3",mailsifre);
            cmd.Parameters.AddWithValue("@p4", sifresifre);
            cmd.Parameters.AddWithValue("@p5", acnusifre);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Veriler Eklendi");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
