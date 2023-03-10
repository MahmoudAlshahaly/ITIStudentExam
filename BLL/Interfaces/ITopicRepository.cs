using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITopicRepository
    {
        List<Topic> GetAll();
        Topic GetById(int id);
        Topic GetByName(string name);
        int GetIDLast();
        int Insert(Topic entity);
        int RemoveOne(int id);
        int RemoveAll();
        int Edit(Topic entity);
    }
}
