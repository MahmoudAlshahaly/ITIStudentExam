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
    public class InstructorRepository : IInstructorRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public InstructorRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Instructor entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_id"] = entity.instru_id,
                ["@instru_name"] = entity.instru_name,
                ["@instru_password"] = entity.instru_password,
            };
            return db.ExecuteStored("InstructorEdit", param);
        }

        public List<Instructor> GetAll()
        {
            dataTable = db.SelectAllStored("InstructorAll");
            List<Instructor> entitys = MapDataTableToInstructors(dataTable);
            return entitys;
        }
        public Instructor GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_id"] = id,
            };
            dataTable = db.SelectStored("InstructorByID", param);
            Instructor entity = MapDataRowToInstructor(dataTable.Rows[0]);
            return entity;
        }
        public Instructor GetByName(string name)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_name"] = name,
            };
            dataTable = db.SelectStored("InstructorByName", param);
            Instructor entity = MapDataRowToInstructor(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("InstructorLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Instructor entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_id"] = entity.instru_id,
                ["@instru_name"] = entity.instru_name,
                ["@instru_password"] = entity.instru_password,

            };
            return db.ExecuteStored("InstructorAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("InstructorRemoveAll", null);
        }
        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_id"] = id,
            };
            return db.ExecuteStored("InstructorRemoveOne", param);
        }
        public List<Instructor> MapDataTableToInstructors(DataTable dataTable)
        {
            List<Instructor> entitys = new List<Instructor>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToInstructor(dataRow));
            }
            return entitys;
        }
        public Instructor MapDataRowToInstructor(DataRow dataRow)
        {
            Instructor entity = new Instructor();
            entity.instru_id = Convert.ToInt32(dataRow[0]);
            entity.instru_name = dataRow[1].ToString();
            entity.instru_password = dataRow[2].ToString();
         
            return entity;
        }

        public Instructor GetByNamePassword(string name, string password)
        {
            param = new Dictionary<string, object>()
            {
                ["@instru_name"] = name,
                ["@instru_password"] = password,
            };
            dataTable = db.SelectStored("InstructorByNamePassword", param);
            Instructor entity = new Instructor();
            try
            {
                entity = MapDataRowToInstructor(dataTable.Rows[0]);
            }
            catch (Exception) { }
            return entity;
        }
    }
}
