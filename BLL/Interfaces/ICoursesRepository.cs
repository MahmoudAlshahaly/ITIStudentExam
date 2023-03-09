using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICoursesRepository
    {
        List<Course> GetAll();
        Course GetById(int id);
        Course GetByName(string name);
        int GetIDLast();
        int Insert(Course entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Course entity);

    }
}
