using MVCApp.Models;
using MVCApp.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MVCApp.Services.Implementations
{
    internal class JournalService: IJournalService
    {
        private static readonly List<Journal> journals = new List<Journal>();
        public int Create(Journal journal)
        {
            journals.Add(journal);
            return journal.Id;
        }
       
        public Journal Get(int id)
        {
            return journals.FirstOrDefault(x => x.Id == id);
        }

        public int Edit(Journal journal)
        {
            int _index = journals.IndexOf(Get(journal.Id));
            journals[_index] = journal;
            return journal.Id;
        }

        public bool Delete(int id)
        {
            bool result = journals.Remove(Get(id));
            return result;
        }
        
        IEnumerable<Journal> IJournalService.GetAll()
        {
            return journals;
        }
    }
}
