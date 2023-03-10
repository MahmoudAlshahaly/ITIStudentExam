using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IChoiceRepository
    {
        List<Choice> GetAll();
        Choice GetById(int id);
        int GetIDLast();
        int Insert(Choice entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Choice entity);

    }
}
