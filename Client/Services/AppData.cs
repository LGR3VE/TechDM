using System.Collections.Generic;
using TechDM.Shared;

namespace TechDM.Client.Services
{
    public class AppData
    {
        public List<UserQuestionAnswer> UserQuestionAnswers { get; set; }
        
        public bool DebugEnabled { get; set; }
    }
}