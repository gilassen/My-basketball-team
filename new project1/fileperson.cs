using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace new_project1
{
    public class fileperson
    {
        public static void SavepersonToFile(BindingList<Person> personl)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("personlist.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, personl);
                binaryFile.Flush();
            }
        }

        public static BindingList<Person> LoadpersonFromFile()
        {
            BindingList<Person> personl;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("personlist.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    personl = (BindingList<Person>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                personl = new BindingList<Person>();
            }
            return personl;
        }
    }
}
