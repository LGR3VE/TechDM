using System;
using System.Collections.Generic;
using System.Linq;

namespace TechDM.Shared.Model
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

        public IEnumerable<Technology> SolveModel(IEnumerable<UserAnswer> userAnswers, IEnumerable<Technology> technologies)
        {
            userAnswers = SeedData.UserAnswers;
            technologies = SeedData.TechnologyData;
            
            var scores = CalculateScores(userAnswers, technologies);
            
            
            return new List<Technology>();
        
        }

        public IEnumerable<TechnologyScore> CalculateScores(IEnumerable<UserAnswer> userAnswers, IEnumerable<Technology> technologies)
        {
            foreach (var technology in technologies)
            {
                //Calculate Ratio reached Points / max Points
                double maxPoints = 0;
                double reachedPoints = 0;
                
                foreach (var condition in technology.Conditions)
                {
                    var answers = userAnswers.FirstOrDefault(ua => ua.QuestionId == condition.QuestionId)?.Answers;
                    
                    if (answers != null)
                    {
                        foreach (var questionAnswer in answers)
                        {
                            // switch (questionAnswer)
                            // {
                            //     case UserAnswer.MultipleChoiceAnswer multipleChoiceAnswer:
                            //         
                            //         foreach (var requiredAnswer in condition.RequiredAnswers.OfType<Condition.MultipleChoiceAnswer>())
                            //         {
                            //             //if required Answer is checked
                            //             if (multipleChoiceAnswer.AnswerId == requiredAnswer.AnswerId)
                            //             {
                            //                 //max 100P for each correct Answer
                            //                 reachedPoints += requiredAnswer.Weight * 100d;
                            //             }
                            //
                            //             maxPoints += 100d;
                            //         }
                            //         break;
                            //
                            //     case UserAnswer.RangeAnswer rangeAnswer:
                            //         
                            //         foreach (var requiredAnswer in condition.RequiredAnswers.OfType<Condition.RangeAnswer>())
                            //         {
                            //             if (rangeAnswer.Value >= requiredAnswer.Min && rangeAnswer.Value <= requiredAnswer.Max)
                            //             {
                            //                 //max 100P for each correct Answer
                            //                 reachedPoints += requiredAnswer.Weight * 100d;
                            //             }
                            //             //Points for closest answer?
                            //             maxPoints += 100d;
                            //         }
                            //         
                            //         break;
                            //
                            //     case UserAnswer.TextAnswer textAnswer:
                            //         
                            //         foreach (var requiredAnswer in condition.RequiredAnswers.OfType<Condition.TextAnswer>())
                            //         {
                            //             if (textAnswer.Value == requiredAnswer.Value)
                            //             {
                            //                 //max 100P for each correct TextAnswer
                            //                 reachedPoints += requiredAnswer.Weight * 100d;
                            //                 maxPoints += 100d;
                            //             }
                            //         }
                            //         
                            //         break;
                            //
                            //     default:
                            //         throw new ArgumentOutOfRangeException(nameof(questionAnswer));
                            // }
                        }
                    
                    }
                    
                }
            }
            
            //ToDo calculate Tech Scores
            return new List<TechnologyScore>()
            {
                new TechnologyScore()
                {
                    TechnologyId = "1",
                    Score = 8
                },
                new TechnologyScore()
                {
                    TechnologyId = "2",
                    Score = 1
                },
                new TechnologyScore()
                {
                    TechnologyId = "3",
                    Score = 9.2
                },
            };
        }

    }
    
    
}