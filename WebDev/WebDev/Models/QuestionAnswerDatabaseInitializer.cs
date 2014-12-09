using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WebDev.Models
{
    public class QuestionAnswerDatabaseInitializer : DropCreateDatabaseIfModelChanges<QuestionAnswerContext>
    {
        protected override void Seed(QuestionAnswerContext context)
        {
 	        GetQuestions().ForEach(q => context.Questions.Add(q));
            GetAnswers().ForEach(a => context.Answers.Add(a));
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
    }
}
        