using System;
using System.Collections.Generic;

namespace Meh
{
    public class Condition
    {
        public string QuestionId { get; set; }
        public List<QuestionAnswer> RequiredAnswers { get; set; }
        public double Weight { get; set; }


        public class QuestionAnswer
        {
            public double Weight { get; set; }

        }
        
        public class RangeAnswer : QuestionAnswer
        {
            public int Min { get; set; }
            public int Max { get; set; }
        }
        
        public class MultipleChoiseAnswer : QuestionAnswer
        {
            public string AnswerId { get; set; }
        }
        
    }
}