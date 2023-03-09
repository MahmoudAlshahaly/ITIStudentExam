using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentAnswerRepository
    {
        List<StudentAnswer> GetAll();
        int Insert(StudentAnswer entity);

    }
}
