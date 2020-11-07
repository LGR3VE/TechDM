using System.Collections.Generic;
using System.Linq;

namespace TechDM.Shared
{
    public class DecisionModel
    {
        public IEnumerable<Question> Answers { get; set; }


        public DecisionModel()
        {
            
        }
        
        
        public void AddAnswerToModel(Question q)
        {
            Answers = Answers.Append(q);

        }

    }
    
    
}