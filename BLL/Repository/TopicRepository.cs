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
    public class TopicRepository : ITopicRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public TopicRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Topic entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@topic_id"] = entity.topic_id,
                ["@topic_name"] = entity.topic_name,
                ["@topic_course_id"] = entity.topic_course_id,
            };
            return db.ExecuteStored("TopicEdit", param);
        }

        public List<Topic> GetAll()
        {
            dataTable = db.SelectAllStored("TopicAll");
            List<Topic> entitys = MapDataTableToTopic(dataTable);
            return entitys;
        }
        public Topic GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@topic_id"] = id,
            };
            dataTable = db.SelectStored("TopicByID", param);
            Topic entity = MapDataRowToTopic(dataTable.Rows[0]);
            return entity;
        }
        public Topic GetByName(string name)
        {
            param = new Dictionary<string, object>()
            {
                ["@topic_name"] = name,
            };
            dataTable = db.SelectStored("TopicByName", param);
            Topic entity = MapDataRowToTopic(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("TopicLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Topic entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@topic_id"] = entity.topic_id,
                ["@topic_name"] = entity.topic_name,
                ["@topic_course_id"] = entity.topic_course_id,

            };
            return db.ExecuteStored("TopicAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("TopicRemoveAll", null);
        }

        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@topic_id"] = id,
            };
            return db.ExecuteStored("TopicRemoveOne", param);
        }
        public List<Topic> MapDataTableToTopic(DataTable dataTable)
        {
            List<Topic> entitys = new List<Topic>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToTopic(dataRow));
            }
            return entitys;
        }
        public Topic MapDataRowToTopic(DataRow dataRow)
        {
            Topic entity = new Topic();
            entity.topic_id = Convert.ToInt32(dataRow[0]);
            entity.topic_name = dataRow[1].ToString();
            try
            {
            entity.topic_course_id = dataRow[2].ToString();
            }
            catch (Exception) { }
            return entity;
        }
    }
}
