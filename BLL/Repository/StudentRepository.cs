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
    public class StudentRepository : IStudentRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public StudentRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Student entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_id"] = entity.stu_id,
                ["@stu_name"] = entity.stu_name,
                ["@stu_dept_id"] = entity.stu_dept_id,
                ["@stu_password"] = entity.stu_password,
            };
            return db.ExecuteStored("StudentEdit", param);
        }

        public List<Student> GetAll()
        {
            dataTable = db.SelectAllStored("StudentAll");
            List<Student> entitys = MapDataTableToStudent(dataTable);
            return entitys;
        }
        public Student GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_id"] = id,
            };
            dataTable = db.SelectStored("StudentByID", param);
            Student entity = MapDataRowToStudent(dataTable.Rows[0]);
            return entity;
        }
        public Student GetByName(string name)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_name"] = name,
            };
            dataTable = db.SelectStored("StudentByName", param);
            Student entity = MapDataRowToStudent(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("StudentLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Student entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_id"] = entity.stu_id,
                ["@stu_name"] = entity.stu_name,
                ["@stu_dept_id"] = entity.stu_dept_id,
                ["@stu_password"] = entity.stu_password,

            };
            return db.ExecuteStored("StudentAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("StudentRemoveAll", null);
        }

        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_id"] = id,
            };
            return db.ExecuteStored("StudentRemoveOne", param);
        }
        public List<Student> MapDataTableToStudent(DataTable dataTable)
        {
            List<Student> entitys = new List<Student>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToStudent(dataRow));
            }
            return entitys;
        }
        public Student MapDataRowToStudent(DataRow dataRow)
        {
            Student entity = new Student();
            entity.stu_id = Convert.ToInt32(dataRow[0]);
            entity.stu_name = dataRow[1].ToString();
            try
            {
            entity.stu_dept_id = dataRow[2].ToString();
            entity.stu_password = dataRow[3].ToString();
            }
            catch (Exception) { }
            return entity;
        }

        public Student GetByNamePassword(string name, string password)
        {
            param = new Dictionary<string, object>()
            {
                ["@stu_name"] = name,
                ["@stu_password"] = password,
            };
            dataTable = db.SelectStored("StudentByNamePassword", param);
            Student entity = new Student();
            try
            {
                entity = MapDataRowToStudent(dataTable.Rows[0]);
            }
            catch (Exception) { }
            return entity;
        }
    }
}
