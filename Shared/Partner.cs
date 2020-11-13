using System;

namespace TechDM.Shared
{
    public class Partner
    {
        
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Logo { get; set; }
        
        public string Website { get; set; }

        public Partner()
        {
            Id = Guid.NewGuid().ToString();
        }


    }
}