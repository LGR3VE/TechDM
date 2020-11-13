using System;
using System.Collections.Generic;
using TechDM.Shared.Enums;

namespace TechDM.Shared
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }

        public string QuestionHelpText { get; set; }
        public QuestionType QuestionType { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
    
}