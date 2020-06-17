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
    public partial class Vocabulary : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Vocabular.mdf;Integrated Security=True;Connect Timeout=30");
        public Vocabulary()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string raspuns;
        bool pressedCheck { get; set; }
        private void btnNext_Click(object sender, EventArgs e)
        {
            pressedShow = false;
            textBox1.ForeColor = Color.Black;
            textBox1.ReadOnly = false;
            if (textBox1.Text != ""&&pressedCheck==true)
            {
                pressedCheck=false;
                con.Open();
                string select = "select top 1 [Translate] from [Words] order by NEWID()";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label1.Text = dr["Translate"].ToString();
                }
                con.Close();
                textBox1.Text = "";
            }
        }
        int k { get; set; }
        int rasp { get; set; }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (pressedShow == false)
            {
                con.Open();
                pressedCheck = true;
                string sqlSelectQuery = "select [Word] from [Words] where Translate='" + label1.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    raspuns = (dr["Word"].ToString());

                    if (raspuns == textBox1.Text)
                    {
                        k++;
                        rasp++;
                        MessageBox.Show("DA", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pressedShow = true;
                        lblScore.Text = k + "/" + rasp;

                    }
                    else
                    {
                        rasp++;
                        MessageBox.Show("NU", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblScore.Text = k + "/" + rasp;

                    }
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ä";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ö";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ü";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ß";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Ä";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Ö";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Ü";
        }

        private void Vocabulary_Load(object sender, EventArgs e)
        {
            k = 0;
            rasp = 0;
            con.Open();
            string select = "select top 1 [Translate] from [Words] order by NEWID()";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["Translate"].ToString();
            }
            con.Close();
        }
        bool pressedShow { get; set; }
        int x = 0;
        private void btnShow_Click(object sender, EventArgs e)
        {
            con.Open();
            string select = "select [Word] from Words where Translate='"+label1.Text+"'";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox1.Text = dr["Word"].ToString();
                textBox1.ForeColor = Color.Red;
                pressedCheck = true;
                textBox1.ReadOnly = true;
                
            }
            if (pressedShow == false)
            {
                x++;
                lblScore.Text = k + "/" + rasp;
                lblCount.Text = x.ToString();
                pressedShow = true;
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
