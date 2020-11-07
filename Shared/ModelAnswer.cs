using System;
using System.Collections.Generic;

namespace TechDM.Shared
{
    public class ModelAnswer
    {
        public string Id { get; set; }
        
        public DateTime DateTime { get; set; }
        
        public IEnumerable<Question> Answers { get; set; }


        
        public ModelAnswer()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}