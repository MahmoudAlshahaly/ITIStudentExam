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
    public class StudentAnswerRepository : IStudentAnswerRepository
    {
        private DBHelper db;
        private DataTable dataTable;
        Dictionary<string, object> param;

        public StudentAnswerRepository(DBHelper db)
        {
            this.db = db;
            dataTable = new DataTable();
        }
        public List<StudentAnswer> GetAll()
        {
            dataTable = db.SelectAllStored("StudentAnswerAll");
            List<StudentAnswer> entitys = MapDataTableToStudentAnswer(dataTable);
            return entitys;
        }
        public List<StudentAnswer> MapDataTableToStudentAnswer(DataTable dataTable)
        {
            List<StudentAnswer> entitys = new List<StudentAnswer>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                entitys.Add(MapDataRowToStudentAnswer(dataRow));
            }
            return entitys;
        }
        public StudentAnswer MapDataRowToStudentAnswer(DataRow dataRow)
        {
            StudentAnswer entity = new StudentAnswer();
            entity.answer_id = Convert.ToInt32(dataRow[0]);
            entity.answer_exam_id = dataRow[1].ToString();
            entity.answer_stu_id = dataRow[2].ToString();
            entity.answer_question_id = dataRow[3].ToString();
            entity.answer_selected = dataRow[4].ToString();
           
            return entity;
        }

        public int Insert(StudentAnswer entity)
        {
            param = new Dictionary<string, object>()
            {
                ["@answer_exam_id"] = entity.answer_exam_id,
                ["@answer_stu_id"] = entity.answer_stu_id,
                ["@answer_question_id"] = entity.answer_question_id,
                ["@answer_selected"] = entity.answer_selected,
            };
            return db.ExecuteStored("StudentAnswerAdd", param);
        }
    }
}
