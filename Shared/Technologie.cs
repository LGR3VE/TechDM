using System;
using System.Collections.Generic;
using TechDM.Shared.Enums;

namespace TechDM.Shared
{
    public class Technologie
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public Category Category { get; set; }




        public Technologie()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}