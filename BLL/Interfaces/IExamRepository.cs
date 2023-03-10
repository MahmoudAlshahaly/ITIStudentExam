using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IExamRepository
    {
        List<Exam> GetAll();
        Exam GetById(int id);
        Exam GetByName(string name);
        int GenerateExam(GenerateExam entity);

        int GetIDLast();
        int Insert(Exam entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Exam entity);

    }
}
