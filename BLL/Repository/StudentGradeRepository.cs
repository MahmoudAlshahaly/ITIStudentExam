using BLL.Entities;
using BLL.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class StudentGradeRepository : IStudentGradeRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public StudentGradeRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public List<StudentGrades> GetAll()
        {
            dataTable = db.SelectAllStored("StudentGradesAll");
            List<StudentGrades> entitys = MapDataTableToStudentGrades(dataTable);
            return entitys;
        }
        public List<StudentGrades> MapDataTableToStudentGrades(DataTable dataTable)
        {
            List<StudentGrades> entitys = new List<StudentGrades>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToStudentGrades(dataRow));
            }
            return entitys;
        }
        public StudentGrades MapDataRowToStudentGrades(DataRow dataRow)
        {
            StudentGrades entity = new StudentGrades();
            entity.grade_id= Convert.ToInt32(dataRow[0]);
            entity.grade_stu_id = dataRow[1].ToString();
            entity.grade_exam_id = dataRow[2].ToString();
            entity.grade_percent =Convert.ToInt32(dataRow[3]);
           
            return entity;
        }

        public int Insert(StudentGrades entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@grade_stu_id"] = entity.grade_stu_id,
                ["@grade_exam_id"] = entity.grade_exam_id,
                ["@grade_percent"] = entity.grade_percent,
            };
            return db.ExecuteStored("StudentGradesAdd", param);
        }
    }
}
