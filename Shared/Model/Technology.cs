using System;
using System.Collections.Generic;
using TechDM.Shared.Enums;

namespace TechDM.Shared.Model
{
    public class Technology
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SubHeader { get; set; }
        public Category Category { get; set; }
        public List<Attribute> Attributes { get; set; }
        public String Description { get; set; }
        public String Language { get; set; }
        public String LogoUrl { get; set; }
        
        public List<Condition> Conditions { get; set; }

        public Technology()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

    public enum Attribute
    {
        lowCost,
        flexibility,
        simplicity,
        performance,
        scalability
    }
}