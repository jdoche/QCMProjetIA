using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QCM
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("Questionnaire")]
    public class Questionnaire
    {
        [XmlArray("Questions")]
        [XmlArrayItem("Question", typeof(Question))]
        public  List<Question> Questions { get; set; }       

    }
    

}
