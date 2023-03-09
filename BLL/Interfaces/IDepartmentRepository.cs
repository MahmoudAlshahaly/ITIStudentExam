using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department GetById(int id);
        Department GetByName(string name);
        int GetIDLast();
        int Insert(Department entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Department entity);

    }
}
