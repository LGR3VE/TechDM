using System;
using System.Collections.Generic;
using System.Linq;

namespace TechDM.Shared.Model
{
    public static class DecisionModel
    {
        public static IEnumerable<Question> Answers { get; set; }
        
        
        /// <summary>
        /// Calculates the Score based on the unserAnswers and technologies
        /// </summary>
        /// <param name="userAnswers">Answers given by the user</param>
        /// <param name="technologies">Technologies that are implemented in the model</param>
        /// <returns>List of a score object for each technology</returns>
        public static IEnumerable<TechnologyScore> CalculateScores(IEnumerable<UserQuestionAnswer> userAnswers, IEnumerable<Technology> technologies)
        {
            var technologieScoreList = new List<TechnologyScore>();

            //set the users priorities to an unsorted list
            var userAttributePriorities = new List<Attribute>();
            var userAttributeAnswers = userAnswers.FirstOrDefault(ua => ua.QuestionId == 3)?.Answers.ToList();
            
            if (userAttributeAnswers != null)
            {
                //order priorities
                userAttributeAnswers = userAttributeAnswers.OrderBy(a => int.Parse(a.Value)).ToList();

                foreach (var answer in userAttributeAnswers)
                {
                    //answer.Value = Rank
                    switch (answer.AnswerId)
                    {
                        case "C1":
                            userAttributePriorities.Add(Attribute.lowCost);
                            break;
                        case "C2":
                            userAttributePriorities.Add(Attribute.flexibility);
                            break;
                        case "C3":
                            userAttributePriorities.Add(Attribute.simplicity);
                            break;
                        case "C4":
                            userAttributePriorities.Add(Attribute.performance);
                            break;
                        case "C5":
                            userAttributePriorities.Add(Attribute.scalability);
                            break;
                    }
                }
            }

            //calculate score for every technologie
            foreach (var technology in technologies)
            {
                
                //Calculate Ratio reached Points / max Points
                double maxPoints = 0;
                double reachedPoints = 0;
                var technologyScore = new TechnologyScore {TechnologyId = technology.Id};
                
                //
                // 1/2 Check Attributes
                //

                // get the optimal priorities
                var optimalAttributePriorities = technology.Attributes;
                


                //add points for each attribute
                for (int i = 0; i < optimalAttributePriorities.Count; i++)
                {
                    var answerIndex = userAttributePriorities.FindIndex(a => a.Equals(optimalAttributePriorities[i]));
                    var difference = Math.Abs(i - answerIndex);
                    switch (difference)
                    {
                        case 0:
                            reachedPoints += 20;
                            break;
                        case 1:
                            reachedPoints += 15;
                            break;
                        case 2:
                            reachedPoints += 10;
                            break;
                        case 3:
                            reachedPoints += 5;
                            break;
                        case 4:
                            reachedPoints += 0;
                            break;
                        default:
                            reachedPoints += 0;
                            break;
                    }

                    maxPoints += 20;

                }
                technologyScore.Score += reachedPoints * 0.2;
                //reset Points
                reachedPoints = 0;
                maxPoints = 0;


                //
                // 2/2 Check Conditions
                // 
                foreach (var condition in technology.Conditions)
                {
                    //filter only answers that are answered
                    var answers = userAnswers.FirstOrDefault(ua => ua.QuestionId == condition.QuestionId)?.Answers;

                    if (answers != null)
                    {
                        foreach (var questionAnswer in answers)
                        {

                            //Radio/Checkbox Answer
                            foreach (var requiredAnswer in condition.RequiredAnswers)
                            {
                                //if required Answer is checked
                                if (questionAnswer.AnswerId == requiredAnswer.AnswerId)
                                {
                                    //max 100P for each correct Answer
                                    reachedPoints += (100d/condition.RequiredAnswers.Count) * condition.Weight * requiredAnswer.Weight ?? 1d;
                                }

                                maxPoints += 100d/condition.RequiredAnswers.Count;
                            }
                            
                            
                            //Value Answer
                            foreach (var requiredAnswer in condition.RequiredAnswers)
                            {
                                //convert string answer in int
                                var result = int.TryParse(questionAnswer.Value, out var intValue);

                                if (result)
                                {
                                    //if Min and Max boundaries are set
                                    if (requiredAnswer.Min != 0 &&
                                        requiredAnswer.Max != 0 && 
                                        intValue >= requiredAnswer.Min && 
                                        intValue <= requiredAnswer.Max)
                                    {
                                        //max 100P for each Answer between the boundaries
                                        reachedPoints += (100d/condition.RequiredAnswers.Count) * condition.Weight * requiredAnswer.Weight ?? 1d;
                                    }
                                                                    
                                    //if only Min boundary is set
                                    else if (requiredAnswer.Max == 0 && 
                                             intValue >= requiredAnswer.Min)
                                    {
                                        //max 100P for each Answer between the boundaries
                                        reachedPoints += (100d/condition.RequiredAnswers.Count) * condition.Weight * requiredAnswer.Weight ?? 1d;
                                    }
                                                                    
                                    //if only Max boundary is set
                                    else if (requiredAnswer.Min == 0 && 
                                             intValue <= requiredAnswer.Max)
                                    {
                                        //max 100P for each Answer between the boundaries
                                        reachedPoints += (100d/condition.RequiredAnswers.Count) * condition.Weight * requiredAnswer.Weight ?? 1d;
                                    }
                                    
                                    
                                    maxPoints += 100d/condition.RequiredAnswers.Count;
                                }
                                
                            }
                            
                        }
                        
                        //Check if more than 100 and less than 0
                        if (reachedPoints > 100)
                        {
                            reachedPoints = 100;
                        }else if(reachedPoints < 0)
                        {
                            reachedPoints = 0;
                        }
                        
                        //Add to TechScore
                        technologyScore.Score += reachedPoints * 0.8;
                        //reset Points
                        reachedPoints = 0;
                        maxPoints = 0;
                        
                        
                    }
                    else
                    {
                        maxPoints += 100d;
                    }
                }
                
                //round the Score
                technologyScore.Score = Math.Round(technologyScore.Score,2);
                
                technologieScoreList.Add(technologyScore);
                
                
            }

            return technologieScoreList;
        }

    }
    
}