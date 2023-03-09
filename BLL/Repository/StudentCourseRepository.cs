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
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public StudentCourseRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public List<StudentCourse> GetAll()
        {
            dataTable = db.SelectAllStored("StudentCourseAll");
            List<StudentCourse> entitys = MapDataTableToStudentCourse(dataTable);
            return entitys;
        }
        public int Insert(StudentCourse entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_id"] = entity.stu_id,
                ["@course_id"] = entity.course_id
            };
            return db.ExecuteStored("StudentCourseAdd", param);
        }
        public List<StudentCourse> MapDataTableToStudentCourse(DataTable dataTable)
        {
            List<StudentCourse> entitys = new List<StudentCourse>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToStudentCourse(dataRow));
            }
            return entitys;
        }
        public StudentCourse MapDataRowToStudentCourse(DataRow dataRow)
        {
            StudentCourse entity = new StudentCourse();
            entity.stu_id = dataRow[0].ToString();
            entity.course_id = dataRow[1].ToString();
            return entity;
        }
    }
}
