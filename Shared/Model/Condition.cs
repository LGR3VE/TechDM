using System.Collections.Generic;
using TechDM.Shared.Enums;

namespace TechDM.Shared.Model
{
    public class Condition
    {
        public int QuestionId { get; set; }
        
        public QuestionType Type { get; set; }
        public List<QuestionAnswer> RequiredAnswers { get; set; }
        public double Weight { get; set; }


        public class QuestionAnswer : UserAnswer.Answer
        {
            public double Weight { get; set; }
            
            public int Min { get; set; }
            public int Max { get; set; }

            public QuestionAnswer()
            {
                Weight = 1;
            }

        }

    }
    
}