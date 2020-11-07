using System;
using System.Collections.Generic;
using TechDM.Shared.Enums;

namespace TechDM.Shared
{
    public class Question
    {
        public string Id { get; set; }
        public string QuestionText { get; set; }

        public QuestionType QuestionType { get; set; }
        
        public IEnumerable<QuestionAnswer> Answers { get; set; }

        public double Weight { get; set; }

        public Question()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
    
}