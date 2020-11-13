using System.Collections.Generic;
using TechDM.Shared.Enums;

namespace TechDM.Shared.Model
{
    public static class SeedData
    {
        public static IEnumerable<Question> Questions { get; set; }
        public static IEnumerable<UserAnswer> UserAnswers { get; set; }
        public static IEnumerable<Technology> TechnologyData { get; set; }

        static SeedData()
        {
            
            Questions = new List<Question>
            {
                //START ID: 0
                new Question
                {
                    Id = 0,
                    QuestionText = "Welcome!",
                    QuestionType = QuestionType.start,
                    QuestionHelpText = "This decision model will help you find the right technologies for you IT-Startup. " +
                                       "You will prompted up to 15 questions about your Startups, your experience and your individual requirements. " +
                                       "The results are based on scientific research, a survey with 42 Startups and several IT-Expert Interviews.",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer
                        {
                            
                        }
                    }
                },
                new Question
                {
                    Id = 1,
                    QuestionText = "What kind of technologies are you looking for?",
                    QuestionType = QuestionType.checkbox,
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer
                        {
                            Id = "A1",
                            AnswerText = "Business organization"
                        },
                        new Answer.MultipleChoiceAnswer
                        {
                            Id = "A2",
                            AnswerText = "Communication & Collaboration Systems"
                        },
                        new Answer.MultipleChoiceAnswer
                        {
                            Id = "A3",
                            AnswerText = "Digital Products / Services"
                        },
                    }
                },
                new Question
                {
                    Id = 2,
                    QuestionText = "How many people will approximately work at the Startup 1 year from now?",
                    QuestionType = QuestionType.number,
                    Answers = new List<Answer>
                    {
                        new Answer.TextAnswer()
                        {
                            Id = "B1",
                            AnswerText = "Persons",
                            
                        }
                    }
                    
                },
                new Question
                {
                    Id = 3,
                    QuestionText = "How old is the Startup?",
                    QuestionType = QuestionType.number,
                    Answers = new List<Answer>
                    {
                        new Answer.TextAnswer
                        {
                            Id = "C1",
                            AnswerText = "Years",

                        }
                    }
                    
                },
                new Question
                {
                    Id = 4,
                    QuestionText = "Order the following points after importance for your Startup.",
                    QuestionType = QuestionType.number,
                    QuestionHelpText = "1 = high 5 = low",
                    Answers = new List<Answer>
                    {
                        new Answer.TextAnswer
                        {
                            Id = "D1",
                            AnswerText = "low cost",

                        },
                        new Answer.TextAnswer
                        {
                            Id = "D2",
                            AnswerText = "flexibility",
                        },
                        new Answer.TextAnswer
                        {
                            Id = "D3",
                            AnswerText = "simplicity",
                        },
                        new Answer.TextAnswer
                        {
                            Id = "D4",
                            AnswerText = "performance",
                        },
                        new Answer.TextAnswer
                        {
                            Id = "D5",
                            AnswerText = "scalability",
                        }
                    }
                    
                },
                new Question
                {
                    Id = 5,
                    QuestionText = "For what tasks do you need business organization Software?",
                    QuestionType = QuestionType.checkbox,
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "E1",
                            AnswerText = "project management",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "E2",
                            AnswerText = "enterprise resource planning",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "E3",
                            AnswerText = "customer relationship management",
                        },
                        
                    }
                },
                new Question
                {
                    Id = 6,
                    QuestionText = "Tick all software that you and your team have experience in",
                    QuestionType = QuestionType.enumeration,
                    QuestionHelpText = "You can skip this - it hat no negative affect on the results",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F1",
                            AnswerText = "MS Office",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F2",
                            AnswerText = "Google Suit",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F3",
                            AnswerText = "Slack",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F4",
                            AnswerText = "Zoom",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F5",
                            AnswerText = "Asana",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F6",
                            AnswerText = "Trello",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F7",
                            AnswerText = "Salesforce",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F8",
                            AnswerText = "HubSpot",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F9",
                            AnswerText = "Pipedrive",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F10",
                            AnswerText = "Highrise",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F11",
                            AnswerText = "Jira",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F12",
                            AnswerText = "Confluence",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F13",
                            AnswerText = "GitLab",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F14",
                            AnswerText = "SAP",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F15",
                            AnswerText = "Oracel",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F16",
                            AnswerText = "AWS",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "F17",
                            AnswerText = "Google Cloud",
                        },
                    }
                },
                new Question
                {
                    Id = 7,
                    QuestionText = "What kind of tech product should be developed?",
                    QuestionType = QuestionType.checkbox,
                    QuestionHelpText = "More detailed questions regarding the chosen technologies will follow",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "G1",
                            AnswerText = "Website / WebApp",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "G2",
                            AnswerText = "Mobile App",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "G3",
                            AnswerText = "Desktop App",
                        },
                    }
                },
                new Question
                {
                    Id = 8,
                    QuestionText = "Who will develop the Software?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "Will you develop the software or will a another company do it for you?",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "H1",
                            AnswerText = "people from the Startup",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "H2",
                            AnswerText = "external service providers",
                        },
                    }
                },
                new Question
                {
                    Id = 9,
                    QuestionText = "Which programming languages are mastered by the programmers?",
                    QuestionType = QuestionType.enumeration,
                    QuestionHelpText = "This question aims to see if there is any previous experience with one or more programming languages",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I1",
                            AnswerText = "Python",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I2",
                            AnswerText = "Java",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I3",
                            AnswerText = "C#",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I4",
                            AnswerText = "C",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I5",
                            AnswerText = "C++",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I6",
                            AnswerText = "Go",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I7",
                            AnswerText = "TypeScript",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I8",
                            AnswerText = "HTML",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I9",
                            AnswerText = "CSS",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I10",
                            AnswerText = "Javascript",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I11",
                            AnswerText = "PHP",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I12",
                            AnswerText = "Rails",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I13",
                            AnswerText = "Swift",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I14",
                            AnswerText = "Kotlin",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "I15",
                            AnswerText = "Dart",
                        }
                    }
                },
                new Question
                {
                    Id = 10,
                    QuestionText = "What type of website do you need?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "J1",
                            AnswerText = "mainly informative",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "J2",
                            AnswerText = "highly interactive (SaaS / WebApp)",
                        },
                    }
                },
                new Question
                {
                    Id = 11,
                    QuestionText = "What platforms should be addressed with the desktop App?",
                    QuestionType = QuestionType.checkbox,
                    QuestionHelpText = "",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "L1",
                            AnswerText = "Windows",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "L2",
                            AnswerText = "Apple Os",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "L3",
                            AnswerText = "Linux",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "L4",
                            AnswerText = "further plattforms",
                        },
                    }
                },
                new Question
                {
                    Id = 12,
                    QuestionText = "What purpose does the Mobile App has?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "M1",
                            AnswerText = "mainly informative",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "M2",
                            AnswerText = "highly interactive (Game, Tool)",
                        },
                    }
                },
                new Question
                {
                    Id = 13,
                    QuestionText = "What components should the Website have?",
                    QuestionType = QuestionType.checkbox,
                    QuestionHelpText = "",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "N1",
                            AnswerText = "shop-system",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "N2",
                            AnswerText = "userlogin & accounts",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "N3",
                            AnswerText = "Contend Management",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "N4",
                            AnswerText = "individual software (own SaaS, etc.)",
                        },
                        
                    }
                },
                new Question
                {
                    Id = 14,
                    QuestionText = "What kind of Data will be stored?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "Structured data is highly-organized and formatted in a way so it's easily searchable in relational databases. Unstructured data has no pre-defined format or organization, making it much more difficult to collect, process, and analyze.",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "O1",
                            AnswerText = "mainly structured data",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "O2",
                            AnswerText = "mainly unstructured data",
                        },
                        
                    }
                },
                new Question
                {
                    Id = 15,
                    QuestionText = "What is more important for the Mobile App?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "It determines whether a cross-platform or a native approach is best for you",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "P1",
                            AnswerText = "fast, cost & development effective",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "P2",
                            AnswerText = "high performance & all mobile hardware features",
                        },
                        
                    }
                },
                new Question
                {
                    Id = 16,
                    QuestionText = "What is more important for the Mobile App?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "It determines whether a cross-platform or a native approach is best for you",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "Q1",
                            AnswerText = "fast, cost & development effective",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "Q2",
                            AnswerText = "high performance & mobile hardware features",
                        },
                        
                    }
                },
                //END, ID:17
                new Question
                {
                    Id = 17,
                    QuestionText = "Done. You answered all necessary Questions!",
                    QuestionType = QuestionType.end,
                    QuestionHelpText = "It determines whether a cross-platform or a native approach is best for you",
                    Answers = new List<Answer>
                    {
                        new Answer.TextAnswer()
                        {
                            Id = "P1",
                            AnswerText = "Do you have any Feedback?",
                        }

                    }
                },
                
            };
            
            
            
            UserAnswers = new List<UserAnswer>
            {
                new UserAnswer
                {
                    //Welche Programmiersprache kannst du?
                    Answers = new List<UserAnswer.Answer>
                    {
                        new UserAnswer.Answer
                        {
                            //c#
                            AnswerId = "a1"
                        },
                        new UserAnswer.Answer
                        {
                            //java
                            AnswerId = "a3"
                        }
                    }
                },
                new UserAnswer
                {
                    //Wie groß ist das Team
                    Answers = new List<UserAnswer.Answer>
                    {
                        new UserAnswer.Answer
                        {
                            Value = "3"
                        }
                    }
                },
            };
            
            
            
            TechnologyData = new List<Technology>
            {
                new Technology
                {
                    Name = "SAP Business One",
                    SubHeader = "ERP System",
                    Description = "Gain greater control over your company with small business management software and ERP tools designed to grow with you.",
                    Category = Category.BusinessManagement,
                    LogoUrl = "/img/technologies/SAP.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.performance,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a ERP System
                        new Condition
                        {
                            QuestionId = 5,
                            Weight = 0.6,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "E1",
                                },
                            }
                        },
                        //min 20 employees
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = 0.29,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 15,
                                }
                            }
                        },
                        //min 2 years old
                        new Condition
                        {
                            QuestionId = 3,
                            Weight = 0.11,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "C1",
                                    Min = 2,
                                },
                            }
                        }
                    }    
                },
                
                new Technology
                {
                    Name = "Jira",
                    SubHeader = "Project Management System",
                    Description = "Jira Software is the best project management tool for agile teams. Especially for software development. ",
                    Category = Category.BusinessManagement,
                    LogoUrl = "/img/technologies/Jira.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.simplicity,Attribute.flexibility,Attribute.scalability,Attribute.lowCost,
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a PMS System
                        new Condition
                        {
                            QuestionId = 5,
                            Weight = 0.75,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "E2",
                                },
                            }
                        },
                        //And develops Software
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H1",
                                }
                            }
                        },
                    }
                },
                new Technology
                {
                    Name = "Asana",
                    SubHeader = "Project Management System",
                    Description = "From the small stuff to the big picture, Asana organizes work so teams are clear what to do, why it matters, and how to get it done.",
                    Category = Category.BusinessManagement,
                    LogoUrl = "/img/technologies/asana.png",
                    Attributes = new List<Attribute>
                    {
                       Attribute.flexibility,Attribute.performance,Attribute.simplicity,Attribute.scalability, Attribute.lowCost
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a PMS System
                        new Condition
                        {
                            QuestionId = 5,
                            Weight = 0.59,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "E2",
                                },
                            }
                        },
                        //And develops Software
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.18,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H1",
                                }
                            }
                        },
                        //experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.23,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F5"
                                }
                            }
                        },
                    }
                },
                
                new Technology
                {
                    Name = "Salesforce",
                    SubHeader = "Customer Relationship Management",
                    Description = "Salesforce is one integrated CRM platform that gives all your departments — including marketing, sales, commerce, and service — a single, shared view of every customer.",
                    Category = Category.BusinessManagement,
                    LogoUrl = "/img/technologies/Salesforce.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.scalability,Attribute.flexibility,Attribute.performance,Attribute.simplicity,Attribute.lowCost
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a CRM System
                        new Condition
                        {
                            QuestionId = 5,
                            Weight = 0.59,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "E3",
                                },
                            }
                        },
                        //medium size Team
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = 0.18,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 5,
                                }
                            }
                        },
                        //experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.23,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F7"
                                }
                            }
                        },
                    }
                },
                new Technology
                {
                    Name = "HubSpot",
                    SubHeader = "Customer Relationship Management",
                    Description = "HubSpot offers a full platform of marketing, sales, customer service, and CRM software — plus the methodology, resources, and support — to help businesses grow better.",
                    Category = Category.BusinessManagement,
                    LogoUrl = "/img/technologies/hubspot.jpg",
                    Attributes = new List<Attribute>
                    {
                        Attribute.simplicity, Attribute.scalability,Attribute.lowCost, Attribute.flexibility,Attribute.performance,
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a CRM System
                        new Condition
                        {
                            QuestionId = 5,
                            Weight = 0.59,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "E3",
                                },
                            }
                        },
                        //small & medium size Team
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = 0.18,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 5,
                                    Max = 40,
                                }
                            }
                        },
                        //experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.23,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F8"
                                }
                            }
                        },
                    }
                },
                

                new Technology
                {
                    Name = "MS Office",
                    SubHeader = "Collaboration Software",
                    Description = "Collaborate for free with online versions of Microsoft Word, PowerPoint, Excel, and OneNote. Save documents, spreadsheets, and presentations online!",
                    Category = Category.CommunicationCollaboration,
                    LogoUrl = "/img/technologies/office365.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.flexibility,Attribute.performance,Attribute.simplicity,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.92,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F1",
                                },
                            }
                        },
                    }
                },
                
                new Technology
                {
                    Name = "Google Workspace",
                    SubHeader = "Collaboration Software",
                    Description = "An integrated suite of secure, cloud-native collaboration and productivity apps powered by Google AI. Includes Gmail, Docs, Drive, Calendar, Meet and more.",
                    Category = Category.CommunicationCollaboration,
                    LogoUrl = "/img/technologies/googleWorkspace.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.flexibility,Attribute.performance,Attribute.simplicity,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.83,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F2",
                                },
                            }
                        },
                        //Team size (negative)
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = -0.24,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 30
                                },
                            }
                        },
                    }
                },
                
                new Technology
                {
                    Name = "Google Workspace",
                    SubHeader = "Collaboration Software",
                    Description = "An integrated suite of secure, cloud-native collaboration and productivity apps powered by Google AI. Includes Gmail, Docs, Drive, Calendar, Meet and more.",
                    Category = Category.CommunicationCollaboration,
                    LogoUrl = "/img/technologies/googleWorkspace.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.flexibility,Attribute.performance,Attribute.simplicity,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.83,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F2",
                                },
                            }
                        },
                        //Team size (negative)
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = -0.24,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 30
                                },
                            }
                        },
                    }
                },
                


                new Technology
                {
                    Name = "Blazor",
                    Description = "Web Framework <br/> by Microsoft",
                    Category = Category.ItProduct,
                    Language = "C#",
                    LogoUrl = "/img/technologies/Blazor.png",
                    Conditions = new List<Condition>
                    {
                        new Condition
                        {
                            QuestionId = 0,
                            RequiredAnswers = new List<Condition.QuestionAnswer>
                            {
                                new Condition.QuestionAnswer()
                                {
                                    Min = 2,
                                    Max = 5
                                }
                            }
                        }
                    }
                }
            };
        }
        
        
    }
}