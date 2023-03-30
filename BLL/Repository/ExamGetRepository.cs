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
    public class ExamGetRepository : IExamGetRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public ExamGetRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public List<ExamGet> GetByID(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@exam_id"] = id,
            };
            dataTable = db.SelectStored("ExamGetByID", param);
            List<ExamGet> entitys = MapDataTableToExamGet(dataTable);
            return entitys;
        }
        public List<ExamGet> MapDataTableToExamGet(DataTable dataTable)
        {
            List<ExamGet> entitys = new List<ExamGet>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToExamGet(dataRow));
            }
            return entitys;
        }
        public ExamGet MapDataRowToExamGet(DataRow dataRow)
        {
            ExamGet entity = new ExamGet();
            entity.exam_id = Convert.ToInt32(dataRow[0]);
            entity.question_id = Convert.ToInt32(dataRow[1]);
            entity.question_type = dataRow[2].ToString();
            entity.question_title = dataRow[3].ToString();
            entity.question_right_answer = dataRow[4].ToString();
            entity.choise_answer_first = dataRow[5].ToString();
            entity.choise_answer_second = dataRow[6].ToString();
            try
            {
            entity.choise_answer_third = dataRow[7].ToString();
            entity.choise_answer_fourth = dataRow[8].ToString();
            }
            catch (Exception) { }
            return entity;
        }

        public int GenerateExam(GenerateExam entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@course_id"] = entity.course_id,
                ["@exam_id"] = entity.exam_id,
                ["@num_question_tf"] = entity.num_question_tf,
                ["@num_question_mcq"] = entity.num_question_mcq,
            };
            return db.ExecuteStored("GenerateExam", param);
        }

        public List<Exam> GetAll()
        {
            dataTable = db.SelectAllStored("ExamAll");
            List<Exam> entitys = MapDataTableToExam(dataTable);
            return entitys;
        }

        public List<Exam> MapDataTableToExam(DataTable dataTable)
        {
            List<Exam> entitys = new List<Exam>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToExam(dataRow));
            }
            return entitys;
        }
        public Exam MapDataRowToExam(DataRow dataRow)
        {
            Exam entity = new Exam();
            entity.exam_id = Convert.ToInt32(dataRow[0]);
            entity.exam_name = Convert.ToString(dataRow[1]);
 
            return entity;
        }

        public int Insert(Exam entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@exam_id"] = entity.exam_id,
                ["@exam_name"] = entity.exam_name,
            };
            return db.ExecuteStored("ExamAdd", param);
        }
    }
}
