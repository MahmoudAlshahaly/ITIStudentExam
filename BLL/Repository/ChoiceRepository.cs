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
    public class ChoiceRepository : IChoiceRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public ChoiceRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Choice entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@choise_id"] = entity.choise_id,
                ["@choise_answer_first"] = entity.choise_answer_first,
                ["@choise_answer_second"] = entity.choise_answer_second,
                ["@choise_answer_third"] = entity.choise_answer_third,
                ["@choise_answer_fourth"] = entity.choise_answer_fourth,
            };
            return db.ExecuteStored("ChoiceEdit", param);
        }

        public List<Choice> GetAll()
        {
            dataTable = db.SelectAllStored("ChoiceAll");
            List<Choice> entitys = MapDataTableToChoices(dataTable);
            return entitys;
        }
        public Choice GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@choice_id"] = id,
            };
            dataTable = db.SelectStored("ChoiceByID", param);
            Choice entity = MapDataRowToChoice(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("ChoiceLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Choice entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@choise_id"] = entity.choise_id,
                ["@choise_answer_first"] = entity.choise_answer_first,
                ["@choise_answer_second"] = entity.choise_answer_second,
                ["@choise_answer_third"] = entity.choise_answer_third,
                ["@choise_answer_fourth"] = entity.choise_answer_fourth,
            };
            return db.ExecuteStored("ChoiceAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("ChoiceRemoveAll", null);
        }
        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@choice_id"] = id,
            };
            return db.ExecuteStored("ChoiceRemoveOne", param);
        }
        public List<Choice> MapDataTableToChoices(DataTable dataTable)
        {
            List<Choice> entitys = new List<Choice>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToChoice(dataRow));
            }
            return entitys;
        }
        public Choice MapDataRowToChoice(DataRow dataRow)
        {
            Choice entity = new Choice();
            entity.choise_id = Convert.ToInt32(dataRow[0]);
            entity.choise_answer_first = dataRow[1].ToString();
            entity.choise_answer_second = dataRow[2].ToString();
            entity.choise_answer_third = dataRow[3].ToString();
            entity.choise_answer_fourth = dataRow[4].ToString();         
            return entity;
        }
    }
}
