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
    public class InstructorCourseRepository : IInstructorCourseRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public InstructorCourseRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public List<InstructorCourse> GetAll()
        {
            dataTable = db.SelectAllStored("InstructorCourseAll");
            List<InstructorCourse> entitys = MapDataTableToInstructorCourse(dataTable);
            return entitys;
        }
        public int Insert(InstructorCourse entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_id"] = entity.instru_id,
                ["@course_id"] = entity.course_id
            };
            return db.ExecuteStored("InstructorCourseAdd", param);
        }
        public List<InstructorCourse> MapDataTableToInstructorCourse(DataTable dataTable)
        {
            List<InstructorCourse> entitys = new List<InstructorCourse>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToInstructorCourse(dataRow));
            }
            return entitys;
        }
        public InstructorCourse MapDataRowToInstructorCourse(DataRow dataRow)
        {
            InstructorCourse entity = new InstructorCourse();
            entity.instru_id = dataRow[0].ToString();
            entity.course_id = dataRow[1].ToString();
            return entity;
        }
    }
}
