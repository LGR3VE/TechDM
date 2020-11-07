using System;
using System.Collections.Generic;

namespace TechDM.Shared
{
    public class QuestionAnswer
    {
        public string Id { get; set; }
        public string AnswerText { get; set; }
        public string AnswerPlaceholder { get; set; }
        public string AnswerDescription { get; set; }
        
        public bool Selected { get; set; }
        

        public QuestionAnswer()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}