using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularGame
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Modify m = new Modify();
            m.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Vocabulary v = new Vocabulary();
            v.Show();
           
        }

        private void btnAddEnglish_Click(object sender, EventArgs e)
        {
            AddWordEnglish add = new AddWordEnglish();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VocabularEnglish v1 = new VocabularEnglish();
            v1.Show();

        }

  
    }
}
