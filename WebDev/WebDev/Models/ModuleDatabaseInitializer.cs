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
                    Description = "A module to explore the area of Web Development, teaching students best" + 
                                    " practise and to introduce students to ASP.net and the Visual Studio" +
                                    " development environment.",
                    SubjectID = 1
                },
                new Module{
                    ModuleID = "COMP6203",
                    ModuleTitle = "Intelligent Agents",
                    Description = "This unit gives a broad introduction to the new and rapidly expanding field of agent-based computing. It introduces the key concepts and models of the field, dealing both with the individual agents and with their interactions. Particular emphasis is placed on automated negotiation, cooperation and on-line auctions, and students are required to program a trading agent in Java which will compete in a class tournament within a simulated trading environment",
                    SubjectID = 1
                },
                new Module{
                    ModuleID = "COMP6201",
                    ModuleTitle = "E-Business Strategy",
                    Description = "This course exposes students to the problems and methods of strategic management of large scale e-business systems. These are systems whose continuing operation and evolution is vital for the business or organisation that they serve. IT managers and CIOs must ensure that systems are effective and cost-effective, that new projects give a good return, and that emerging technologies are evaluated and, where appropriate, adopted in an orderly manner. Similarly, emerging risks such as security threats must be evaluated and addressed using appropriate and cost-effective techniques.",
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
    }
}