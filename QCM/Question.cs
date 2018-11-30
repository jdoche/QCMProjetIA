using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace QCM
{
    [Serializable()]
    public class Question
    {

        [System.Xml.Serialization.XmlElement("Id")]
        public int Id { get; set; }

        [System.Xml.Serialization.XmlElement("Enonce")]
        public string Enonce { get; set; }

        [System.Xml.Serialization.XmlElement("ReponseA")]
        public string ReponseA { get; set; }

        [System.Xml.Serialization.XmlElement("ReponseB")]
        public string ReponseB { get; set; }

        [System.Xml.Serialization.XmlElement("ReponseC")]
        public string ReponseC { get; set; }

        [System.Xml.Serialization.XmlElement("ReponseD")]
        public string ReponseD { get; set; }

        [System.Xml.Serialization.XmlElement("BonneReponse")]
        public string BonneReponse { get; set; }

        public Question()
        {

        }

        public override string ToString()
        {
            return Enonce;
        }
    }
}
