using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
// ReSharper disable  PossibleNullReferenceException

namespace Meh
{
    class Program
    {
        static void Main(string[] args)
        {

            var UserAnswers = new List<UserAnswer>
            {
                new UserAnswer
                {
                    QuestionId = "1",
                    Answers = new List<UserAnswer.QuestionAnswer>
                    {
                        new UserAnswer.RangeAnswer
                        {
                            value = 50
                        },
                        new UserAnswer.MultipleChoiseAnswer
                        {
                            AnswerId = "a1"
                        }
                    }
                },
            };


            var technologies = new List<Technology>
            {
                new Technology
                {
                    Name = "Dotnet",
                    Conditions = new List<Condition>
                    {
                        new Condition
                        {
                            QuestionId = "0",
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.RangeAnswer
                                {
                                    Min = 2,
                                    Max = 5
                                }
                            }
                        },
                        new Condition
                        {
                            QuestionId = "1",
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.RangeAnswer
                                {
                                    Min = 10,
                                    Max = 20,
                                    Weight = 50
                                }
                            }
                        },
                        new Condition
                        {
                            QuestionId = "2",
                            Weight = 100,
                            RequiredAnswers = new List<Condition.QuestionAnswer>
                            {
                                new Condition.MultipleChoiseAnswer
                                {
                                    Weight = 100,
                                    AnswerId = "a1"
                                }
                            }
                        }
                    }
                }
            };


            foreach (var technology in technologies)
            {
                foreach (var condition in technology.Conditions)
                {
                    var answers = UserAnswers.FirstOrDefault(ua => ua.QuestionId == condition.QuestionId)?.Answers;
                        
                    foreach (var questionAnswer in answers)
                    {
                        switch (questionAnswer)
                        {
                            case UserAnswer.MultipleChoiseAnswer multipleChoiseAnswer:
                                    
                                
                                foreach (var requiredAnswer in condition.RequiredAnswers.OfType<Condition.MultipleChoiseAnswer>())
                                {
                                    // Add points requiredAnswer.AnswerId

                                }
                                    
                                break;
                            case UserAnswer.RangeAnswer rangeAnswer:
                                    
                                foreach (var requiredAnswer in condition.RequiredAnswers.OfType<Condition.RangeAnswer>())
                                {
                                    // Add points requiredAnswer.Min
                                }
                                    
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(questionAnswer));
                        }
                    }
                    
                }
            }
            





        }
    }
}