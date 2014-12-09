using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WebDev.Models
{
    public class NotesDatabaseInitializer : DropCreateDatabaseIfModelChanges<NotesContext>
    {


        protected override void Seed(NotesContext context)
        {
            GetNotes().ForEach(n => context.Notes.Add(n));
            
        }

        private static List<Notes> GetNotes()
        {
            var notes = new List<Notes> {
                new Notes{
                    NotesID = 1,
                    NotesTitle = "ASP.NET topic",
                    NotesBody = "I am going to explain the basic architecture and usage of asp.net.",
                    User = "Sam",
                    
                    Created = System.DateTimeOffset.Now,
                    
                    ModuleID = "COMP6205"
                },
                new Notes{
                   NotesID = 2,
                    NotesTitle = "I'm not sure if it's doing anything?",
                    NotesBody = "Is this working I wonder? Can you tell me please?",
                    User = "Sam",
                    UserModified = "Dom",
                    Modified = System.DateTimeOffset.Now,
                    Created = System.DateTimeOffset.Now,
                    ModuleID = "COMP6205"
                },
                
            };
            return notes;
        }

        

    }
}