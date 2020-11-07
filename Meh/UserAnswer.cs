using System.Collections.Generic;

namespace Meh
{
    public class UserAnswer
    {
        public string QuestionId { get; set; }
        public List<QuestionAnswer> Answers { get; set; }

        public class QuestionAnswer
        {
            
        }

        public class RangeAnswer : QuestionAnswer
        {
            public int value { get; set; }
        }

        public class MultipleChoiseAnswer : QuestionAnswer
        {
            public string AnswerId { get; set; }
        }
        
    }
}