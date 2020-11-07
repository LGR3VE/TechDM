using System.Collections.Generic;

namespace Meh
{
    public class Technology
    {
        public string Name { get; set; }
        public double value { get; set; }
        public List<Condition> Conditions { get; set; }
    }
}