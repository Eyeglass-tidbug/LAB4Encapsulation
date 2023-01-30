using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    internal class Classroom
    {
        string name;
        List<Person> person = new List<Person>();

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
            foreach (Person p in this.person)
            {
                age += p.getage();
            }
            return age;
        }
        //avg class = all sigma[score]/ count[score] 
    }
}
