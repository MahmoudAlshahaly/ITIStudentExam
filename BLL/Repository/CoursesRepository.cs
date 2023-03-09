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
    public class CoursesRepository : ICoursesRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public CoursesRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Course entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@course_id"] = entity.course_id,
                ["@course_name"] = entity.course_name,
            };
            return db.ExecuteStored("CourseEdit", param);
        }

        public List<Course> GetAll()
        {
            dataTable = db.SelectAllStored("CourseAll");
            List<Course> entitys = MapDataTableToCourses(dataTable);
            return entitys;
        }
        public Course GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@course_id"] = id,
            };
            dataTable = db.SelectStored("CourseByID", param);
            Course entity = MapDataRowToCourse(dataTable.Rows[0]);
            return entity;
        }
        public Course GetByName(string name)
        {
            param = new Dictionary<string, object>()
            {
                ["@course_name"] = name,
            };
            dataTable = db.SelectStored("CourseByName", param);
            Course entity = MapDataRowToCourse(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("CourseLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Course entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@course_id"] = entity.course_id,
                ["@course_name"] = entity.course_name,
            };  
            return db.ExecuteStored("CourseAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("CourseRemoveAll", null);
        }

        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@course_id"] = id,

            };
            return db.ExecuteStored("CourseRemoveOne", param);
        }
        public List<Course> MapDataTableToCourses(DataTable dataTable)
        {
            List<Course> entitys = new List<Course>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToCourse(dataRow));
            }
            return entitys;
        }
        public Course MapDataRowToCourse(DataRow dataRow)
        {
            Course entity = new Course();
            entity.course_id = Convert.ToInt32(dataRow[0]);
            entity.course_name = dataRow[1].ToString();
            return entity;
        }
    }
}
