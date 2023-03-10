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
    public class ExamRepository : IExamRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public ExamRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
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
        public int Edit(Exam entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@exam_id"] = entity.exam_id,
                ["@exam_name"] = entity.exam_name,
            };
            return db.ExecuteStored("ExamEdit", param);
        }

        public List<Exam> GetAll()
        {
            dataTable = db.SelectAllStored("ExamAll");
            List<Exam> entitys = MapDataTableToExams(dataTable);
            return entitys;
        }
        public Exam GetById(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@exam_id"] = id,
            };
            dataTable = db.SelectStored("ExamByID", param);
            Exam entity = MapDataRowToExam(dataTable.Rows[0]);
            return entity;
        }
        public Exam GetByName(string name)
        {
            param = new Dictionary<string, object>()
            {
                ["@exam_name"] = name,
            };
            dataTable = db.SelectStored("ExamByName", param);
            Exam entity = MapDataRowToExam(dataTable.Rows[0]);
            return entity;
        }
        public int GetIDLast()
        {
            dataTable = db.SelectAllStored("ExamLast");
            int ID = Convert.ToInt32(dataTable.Rows[0][0]);
            return ID;
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
        public int RemoveAll()
        {
            return db.ExecuteStored("ExamRemoveAll", null);
        }
        public int RemoveOne(int id)
        {
            param = new Dictionary<string, object>()
            {
                ["@exam_id"] = id,
            };
            return db.ExecuteStored("ExamRemoveOne", param);
        }
        public List<Exam> MapDataTableToExams(DataTable dataTable)
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
            entity.exam_name = dataRow[1].ToString();
         
            return entity;
        }
    }
}
