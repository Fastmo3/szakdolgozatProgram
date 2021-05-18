using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PNC_dotnet472.petri_models
{
    public class PetriTransition:PetriElement
    {
        [XmlArray]
        [XmlArrayItem(ElementName ="color")]
        public List<string> AcceptedColors { get; set; }

        [XmlArray]
        [XmlArrayItem(ElementName ="color")]
        public List<string> GeneratedColors { get; set; }

        public enum TransitionMode
        {
            [XmlEnum(Name ="or")]
            OR,
            [XmlEnum(Name = "and")]
            AND
        }
        
        public TransitionMode ActualTransition { get; set; }

        public PetriTransition()
        {

        }
    }
}
