using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project1
{
    public class listmanager
    {
        private static BindingList<Person> personl;
        static listmanager()
        {
            personl = fileperson.LoadpersonFromFile();
        }

        public static void saveperson(object sender, FormClosingEventArgs e)
        {
            fileperson.SavepersonToFile(personl);
        }

        public static BindingList<Person> Getperson()
        {
            return personl;
        }

        public static void Addperson(Person person)
        {
            personl.Add(person);
        }
        public static int findperson(float id)
        {
            for (int i = 0; i < personl.Count; i++)
            {
                if(personl[i].id == id)
                    return 1;
            }
            return 0;
        }

        public static int findperson1(string id)
        {
            int len = id.Length;
            if (len != 9)
                return 1;
            for (int i = 0; i < len; i++)
            {
                if (id[i] < '0' || id[i] > '9')
                    return 1;
            }
            return 0;
        }

        public static void deleteperson(int row)
        {
            personl.RemoveAt(row);
        }

        public static BindingList<T> Getspecificperson<T>() where T : Person
        {
            BindingList<T> specificperson = new BindingList<T>();
            foreach (Person person in personl)
            {
                if (person is T)
                {
                    specificperson.Add(person as T);
                }
            }
            return specificperson;
        }
    }
}
