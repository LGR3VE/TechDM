using System;
using System.Collections.Generic;
using System.Linq;
using TechDM.Shared;
using TechDM.Shared.Enums;
using TechDM.Shared.Model;
using Attribute = TechDM.Shared.Model.Attribute;

namespace TestModel
{
    class Program
    {
        static void Main(string[] args)
        {

            var technologies = SeedData.TechnologyData;

            var techteil = SeedData.TechnologyData.Where(t => t.Name.Equals("Blazor"));


            var results= DecisionModel.CalculateScores(SeedData.UserAnswers, SeedData.TechnologyData);

            var orderresult = technologies.OrderByDescending(t => results.First(ts => ts.TechnologyId.Equals(t.Id)).Score);

            foreach (var technology in orderresult)
            {
                Console.Out.WriteLine(technology.Name + ": " + results.First(ts => ts.TechnologyId.Equals(technology.Id)).Score + " Score");
            }
            

        }
    }
}