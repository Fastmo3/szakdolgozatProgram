using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNC_dotnet472.bpel_models
{
    public class BpelElement
    {
       public Dictionary<string,string> attributes { get; set; }
        public List<BpelElement> ownBpelElements{ get; set; }

        public BpelElement()
        {

        }
    }
}
