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
        Classroom classroom;
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
            double Pgpa = int.Parse(ingpa);

            Person person = new Person(inname, Pbirthyear, Pgpa);

            this.classroom.AddPerson(person);
            this.classroom.addGPA();
            //this.Listname.Text = this.classroom.showAllpersoninclass();

            int currentAge = Int32.Parse(this.Allage.Text);
            int newTotal = currentAge + this.classroom.totalClass_age();
            this.Allage.Text = newTotal.ToString();

            double Maxgpa = this.classroom.showMaxgpa();
            this.maxgpa.Text = Maxgpa.ToString();

            double Mingpa = this.classroom.showmingpa();
            this.mingpa.Text = Mingpa.ToString();

            double Avggpa = this.classroom.AvgGpa();
            this.avg_gpa.Text = Avggpa.ToString();

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

        private void Allage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
