using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.Services.Interfaces
{
    public interface IJournalService
    {
        IEnumerable<Journal> GetAll();
        int Create(Journal model);
        Journal Get(int id);
        bool Delete(int id);
        int Edit(Journal model);
    }
}