using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzeszukiwanieWGlab
{
    public partial class Form1 : Form
    {
        int index = 0;
        int dlugoscOkienka = 20;

        string napis = "";

        string wczesniejsza = "";
        public Form1()
        {
            InitializeComponent();

            napis = lblText.Text;

            for (int i = 0; i < dlugoscOkienka; ++i)
                napis = " " + napis + " ";

            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t_Tick(object sender, EventArgs e)
        {

            if (index + dlugoscOkienka == napis.Length)
                index = 0;


            lblText.Text = napis.Substring(index, dlugoscOkienka);
            index++;

           







            //if (this.index >= lblText.Text.Length)
            //    this.index = 0;

            //string jeszczeWczesniej = this.wczesniejsza;
            //this.wczesniejsza = lblText.Text[this.index].ToString();

            //string nowy = "";

            //if (index - 1 > 0)
            //{
            //    nowy = lblText.Text.Substring(0, index - 1);
            //}

            //if(jeszczeWczesniej != "")
            //    nowy += jeszczeWczesniej;

            //nowy += "-";

            //if(lblText.Text.Length - index - 1 > 1)
            //{
            //    nowy += lblText.Text.Substring(index + 1, lblText.Text.Length - index - 1);
            //} 

            //this.index++;

            

            //lblText.Text = nowy;


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            t.Stop();

            t.Interval = (int)numericUpDown1.Value;
            
            t.Start();
        }
    }
}
