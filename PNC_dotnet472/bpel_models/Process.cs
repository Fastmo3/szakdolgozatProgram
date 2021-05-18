using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNC_dotnet472.bpel_models
{
    class Process
    {
        public string name { get; set; }
        public List<Sequence> bpelSequence { get; set; }
    }
}

