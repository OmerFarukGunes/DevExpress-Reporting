using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    public class Lessons
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        [Display(Name = "Ders Adı")]
        public string LessonName { get; set; }
        [Display(Name = "Ders Notu")]
        public long Grade { get; set; } 
        public string IsPassed
        {
            get
            {
                return Grade>50?"Geçti":"Kaldı";
            }
        }
    }
}
