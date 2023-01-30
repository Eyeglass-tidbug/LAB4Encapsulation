using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LAB4Encapsulation
{
    public class Person
    {
        private string name;
        private int age;
        private int birthyear;
        private float gpa;

       public Person(string name, int byear, float igpa) {
            this.name = name;
            this.gpa = igpa;
            this.birthyear = byear;
            this.age = 2565 - byear;
        }
        public int getage() {
            return this.age;
        }

        public string getname()
        {
            return this.name;
        }

        public float getgpa()
        {
            return this.gpa;
        }
    }
}
