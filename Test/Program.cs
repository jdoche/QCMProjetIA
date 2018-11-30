using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QCM;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    static class Program
    {
        [STAThread]
        static void Main()
        {


            Questionnaire questions = null;
            string path = @"question.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Questionnaire));

            StreamReader reader = new StreamReader(path);
            questions = (Questionnaire)serializer.Deserialize(reader);

            //Console.Write(questions.Enonce[1]);
            reader.Close();
            Form1 form = new Form1(questions);

        }
    }
}
