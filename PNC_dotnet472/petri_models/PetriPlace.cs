using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PNC_dotnet472.petri_models
{
    public class PetriPlace : PetriElement
    {
        [XmlArray]
        [XmlArrayItem(ElementName ="color")]
        public List<string> acceptedColors { get; set; }

        [XmlArray]
        [XmlArrayItem(ElementName = "color")]
        public List<string> tokenList { get; set; }

        public PetriPlace()
        {

        }
    }
}
