using System.Collections.Generic;
using System.Data.Entity;

namespace WebDev.Models
{
    public class ModuleDatabaseInitializer : DropCreateDatabaseIfModelChanges<ModuleContext>
    {
        protected override void Seed(ModuleContext context)
        {
            GetSubjects().ForEach(s => context.Subjects.Add(s));
            GetModules().ForEach(m => context.Modules.Add(m));
            GetQuestions().ForEach(q => context.Questions.Add(q));
            GetAnswers().ForEach(a => context.Answers.Add(a));
            GetNotes().ForEach(n => context.Notes.Add(n));
        }

        private static List<Subject> GetSubjects()
        {
            var subjects = new List<Subject> {
                    new Subject{
                    SubjectID = 1,
                    SubjectName = "Computer Science"
                },
                new Subject{
                    SubjectID = 2,
                    SubjectName = "Physics"
                },
                new Subject{
                    SubjectID = 3,
                    SubjectName = "Social Science"
                },
            };

            return subjects;
        }

        private static List<Module> GetModules()
        {
            var modules = new List<Module>{
                new Module{
                    ModuleID = "COMP6205",
                    ModuleTitle = "Web Development",
                    Description = "A module to explore the area of Web Development, teaching students best",// + 
                                    //" practise and to introduce students to ASP.net and the Visual Studio" +
                                   // " development environment.",
                    SubjectID = 1
                },
                new Module{
                    ModuleID = "COMP6203",
                    ModuleTitle = "Intelligent Agents",
                    Description = "This unit gives a broad introduction to the new and rapidly expanding field of agent-based computing.",// It introduces the key concepts and models of the field, dealing both with the individual agents and with their interactions. Particular emphasis is placed on automated negotiation, cooperation and on-line auctions, and students are required to program a trading agent in Java which will compete in a class tournament within a simulated trading environment",
                    SubjectID = 1
                },
                new Module{
                    ModuleID = "COMP6201",
                    ModuleTitle = "E-Business Strategy",
                    Description = "This course exposes students to the problems and methods of strategic management of large scale e-business systems.",// These are systems whose continuing operation and evolution is vital for the business or organisation that they serve. IT managers and CIOs must ensure that systems are effective and cost-effective, that new projects give a good return, and that emerging technologies are evaluated and, where appropriate, adopted in an orderly manner. Similarly, emerging risks such as security threats must be evaluated and addressed using appropriate and cost-effective techniques.",
                    SubjectID = 1
                },
                new Module{
                    ModuleID = "PHYS1001",
                    ModuleTitle = "Basic Physics",
                    Description = "Physic Stuff for dummies.",
                    SubjectID = 2
                },
                new Module{
                    ModuleID = "PHYS1002",
                    ModuleTitle = "Basic Physic II",
                    Description = "Slightly less dummy stuff.",
                    SubjectID = 2
                },
                new Module{
                    ModuleID = "PHYS4001",
                    ModuleTitle = "Super Advanced Physics",
                    Description = "You gotta be clever for this!",
                    SubjectID = 2
                },
                new Module{
                    ModuleID = "SOCI1001",
                    ModuleTitle = "People and Stuff",
                    Description = "Let's talk about people!",
                    SubjectID = 3
                },
                new Module{
                    ModuleID = "SOCI2001",
                    ModuleTitle = "Advanced People and Stuff",
                    Description = "Let's talk a little more about People and Stuff!",
                    SubjectID = 3
                },
                new Module{
                    ModuleID = "SOCI3001",
                    ModuleTitle = "Really Advanced People and Stuff",
                    Description = "Let's talk about difficult people and difficult stuff!",
                    SubjectID = 3
                },
            };

            return modules;
        }
        private static List<Question> GetQuestions()
        {
            var questions = new List<Question> {
                new Question{
                    QuestionID = 1,
                    QuestionTitle = "I'm not sure if it's working?",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6205"
                },
                new Question{
                    QuestionID = 2,
                    QuestionTitle = "I'm not sure if it's doing anything?",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6205"
                },
                new Question{
                    QuestionID = 3,
                    QuestionTitle = "Please?",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6205"
                },
                new Question{
                    QuestionID = 4,
                    QuestionTitle = "Come on!",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6203"
                },
                new Question{
                    QuestionID = 5,
                    QuestionTitle = "Duuuuuuuuuude!",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6203"
                },
                new Question{
                    QuestionID = 6,
                    QuestionTitle = "Where's my car?",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6203"
                },
                new Question{
                    QuestionID = 7,
                    QuestionTitle = "Sweet, what does mine say?",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6201"
                },
                new Question{
                    QuestionID = 8,
                    QuestionTitle = "Dude, what does mine say?",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6201"
                },
                new Question{
                    QuestionID = 9,
                    QuestionTitle = "WHAT DOES MINE SAY?!?!?!?!",
                    QuestionBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    Solved = false,
                    ModuleID = "COMP6201"
                },
            };
            return questions;
        }

        private static List<Answer> GetAnswers()
        {
            var answers = new List<Answer>{
                new Answer{
                    AnswerID = 1,
                    AnswerBody = "Sure does!",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 1,
                },
                new Answer{
                    AnswerID = 2,
                    AnswerBody = "Yep does!",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 2,
                },
                new Answer{
                    AnswerID = 3,
                    AnswerBody = "Yes!",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 3,
                },
                new Answer{
                    AnswerID = 4,
                    AnswerBody = "Okay!",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 4,
                },
                new Answer{
                    AnswerID = 5,
                    AnswerBody = "Nope!",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 5,
                },
                new Answer{
                    AnswerID = 6,
                    AnswerBody = "Who knows.",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 6,
                },
                new Answer{
                    AnswerID = 7,
                    AnswerBody = "Dude",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 7,
                },
                new Answer{
                    AnswerID = 8,
                    AnswerBody = "Sweeeeet.",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 8,
                },
                new Answer{
                    AnswerID = 9,
                    AnswerBody = "Screw you! ",
                    User = "Dom",
                    Solved = true,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 9,
                },
                new Answer{
                    AnswerID = 10,
                    AnswerBody = "IT'S ALL BROKEN!",
                    User = "Dom",
                    Solved = false,
                    Created = System.DateTimeOffset.Now,
                    QuestionID = 1,
                },
            };
            return answers;
        }

        private static List<Notes> GetNotes()
        {
            var questions = new List<Notes> {
                new Notes{
                    NotesID = 1,
                    NotesTitle = "The first notes document ever!",
                    NotesBody = "Awesome document!",
                    User = "Dom",
                    Created = System.DateTimeOffset.Now,
                    
                    ModuleID = "COMP6205"
                },
                new Notes{
                    NotesID = 2,
                    NotesTitle = "Wow it works, awesome!",
                    NotesBody = "Of course it works, you guys have done it awesomely!",
                    User = "Sam",
                    Created = System.DateTimeOffset.Now,
                    UserModified = "Dom",
                    ModuleID = "COMP6205"
                }
            };
            return questions;
        }

    }
}