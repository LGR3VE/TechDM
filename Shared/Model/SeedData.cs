using System.Collections.Generic;
using TechDM.Shared.Enums;





namespace TechDM.Shared.Model
{
    public static class SeedData
    {
        public static IEnumerable<Question> Questions { get; set; }
        public static IEnumerable<UserQuestionAnswer> UserAnswers { get; set; }
        public static IEnumerable<Technology> TechnologyData { get; set; }
        
        public static IEnumerable<Partner> PartnerData { get; set; }

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
                                       "You will prompted up to 16 questions about your Startup, your experience and your individual requirements. " +
                                       "The results are based on scientific research, a survey with 42 Startups from Hamburg & Berlin, Germany and several IT-Expert Interviews." +
                                       "<br> Click <a href=\"/data/Bachelorarbeit_Lennard_Greve.pdf\" target=\"_blank\"> here</a> to view the full paper.",
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
                    QuestionText = "How old is the Startup?",
                    QuestionType = QuestionType.number,
                    Answers = new List<Answer>
                    {
                        new Answer.TextAnswer
                        {
                            Id = "A1",
                            AnswerText = "Years",
                        }
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
                    QuestionText = "Order the following points after importance for the tech of your Startup.",
                    QuestionType = QuestionType.order,
                    QuestionHelpText = "top = highest, bottom = lowest",
                    Answers = new List<Answer>
                    {
                        new Answer.TextAnswer
                        {
                            Id = "C1",
                            AnswerText = "low cost",

                        },
                        new Answer.TextAnswer
                        {
                            Id = "C2",
                            AnswerText = "flexibility",
                        },
                        new Answer.TextAnswer
                        {
                            Id = "C3",
                            AnswerText = "simplicity",
                        },
                        new Answer.TextAnswer
                        {
                            Id = "C4",
                            AnswerText = "performance",
                        },
                        new Answer.TextAnswer
                        {
                            Id = "C5",
                            AnswerText = "scalability",
                        }
                    }
                    
                },
                new Question
                {
                    Id = 4,
                    QuestionText = "What kind of technologies are you looking for?",
                    QuestionType = QuestionType.checkbox,
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer
                        {
                            Id = "D1",
                            AnswerText = "Business organization software"
                        },
                        new Answer.MultipleChoiceAnswer
                        {
                            Id = "D2",
                            AnswerText = "Communication- & Collaborationsystems"
                        },
                        new Answer.MultipleChoiceAnswer
                        {
                            Id = "D3",
                            AnswerText = "Digital Products / Services"
                        },
                    }
                },
                new Question
                {
                    Id = 5,
                    QuestionText = "For what tasks do you need business organization software?",
                    QuestionType = QuestionType.checkbox,
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "E1",
                            AnswerText = "enterprise resource planning (ERP)",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "E2",
                            AnswerText = "project management (PM)",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "E3",
                            AnswerText = "customer relationship management (CRM)",
                        },
                        
                    }
                },
                new Question
                {
                    Id = 6,
                    QuestionText = "Tick all software that you and the team have experience in.",
                    QuestionType = QuestionType.enumeration,
                    QuestionHelpText = "You can skip this - it has no negative affect on the results",
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
                    QuestionText = "Who will develop the software?",
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
                    QuestionText = "What components should the website have?",
                    QuestionType = QuestionType.checkbox,
                    QuestionHelpText = "",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "N1",
                            AnswerText = "Shop-System",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "N2",
                            AnswerText = "User login & Accounts",
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
                    Id = 12,
                    QuestionText = "What kind of data will be stored?",
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
                    Id = 13,
                    QuestionText = "What platforms will be addressed with the desktop App?",
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
                            AnswerText = "AppleOs",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "L3",
                            AnswerText = "Linux",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "L4",
                            AnswerText = "further platforms",
                        },
                    }
                },
                new Question
                {
                    Id = 14,
                    QuestionText = "What purpose does the mobile app has?",
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
                    QuestionText = "Should the app and the website display similar contend?",
                    QuestionType = QuestionType.radio,
                    QuestionHelpText = "It determines web based cross-platform or a native approach is best for you",
                    Answers = new List<Answer>
                    {
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "Q1",
                            AnswerText = "Yes",
                        },
                        new Answer.MultipleChoiceAnswer()
                        {
                            Id = "Q2",
                            AnswerText = "No",
                        },
                        
                    }
                },
                //END, ID:17
                new Question
                {
                    Id = 17,
                    QuestionText = "Done. You answered all necessary Questions!",
                    QuestionType = QuestionType.end,
                    QuestionHelpText = "Your individual result will now be calculated...",
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
                        Attribute.scalability,Attribute.flexibility,Attribute.performance,Attribute.simplicity,Attribute.lowCost
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
                        //min 10 employees
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = 0.29,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 10,
                                }
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
                        Attribute.performance,Attribute.lowCost, Attribute.simplicity,Attribute.flexibility,Attribute.scalability,
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
                            Weight = 0.15,
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
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F11"
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
                
                // Zoho
                new Technology
                {
                    Name = "Zoho CRM",
                    SubHeader = "CRM System",
                    Description = "End-to-end, fully customizable CRM solution for growing businesses and enterprises.",
                    Category = Category.BusinessManagement,
                    LogoUrl = "/img/technologies/zoho-crm.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost, Attribute.flexibility, Attribute.scalability, Attribute.performance,Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a CRM System
                        new Condition
                        {
                            QuestionId = 5,
                            Weight = 0.61,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "E3",
                                },
                            }
                        },
                        //medium size Team (negative effect)
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = -0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Min = 30,
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
                            Weight = 0.60,
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
                            Weight = 0.30,
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
                            Weight = 0.10,
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
                    LogoUrl = "/img/technologies/hubspot.png",
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
                            Weight = 0.60,
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
                            Weight = 0.30,
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
                            Weight = 0.10,
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
                        //wants a Communication- & Collaborationsystems
                        new Condition
                        {
                            QuestionId = 4,
                            Weight = 0.7,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "D2",
                                },
                            }
                        },
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.3,
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
                        //wants a Communication- & Collaborationsystems
                        new Condition
                        {
                            QuestionId = 4,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "D2",
                                },
                            }
                        },
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.35,
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
                    Name = "Zoom",
                    SubHeader = "Communication Software",
                    Description = "Zoom is the leader in modern enterprise video communications, with an easy, reliable cloud platform for video and audio conferencing, chat, and webinars.",
                    Category = Category.CommunicationCollaboration,
                    LogoUrl = "/img/technologies/Zoom.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.flexibility,Attribute.lowCost,Attribute.simplicity, Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a Communication- & Collaborationsystems
                        new Condition
                        {
                            QuestionId = 4,
                            Weight = 0.7,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "D2",
                                },
                            }
                        },
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F4",
                                },
                            }
                        },
                        //Team size (negative) due to lack if integration for other plattforms
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
                
                // Slack
                new Technology
                {
                    Name = "Slack",
                    SubHeader = "Project Management System",
                    Description = "Slack is a proprietary business communication platform that offers many IRC-style features, including persistent chat rooms (channel) organized by topic, private groups, and direct messaging.",
                    Category = Category.CommunicationCollaboration,
                    LogoUrl = "/img/technologies/slack.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.simplicity,Attribute.flexibility, Attribute.lowCost,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a Communication- & Collaborationsystems
                        new Condition
                        {
                            QuestionId = 4,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "D2",
                                },
                            }
                        },
                        //Experience in Slack
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.1,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F3",
                                },
                            }
                        },
                        //Team size only for small teams
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Max = 10
                                },
                            }
                        },
                    }
                },
                
                new Technology
                {
                    Name = "Trello",
                    SubHeader = "Organize your Todos",
                    Description = "Trello is a visual tool for organizing your work and life. Very flexible and easy to use. Its also free!",
                    Category = Category.CommunicationCollaboration,
                    LogoUrl = "/img/technologies/Trello.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.flexibility, Attribute.performance,Attribute.simplicity, Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //wants a Communication- & Collaborationsystems
                        new Condition
                        {
                            QuestionId = 4,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "D2",
                                },
                            }
                        },
                        //Experience
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.1,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F6",
                                },
                            }
                        },
                        //Team size only for small teams
                        new Condition
                        {
                            QuestionId = 2,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "B1",
                                    Max = 10
                                },
                            }
                        },
                    }
                },
                
                
                
                
                // Wix
                new Technology
                {
                    Name = "Wix",
                    SubHeader = "Cloud-based Website Builder",
                    Description = "Create HTML5 websites and mobile sites through the use of online drag and drop tools.",
                    Category = Category.Website
                    ,
                    LogoUrl = "/img/technologies/Wix.png",

                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.simplicity,Attribute.lowCost, Attribute.performance, Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //Informative Content
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.75,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1"
                                },
                            }
                        },
                        //Website Shop system Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N1"
                                },
                            }
                        },
                        //Website CM Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N3"
                                },
                            }
                        },
                        //Website User login & Accounts Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N2"
                                },
                            }
                        },
                        //Website individual Software Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.40,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N4"
                                },
                            }
                        },
                      
                      
                    }
                },

                // Webflow
                new Technology
                {
                    Name = "Webflow",
                    SubHeader = "Cloud-based Website Builder",
                    Description = "Drag-and-drop website builder for creating professional responsive websites.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/webflow.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.performance, Attribute.simplicity, Attribute.scalability,Attribute.lowCost
                    },
                    Conditions = new List<Condition>
                    {
                        //Informative Content
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.79,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1"
                                },
                            }
                        },
                        //Website Shop system Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N1"
                                },
                            }
                        },
                        //Website CM Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N3"
                                },
                            }
                        },
                        //Website User login & Accounts Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N2"
                                },
                            }
                        },
                        //Website individual Software Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N4"
                                },
                            }
                        },
                    }
                },

                // WordPress
                new Technology
                {
                    Name = "WordPress",
                    SubHeader = "Content Management System",
                    Description = "Free and open-source software you can use to create a beautiful website, blog, or app.",
                    Category =  Category.Website,
                    LogoUrl = "/img/technologies/wordpress.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost, Attribute.simplicity, Attribute.scalability, Attribute.flexibility,Attribute.performance,
                    },
                    Conditions = new List<Condition>
                    {
                        //Informative Content
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1"
                                },
                            }
                        },
                        //Website Shop system Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N1"
                                },
                            }
                        },
                        //Website CM Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.35,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N3"
                                },
                            }
                        },
                        //Website User login & Accounts Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N2"
                                },
                            }
                        },
                        //Website individual Software Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.20,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N4"
                                },
                            }
                        },
                    }
                },

                // Shopify
                new Technology
                {
                    Name = "Shopify",
                    SubHeader = "eCommerce Software",
                    Description = "Proprietary e-commerce platform that offers online retailers a suite of services including payments, marketing, shipping and \"customer engagement tools\".",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/shopify.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.flexibility,Attribute.simplicity,Attribute.lowCost,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //Informative Content
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.45,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1"
                                },
                            }
                        },
                        //Website Shop system Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.40,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N1"
                                },
                            }
                        },
                        //Website CM Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.15,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N3"
                                },
                            }
                        },
                        //Website User login & Accounts Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N2"
                                },
                            }
                        },
                        //Website individual Software Component
                        new Condition
                        {
                            QuestionId = 13,
                            Weight = -0.40,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "N4"
                                },
                            }
                        },
                    }
                },

                // PostgreSQL
                new Technology
                {
                    Name = "PostgreSQL",
                    SubHeader = "SQL Database",
                    Description = "PostgreSQL, also known as Postgres, is a free and open-source relational database management system emphasizing extensibility and SQL compliance.",
                    Category = Category.Database,
                    LogoUrl = "/img/technologies/postgresql.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.scalability, Attribute.lowCost,Attribute.flexibility,Attribute.simplicity,
                    },
                    Conditions = new List<Condition>
                    {
                        //Experience in SQL
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I16",
                                },
                            }
                        },
                        //structured Data
                        new Condition
                        {
                            QuestionId = 14,
                            Weight = 0.79,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "O1",
                                },
                            }
                        },
                        //unstructured Data
                        new Condition
                        {
                            QuestionId = 14,
                            Weight = 0.35,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "O2",
                                },
                            }
                        },
                    }
                },

                // MongoDB
                new Technology
                {
                    Name = "MongoDB",
                    SubHeader = "NoSQL Database",
                    Description = "Classified as a NoSQL database program, MongoDB uses JSON-like documents with optional schemas",
                    Category = Category.Database,
                    LogoUrl = "/img/technologies/mongodb.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.performance,Attribute.lowCost,Attribute.simplicity,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //Experience in JSON
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        //unstructured Data
                        new Condition
                        {
                            QuestionId = 14,
                            Weight = 0.79,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "O2",
                                },
                            }
                        },
                        //unstructured Data
                        new Condition
                        {
                            QuestionId = 14,
                            Weight = 0.49,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "O1",
                                },
                            }
                        },
                    }
                },

                // Amazon DynamoDB
                new Technology
                {
                    Name = "Amazon DynamoDB",
                    SubHeader = "NoSQL Database",
                    Description = "Amazon DynamoDB is a fully managed proprietary NoSQL database service that supports key-value and document data structures and is offered by Amazon.com as part of the Amazon Web Services portfolio.",
                    Category = Category.Database,
                    LogoUrl = "/img/technologies/DynamoDB.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.scalability,Attribute.performance,Attribute.flexibility
                    },
                    Conditions = new List<Condition>
                    {
                        //Experience in JSON
                        new Condition
                        {
                            QuestionId = 6,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "F16",
                                },
                            }
                        },
                        //external Providers
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.15,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        //unstructured Data
                        new Condition
                        {
                            QuestionId = 14,
                            Weight = 0.69,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "O2",
                                },
                            }
                        },
                        //structured Data
                        new Condition
                        {
                            QuestionId = 14,
                            Weight = 0.59,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "O1",
                                },
                            }
                        },
                    }
                },
                // Spring
                new Technology
                {
                    Name = "Spring",
                    SubHeader = "Application Framework",
                    Description = "Spring makes programming Java quicker, easier, and safer for everybody. Spring’s focus on speed, simplicity, and productivity has made it the world's most popular Java framework.",
                    Category = Category.Website,
                    SubCategory = SubCategory.FrontAndBackend,
                    LogoUrl = "/img/technologies/java_spring.png",
                    Language = "Java",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.flexibility,Attribute.lowCost, Attribute.scalability,Attribute.simplicity,
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.35,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Java
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I1",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                        //not common -> better to develop internally 
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.15,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Java
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                    }
                },

                // React
                new Technology
                {
                    Name = "React",
                    SubHeader = "Frontend JS-Framework",
                    Description = "React is an open-source, front end, JavaScript library for building user interfaces or UI components maintained by Facebook.",
                    Category = Category.Website,
                    SubCategory = SubCategory.Frontend,
                    LogoUrl = "/img/technologies/react.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.flexibility, Attribute.lowCost, Attribute.scalability,Attribute.simplicity,
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.35,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JavaScript
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        
                        // common -> good for extrenal and internal development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.15,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },

                // Angular
                new Technology
                {
                    Name = "Angular",
                    SubHeader = "Frontend JS-Framework",
                    Description = "Angular is an open-source platform for building mobile and desktop web applications.",
                    Category = Category.Website,
                    SubCategory = SubCategory.Frontend,
                    LogoUrl = "/img/technologies/angular.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.scalability,Attribute.flexibility,Attribute.lowCost, Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.35,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JavaScript
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        
                        // common -> good for extrenal and internal development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.15,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },

                // Vue
                new Technology
                {
                    Name = "Vue.js",
                    SubHeader = "Frontend JS-Framework",
                    Description = "Vue.js is an open-source frontend JavaScript framework for building user interfaces and single-page applications.",
                    Category = Category.Website,
                    SubCategory = SubCategory.Frontend,
                    LogoUrl = "/img/technologies/vuejs.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.simplicity,Attribute.lowCost, Attribute.scalability,Attribute.performance,
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.27,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JavaScript
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.62,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                        //not common -> better to develop internally 
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.04,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                    }
                },

                //  Express + Node.JS
                new Technology
                {
                    Name = "Express + Node.JS",
                    SubHeader = "Backend JS-Framework",
                    Description = "Free and open-source software you can use to create a beautiful website, blog, or app.",
                    Category =  Category.Website,
                    SubCategory = SubCategory.Backend,
                    LogoUrl = "/img/technologies/node_js.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.performance,Attribute.scalability,Attribute.simplicity,Attribute.lowCost, 
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.35,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JavaScript
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                        //not common -> better to develop internally 
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.15,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                    }
                },

                // Django
                new Technology
                {
                    Name = "Django",
                    SubHeader = "Python: Full Stack Webframework",
                    Description = "Django is a high-level Python Web framework that encourages rapid development and clean, pragmatic design.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/django.png",
                    Language = "Python",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.scalability,Attribute.flexibility,Attribute.lowCost,Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.31,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Python
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I2",
                                },
                            }
                        },
                        
                        // common -> good for extrenal and internal development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.10,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.65,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },

                // Flask
                new Technology
                {
                    Name = "Flask",
                    SubHeader = "Python: Full Stack Webframework",
                    Description = "Flask is a Python web framework built with a small core and easy-to-extend philosophy.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/flask.png",
                    Language = "Python",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.simplicity,Attribute.flexibility,Attribute.performance,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.32,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Python
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I2",
                                },
                            }
                        },
                        
                        // not common -> not good for external development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.08,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.58,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },
                
                //Laravel
                new Technology
                {
                    Name = "Laravel",
                    SubHeader = "PHP: Full Stack Webframework",
                    Description = "Laravel is a web application framework with expressive, elegant syntax.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/Laravel.png",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.flexibility, Attribute.performance,Attribute.simplicity, Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.32,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //PHP
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I11",
                                },
                            }
                        },
                        
                        // not common -> not good for external development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.08,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.49,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                        
                    }
                },

                // Blazor
                new Technology
                {
                    Name = "Blazor",
                    SubHeader = "Frontend C#-Framework",
                    Description = "Blazor is a free and open-source web framework that enables developers to create web apps using C# and HTML.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/blazor.png",
                    Language = "C#",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.flexibility,Attribute.simplicity,Attribute.lowCost,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.27,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //C#
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I3",
                                },
                            }
                        },
                        
                        // not common -> not good for external development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.05,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.63,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },

                // .net Core
                new Technology
                {
                    Name = ".net Core",
                    SubHeader = "Backend C#-Framework",
                    Description = "Powerful open-source framework for all kinds of development purposes supported by Microsoft.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/dotnetcore.png",
                    Language = "C#",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.flexibility,Attribute.lowCost,Attribute.simplicity,Attribute.scalability
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.27,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //C#
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I3",
                                },
                            }
                        },
                        
                        // not common -> not good for external development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.05,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.63,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },
                
                // Ruby on Rails
                new Technology
                {
                    Name = "Ruby on Rails",
                    SubHeader = "Full stack Webframework on Ruby",
                    Description = "Ruby on Rails, or Rails, is a server-side web application framework written in Ruby under the MIT License. Rails is a model–view–controller framework, providing default structures for a database, a web service, and web pages.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/ruby.png",
                    Language = "Ruby",
                    Attributes = new List<Attribute>
                    {
                        Attribute.lowCost,Attribute.scalability,Attribute.flexibility,Attribute.performance,Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.38,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Rails
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I12",
                                },
                            }
                        },
                        
                        // not common -> not good for external development
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.07,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                        
                        //Need for a WebApp
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.42,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                    }
                },
                
                
                /// Native App Section
                
                //React Native
                new Technology
                {
                    Name = "React Native",
                    SubHeader = "Cross-Platform Mobile App Framework",
                    Description = "React Native is an open-source mobile application framework created by Facebook. It is used to develop applications for Android, Android TV, iOS, macOS, tvOS, Web, Windows and UWP by enabling developers to use React's framework along with native platform capabilities.",
                    Category = Category.MobileApp,
                    LogoUrl = "/img/technologies/react.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.scalability,Attribute.lowCost,Attribute.performance,Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.30,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JS
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JS
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //need fast, cost & development effective
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.45,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P1",
                                },
                            }
                        },
                    }
                },
                //Ionic
                new Technology
                {
                    Name = "Ionic",
                    SubHeader = "Cross-Platform Mobile App Framework",
                    Description = "Ionic Framework is an open source UI toolkit for building performant, high-quality mobile and desktop apps using web technologies — HTML, CSS, and JavaScript — with integrations for popular frameworks like Angular, React, and Vue.",
                    Category = Category.MobileApp,
                    LogoUrl = "/img/technologies/ionic.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.simplicity,Attribute.scalability,Attribute.lowCost,Attribute.performance,
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.20,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JS
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10",
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.31,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JS
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //need fast, cost & development effective
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.47,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P1", Weight = 1
                                },
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P2", Weight = 0.4
                                },
                            }
                        },
                    }
                },
                //Xamarin
                new Technology
                {
                    Name = "Xamarin",
                    SubHeader = "Hybrid Mobile App Framework",
                    Description = "Xamarin is an open-source platform for building modern and performant applications for iOS, Android, and Windows with . NET.",
                    Category = Category.MobileApp,
                    LogoUrl = "/img/technologies/Xamarin.png",
                    Language = "C#",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.performance,Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.33,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //c#
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I3",
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //mainly informative purpose app
                        new Condition
                        {
                            QuestionId = 12,
                            Weight = 0.12,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "M1",
                                },
                            }
                        },
                        //need fast, cost & development effective
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P1", Weight = 1
                                },
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P2", Weight = 0.4
                                },
                            }
                        },
                    }
                },
                //Flutter
                new Technology
                {
                    Name = "Flutter",
                    SubHeader = "Cross-Platform UI Framework",
                    Description = "Flutter is an open-source UI software development kit created by Google. It is used to develop applications for Android, iOS, Linux, Mac, Windows, Google Fuchsia, and the web from a single codebase.",
                    Category = Category.MobileApp,
                    LogoUrl = "/img/technologies/flutter.png",
                    Language = "Dart",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.performance,Attribute.scalability,Attribute.lowCost,Attribute.simplicity
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.31,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Dart
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I15",
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //mainly informative purpose app
                        new Condition
                        {
                            QuestionId = 12,
                            Weight = 0.12,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "M1",
                                },
                            }
                        },
                        //need fast, cost & development effective
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.24,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P1", Weight = 1
                                },
                                
                            }
                        },
                        //dev from external
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = -0.08,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                    }
                },
                //Native iOS
                new Technology
                {
                    Name = "Native iOS APP",
                    SubHeader = "Only for Apple Plattforms",
                    Description = "A native app, or native application, is a software application built in a specific programming language, for the specific device platform, either iOS or Android. See the <a href=\"/overview\">overview</a> for pros and cons.",
                    Category = Category.MobileApp,
                    LogoUrl = "/img/technologies/apple.png",
                    Language = "Swift",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.scalability,Attribute.simplicity,Attribute.lowCost,Attribute.flexibility
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Swift
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I13",
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //highly interactive
                        new Condition
                        {
                            QuestionId = 12,
                            Weight = 0.34,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "M2",
                                },
                            }
                        },
                        //need high performance & mobile hardware features
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.24,
                            RequiredAnswers = new List<Condition.QuestionAnswer>
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P2",
                                },
                                
                            }
                        },
                        //dev from external
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.05,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                    }
                },
                //Native Android
                new Technology
                {
                    Name = "Native Android APP",
                    SubHeader = "Only for Android Plattforms",
                    Description = "A native app, or native application, is a software application built in a specific programming language, for the specific device platform, either iOS or Android. See the <a href=\"/overview\">overview</a> for pros and cons.",
                    Category = Category.MobileApp,
                    LogoUrl = "/img/technologies/android.png",
                    Language = "Kothlin & Java",
                    Attributes = new List<Attribute>
                    {
                        Attribute.performance,Attribute.scalability,Attribute.simplicity,Attribute.lowCost,Attribute.flexibility
                    },
                    Conditions = new List<Condition>
                    {
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //Kotlin
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I14", Weight = 1,
                                },
                                //Java
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I1", Weight = 1
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //highly interactive
                        new Condition
                        {
                            QuestionId = 12,
                            Weight = 0.37,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "M2",
                                },
                            }
                        },
                        //need high performance & mobile hardware features
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.22,
                            RequiredAnswers = new List<Condition.QuestionAnswer>
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P2",
                                },
                                
                            }
                        },
                        //dev from external
                        new Condition
                        {
                            QuestionId = 8,
                            Weight = 0.13,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "H2",
                                },
                            }
                        },
                    }
                },
                
                
                //PWA
                new Technology
                {
                    Name = "PWA",
                    SubHeader = "Progressive Web App",
                    Description = "A Progressive Web App (PWA) is a website that has many features previously reserved for native apps. Revolutionary but still in a early stage.",
                    Category = Category.Website,
                    LogoUrl = "/img/technologies/pwa.png",
                    Language = "JavaScript",
                    Attributes = new List<Attribute>
                    {
                        Attribute.flexibility,Attribute.lowCost,Attribute.performance,Attribute.scalability,Attribute.simplicity,
                    },
                    Conditions = new List<Condition>
                    {
                        //Webapp
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.21,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //WebApp
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G1"
                                },
                            }
                        },
                        //skill in certain language
                        new Condition
                        {
                            QuestionId = 9,
                            Weight = 0.11,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                //JS
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I10"
                                },
                                //HTML
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I8"
                                },
                                //CSS
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "I9"
                                },
                            }
                        },
                        //need mobile app
                        new Condition
                        {
                            QuestionId = 7,
                            Weight = 0.25,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "G2",
                                },
                            }
                        },
                        //TYPE OF WEBSITE
                        new Condition
                        {
                            QuestionId = 10,
                            Weight = 0.09,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "J1",
                                },
                            }
                        },
                        //highly interactive
                        new Condition
                        {
                            QuestionId = 12,
                            Weight = 0.08,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "M1",
                                },
                            }
                        },
                        //need high performance & mobile hardware features
                        new Condition
                        {
                            QuestionId = 15,
                            Weight = 0.08,
                            RequiredAnswers = new List<Condition.QuestionAnswer>
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "P2",
                                },
                                
                            }
                        },
                        //dev from external
                        new Condition
                        {
                            QuestionId = 16,
                            Weight = 0.23,
                            RequiredAnswers = new List<Condition.QuestionAnswer>()
                            {
                                new Condition.QuestionAnswer()
                                {
                                    AnswerId = "Q1",
                                },
                            }
                        },
                    }
                },
                
                
                
                //TODO Desktop Apps
                
                //TODO Hosting
                
            };



            UserAnswers = new List<UserQuestionAnswer>
            {
                new UserQuestionAnswer()
                {
                    QuestionId = 1,
                    Answers = new List<UserQuestionAnswer.Answer>()
                    {
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "A1",
                            Value = "5",
                        }
                    }
                },
                new UserQuestionAnswer()
                {
                    QuestionId = 2,
                    Answers = new List<UserQuestionAnswer.Answer>()
                    {
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "B1",
                            Value = "12",
                        }
                    }
                },
                new UserQuestionAnswer()
                {
                    QuestionId = 3,
                    Answers = new List<UserQuestionAnswer.Answer>()
                    {
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "C4",
                            Value = "1",
                        },
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "C2",
                            Value = "2",
                        },
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "C3",
                            Value = "3",
                        },
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "C1",
                            Value = "4",
                        },
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "C5",
                            Value = "5",
                        },
                        
                    }
                },
                new UserQuestionAnswer()
                {
                    QuestionId = 9,
                    Answers = new List<UserQuestionAnswer.Answer>()
                    {
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "I3",
                        }
                    }
                },
                new UserQuestionAnswer()
                {
                    QuestionId = 8,
                    Answers = new List<UserQuestionAnswer.Answer>()
                    {
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "H1",
                        }
                    }
                },
                new UserQuestionAnswer()
                {
                    QuestionId = 10,
                    Answers = new List<UserQuestionAnswer.Answer>()
                    {
                        new UserQuestionAnswer.Answer()
                        {
                            AnswerId = "J1",
                        }
                    }
                },
            };


            PartnerData = new List<Partner>
            {
                new Partner
                {
                    Name = "Akount",
                    Website = "https://www.akount.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Amie",
                    Website = "https://amie.so/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Aplano",
                    Website = "https://www.aplano.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "eco-projects.global",
                    Website = "https://eco-projects.global/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "ecotrek",
                    Website = "https://ecotrek.tech/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "elbwalker",
                    Website = "https://www.elbwalker.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Evernest",
                    Website = "https://www.evernest.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Gesund & Mutter",
                    Website = "https://www.gesundundmutter.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "HARPOCRATES Solution GmbH",
                    Website = "https://www.harpocrates-corp.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Humby",
                    Website = "https://www.humby.io/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "INTOYOU",
                    Website = "https://into-you.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "jetlite",
                    Website = "https://www.jetlite.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "JOBMATCH.ME",
                    Website = "https://www.jobmatch.me/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Launch Control Consulting",
                    Website = "",
                    Logo = ""
                },
                new Partner
                {
                    Name = "LIVEDAB GmbH",
                    Website = "https://livedab.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "medocos",
                    Website = "https://www.medocos.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "moin.ai",
                    Website = "https://www.moin.ai/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "MotorSkins",
                    Website = "https://motorskins.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "musicube",
                    Website = "https://www.musicu.be/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Naodrinks",
                    Website = "https://www.naodrinks.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Nordantech Solutions GmbH",
                    Website = "https://www.nordantech.com/de",
                    Logo = ""
                },
                new Partner
                {
                    Name = "PayNowEatLater",
                    Website = "https://www.paynoweatlater.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Plancraft",
                    Website = "https://plancraft.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "releaf GmbH",
                    Website = "https://www.rele.af/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "ryddle",
                    Website = "https://ryddle.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "shipcloud",
                    Website = "https://www.shipcloud.io/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Sponsoo",
                    Website = "https://www.sponsoo.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Taste Tours",
                    Website = "https://www.tastetours.de/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "TheCalmBase",
                    Website = "https://www.thecalmbase.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "TripLegend",
                    Website = "https://triplegend.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "UNI VERSE",
                    Website = "",
                    Logo = ""
                },
                new Partner
                {
                    Name = "Vote Rookie",
                    Website = "https://www.voterookie.org/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "whyzzer",
                    Website = "https://www.whyzzer.com/",
                    Logo = ""
                },
                new Partner
                {
                    Name = "WUNDERPARC",
                    Website = "https://www.wunderparc.com/",
                    Logo = ""
                }
                
            };
        
        }
        
        
        
        
    }
}