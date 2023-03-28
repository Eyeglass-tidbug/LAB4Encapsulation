using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    public class Classroom
    {
        string name;
        private List<Person> person = new List<Person>();
        private List<double> ClasGPA = new List<double>();
        private List<string> Clasname = new List<string>();

        public Classroom(string name)
        {
            this.name = name;
        }

        public void AddPerson(Person p) {
            this.person.Add(p);
        }

        public string showAllpersoninclass()
        {
            string result = " ";
            foreach (Person p in this.person)
            {
                result += p.getname() + "\r\n";
            }
            Console.Write(result);
            return result;
        }

        public int totalClass_age()
        {
            int age = 0;
            foreach (Person person in this.person)
            {
                age += person.getage();
            }
            return age;
        }

        public void addGPA()
        {
            foreach (Person person in this.person) 
            {
                ClasGPA.Add(person.getgpa());
                Clasname.Add(person.getname());
            }
        }

        public double showMaxgpa()
        {
            double maxgpa = ClasGPA.Max();
            return maxgpa;
        }

        public double showmingpa()
        {
            double mingpa = ClasGPA.Min();
            return mingpa;
        }
        
        public double AvgGpa()
        {
            double avggpa = ClasGPA.Average();
            return avggpa;
        }
        public string showNameMax()
        {
            return Clasname[ClasGPA.IndexOf(ClasGPA.Max())];
        }

        public string showNameMin()
        {
            return Clasname[ClasGPA.IndexOf(ClasGPA.Min())];
        }
    }
}
