using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
   public class Question
    {
        public int question_id { get; set; }
        public string question_type { get; set; }
        public string question_title { get; set; }
        public string question_right_answer { get; set; }
        public string question_body_answer_id { get; set; }
        public string questions_course_id { get; set; }
        
    }
}
