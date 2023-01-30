using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Classroom classroom = new Classroom("OOP");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //getname
            string inname = this.INname.Text;
            //get year
            string inbirthyear = this.INbirthyear.Text;
            int Pbirthyear = Int32.Parse(inbirthyear);
            //get gpa
            string ingpa = this.INgpa.Text;
            float Pgpa = int.Parse(ingpa);
            //pass all in
            Person person = new Person(inname, Pbirthyear, Pgpa);
            //show name in listname
            //Listname.Text += person.getname()+ "\r\n";
            Classroom classroom = new Classroom("OOP");
            //sigma all age
            int Cal_age = person.getage() + Int32.Parse(this.Allage.Text);
            Allage.Text = Cal_age.ToString();
            //max gpa

            INname.Text = "";
            INbirthyear.Text = "";
            INgpa.Text = "";
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
