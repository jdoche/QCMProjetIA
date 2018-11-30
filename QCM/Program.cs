using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace QCM
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {                     
        
            //Toutes les questions/réponses sont mises dans qcm = liste d'objets Question
                                 
           
            StreamReader reader = new StreamReader("../../question.xml");
            Questionnaire questions = (Questionnaire)new XmlSerializer(typeof(Questionnaire)).Deserialize(reader);
            reader.Close();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(questions));
            

        }
    }
}
