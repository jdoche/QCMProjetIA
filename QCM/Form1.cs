using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ../../question.xml
namespace QCM
{
    public partial class Form1 : Form
    {
        public Questionnaire Questionnaire { get; set; }
        private Random r = new Random();
        private string reponseUtilisateur = "";
        private int indice { get; set; }
    
        public Form1(Questionnaire questionnaire)
        {
            
            this.Questionnaire = questionnaire; 
            InitializeComponent();
            pbOk.Hide();
            AfficheEnonce();            
        }
     
        public void AfficheEnonce()
        {
            // on tire au hasard une question dans questionnaire 
            indice = r.Next(0, (Questionnaire.Questions.Count()));
            tbQuestion.Text = Questionnaire.Questions[indice].Enonce;
            cbA.Text = Questionnaire.Questions[indice].ReponseA;
            cbB.Text = Questionnaire.Questions[indice].ReponseB;
            cbC.Text = Questionnaire.Questions[indice].ReponseC;
            cbD.Text = Questionnaire.Questions[indice].ReponseD;         

        }
        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbA.Checked)
                reponseUtilisateur += "A";
            pbOk.Show();
        }

        private void cbB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbB.Checked)
             reponseUtilisateur += "B";
                
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {
            reponseUtilisateur = "C";
        }
        private void cbD_CheckedChanged(object sender, EventArgs e)
        {
            reponseUtilisateur = "D";
        }

        private void bValider_Click(object sender, EventArgs e)
            
        {


            if (reponseUtilisateur == Convert.ToString(Questionnaire.Questions[indice].BonneReponse))
            {
                MessageBoxIcons=
                MessageBox.Show("Bien joué !", "Application", MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }
            else
                MessageBox.Show("Mauvaise réponse !", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
    }
}
