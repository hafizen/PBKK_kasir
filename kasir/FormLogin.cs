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

namespace kasir
{
    public partial class FormLogin : Form
    {
          /*
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi Conn = new Koneksi();

        */
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Conn.Open();
            cmd = new SqlCommand("select * from TB_KASIR where KodeKasir=" + textBox1.Text +
                " ans PasswordKasir=" + textBox2.Text + "", Conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                FormMenuUtama frmUtama = new FormMenuUtama();
                frmUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tidak Valid");
            }
            */

            if (textBox1.Text == "ksr001" && textBox2.Text == "admin")
            {
                FormMenuUtama frmUtama = new FormMenuUtama();
                frmUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tidak Valid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
