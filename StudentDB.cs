using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assign_2_BS_19011519_006
{
    internal class StudentDB
    {
        private static string filename = "C:/Users/faiqa/source/repos/Assign_2_BS_19011519-006/studentdb.txt";

        public static bool checkFileExists()
        {
            if (File.Exists(filename))
            {
                return true;
            }
            return false;
        }

        public static void WriteDataToFile(List<Student> temp)
        {
            File.Delete(filename);
            FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            TextWriter textWriter = new StreamWriter(filestream);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            xmlSerializer.Serialize(textWriter, temp);

            textWriter.Close();
            filestream.Close();
        }

        public static List<Student> ReadDataFromFile()
        {
            FileStream filestream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            TextReader textReader = new StreamReader(filestream);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            List<Student> student = (List<Student>)xmlSerializer.Deserialize(textReader);

            textReader.Close();
            filestream.Close();
            return student;
        }
    }
}
