using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PNC_dotnet472.petri_models
{
 
    public class PetriArc :PetriElement
    {
        [XmlElement]
        public PetriElement souceElement { get; set; }

        [XmlElement]
        public PetriElement destinationElement { get; set; }

        public PetriArc(PetriElement source, PetriElement dest)
        {
            souceElement = source;
            destinationElement = dest;
        }
        public PetriArc()
        {

        }
    }
}
