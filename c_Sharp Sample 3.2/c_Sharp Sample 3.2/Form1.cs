using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_Sharp_Sample_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string language = cmdLanguage.Text.Trim().ToLower();
            string greet = "";

            
            if (language == "english")
            {
                greet = "Good Morning.";
            }
            else if (language == "tagalog")
            {
                greet = "Magandang Umaga.";
            }
            else if (language == "hiligaynon")
            {
                greet = "Maayong Aga.";
            }
            else if (language == "bisaya")
            {
                greet = "Maayong Buntag.";
            }

          
            greet += " Gilbert";

            
            MessageBox.Show(greet);


        }
    }
}
