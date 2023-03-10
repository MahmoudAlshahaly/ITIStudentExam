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
    public class QuestionRepository : IQuestionRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public QuestionRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public int Edit(Question entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@question_id"] = entity.question_id,
                ["@question_type"] = entity.question_type,
                ["@question_title"] = entity.question_title,
                ["@question_right_answer"] = entity.question_right_answer,
                ["@question_body_answer_id"] = entity.question_body_answer_id,
                ["@questions_course_id"] = entity.questions_course_id,
            };
            return db.ExecuteStored("QuestionEdit", param);
        }

        public List<Question> GetAll()
        {
            dataTable = db.SelectAllStored("QuestionAll");
            List<Question> entitys = MapDataTableToQuestions(dataTable);
            return entitys;
        }
        public Question GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@question_id"] = id,
            };
            dataTable = db.SelectStored("QuestionByID", param);
            Question entity = MapDataRowToQuestion(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("QuestionLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
        }
        public int Insert(Question entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@question_id"] = entity.question_id,
                ["@question_type"] = entity.question_type,
                ["@question_title"] = entity.question_title,
                ["@question_right_answer"] = entity.question_right_answer,
                ["@question_body_answer_id"] = entity.question_body_answer_id,
                ["@questions_course_id"] = entity.questions_course_id,
            };
            return db.ExecuteStored("QuestionAdd", param);
        }
        public int RemoveAll()
        {
            return db.ExecuteStored("QuestionRemoveAll", null);
        }
        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@question_id"] = id,
            };
            return db.ExecuteStored("QuestionRemoveOne", param);
        }
        public List<Question> MapDataTableToQuestions(DataTable dataTable)
        {
            List<Question> entitys = new List<Question>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToQuestion(dataRow));
            }
            return entitys;
        }
        public Question MapDataRowToQuestion(DataRow dataRow)
        {
            Question entity = new Question();
            entity.question_id = Convert.ToInt32(dataRow[0]);
            entity.question_type = dataRow[1].ToString();
            entity.question_title = dataRow[2].ToString();
            entity.question_right_answer = dataRow[3].ToString();
            entity.question_body_answer_id = dataRow[4].ToString();
            entity.questions_course_id = dataRow[5].ToString();
         
            return entity;
        }
    }
}
