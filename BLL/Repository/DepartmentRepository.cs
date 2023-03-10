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
    public class DepartmentRepository : IDepartmentRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public DepartmentRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Department entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@dept_id"] = entity.dept_id,
                ["@dept_name"] = entity.dept_name,
            };
            return db.ExecuteStored("DepartmentEdit", param);
        }

        public List<Department> GetAll()
        {
            dataTable = db.SelectAllStored("DepartmentAll");
            List<Department> entitys = MapDataTableToDepartments(dataTable);
            return entitys;
        }
        public Department GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@dept_id"] = id,
            };
            dataTable = db.SelectStored("DepartmentByID", param);
            Department entity = MapDataRowToDepartment(dataTable.Rows[0]);
            return entity;
        }
        public Department GetByName(string name)
        {
            param = new Dictionary<string, object>()
            {
                ["@dept_name"] = name,
            };
            dataTable = db.SelectStored("DepartmentByName", param);
            Department entity = MapDataRowToDepartment(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("DepartmentLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Department entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@dept_id"] = entity.dept_id,
                ["@dept_name"] = entity.dept_name,
            };
            return db.ExecuteStored("DepartmentAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("DepartmentRemoveAll", null);
        }
        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@dept_id"] = id,
            };
            return db.ExecuteStored("DepartmentRemoveOne", param);
        }
        public List<Department> MapDataTableToDepartments(DataTable dataTable)
        {
            List<Department> entitys = new List<Department>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToDepartment(dataRow));
            }
            return entitys;
        }
        public Department MapDataRowToDepartment(DataRow dataRow)
        {
            Department entity = new Department();
            entity.dept_id = Convert.ToInt32(dataRow[0]);
            entity.dept_name = dataRow[1].ToString();
         
            return entity;
        }
    }
}
