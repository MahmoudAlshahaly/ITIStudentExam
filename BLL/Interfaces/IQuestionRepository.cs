using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IQuestionRepository
    {
        List<Question> GetAll();
        Question GetById(int id);
        int GetIDLast();
        int Insert(Question entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Question entity);

    }
}
