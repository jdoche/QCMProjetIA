using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            //stocker tout le monde dans une liste
            //selectionner 20 question, selection de 20 fois une question
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            StreamReader monStreamReader = new StreamReader(@"Question.xml", encoding);
            string ligne = monStreamReader.ReadLine();
            int nombreLigne = int.Parse(ligne);//la première ligne du document texte comporte uniquement le nombre de question écrites

            List<Question> listeQuestion;

            for (int i = 0; i < nombreLigne; i++)
            {
                ligne = monStreamReader.ReadLine();
                string[] intermediaire = ligne.Split(';'); //le caractère séparateur entre chaque information  est ";"

                Q Question = new Question();//
                Q = Question();
              
            }

            monStreamReader.Close();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
