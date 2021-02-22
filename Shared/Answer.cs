using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechDM.Shared
{
    public class Answer
    {
        public string Id { get; set; }
        public string AnswerText { get; set; }
        public string AnswerDescription { get; set; }
        public bool Selected { get; set; }
        public string TempValue { get; set; }


        public Answer()
        {
            Id = Guid.NewGuid().ToString();
        }
        

        public class MultipleChoiceAnswer : Answer
        {
            
            public string AnswerPlaceholder { get; set; }
            
        }

        public class TextAnswer : Answer
        {
            
            public string AnswerPlaceholder { get; set; }
            
        }

        public class RangeAnswer : Answer
        {
            public double min { get; set; }
            public double max { get; set; }
        }
    }
    
}