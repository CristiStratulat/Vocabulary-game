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

namespace VocabularGame
{
    public partial class AddWordEnglish : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Vocabular.mdf;Integrated Security=True;Connect Timeout=30");
        public AddWordEnglish()
        {
            InitializeComponent();
        }

        private void AddWordEnglish_Load(object sender, EventArgs e)
        {

        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Table] (WordEngl,TranslateEngl) values ('" + textBox2.Text + "','" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox2.Text = "";
            textBox1.Text = "";
            MessageBox.Show("Data inserted successfully!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Table] where WordEngl='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox2.Text = "";
            MessageBox.Show("Delete successfully!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
