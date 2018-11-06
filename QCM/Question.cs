using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCM
{
    class Question
    {
        protected string intitule;
        protected List<string> listeReponse;
        protected List<string> bonneReponse;
        // création d'une question
        Question()
        { }

        Question(string[] texte)
        { intitule=texte[0];
            
           
            for(int i=1;i<=texte.Length; i++ )
            {
                if(i<5)
                {
                    listeReponse.Add(texte[i]);
                }
                else
                {
                    bonneReponse.Add(texte[i]);
                }

            }
        }


    }
}
