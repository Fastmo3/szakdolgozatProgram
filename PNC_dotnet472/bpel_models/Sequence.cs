using System.Collections.Generic;

namespace PNC_dotnet472.bpel_models
{
    public class Sequence
    {
        public string name { get; set; }

        public List<BpelElement> bpelElements { get; set; }

        public Sequence(string naem, List<BpelElement> inputlist)
        {
            name = naem;
            bpelElements = inputlist;
        }

    }
}