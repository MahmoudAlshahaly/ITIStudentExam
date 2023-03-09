using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string name);
        int GetIDLast();
        int Insert(Student entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Student entity);
        Student GetByNamePassword(string name, string password);

    }
}
