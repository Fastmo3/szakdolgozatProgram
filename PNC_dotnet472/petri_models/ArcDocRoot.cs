using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PNC_dotnet472.petri_models
{
    [XmlRoot(ElementName ="arcs")]
    public class ArcDocRoot
    {
        [XmlArray]
        [XmlArrayItem(ElementName = "arc")]
        public List<PetriArc> arcs { get; set; }

        public ArcDocRoot()
        {

        }
    }
}
