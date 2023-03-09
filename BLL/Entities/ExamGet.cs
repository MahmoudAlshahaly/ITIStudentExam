using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
   public class ExamGet
    {
        public int exam_id { get; set; }
        public int question_id { get; set; }
        public string question_type { get; set; }
        public string question_title { get; set; }
        public string question_right_answer { get; set; }
        public string choise_answer_first { get; set; }
        public string choise_answer_second { get; set; }
        public string choise_answer_third { get; set; }
        public string choise_answer_fourth { get; set; }

    }
}
