using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentGradeRepository
    {
        List<StudentGrades> GetAll();
        int Insert(StudentGrades entity);

    }
}
