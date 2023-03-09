using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IInstructorRepository
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        Instructor GetByName(string name);
        int GetIDLast();
        int Insert(Instructor entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Instructor entity);
        Instructor GetByNamePassword(string name, string password);


    }
}
