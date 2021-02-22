using System;
using System.Collections.Generic;

namespace TechDM.Shared
{
    public class UserQuestionAnswer
    {
        
        public string Id { get; set; }
        
        public int QuestionId { get; set; }
        public IEnumerable<Answer> Answers { get; set; }

        public UserQuestionAnswer()
        {
            Id = Guid.NewGuid().ToString();
        }

        public class Answer 
        {
            public string AnswerId { get; set; }
            public string Value { get; set; }
        }

    }
}