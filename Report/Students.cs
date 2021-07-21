using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
namespace Report
{
    public class Students
    {
        public int Id { get; set; }
        [Display(Name="Öğrenci İsmi")]
        public string StudentName { get; set; }
        [Display(Name = "Öğrenci Soyismi")]
        public string StudentSurname { get; set; }
        [Display(Name = "Öğrenci Sınıfı")]
        public int Class { get; set; }

        public DateTime GraduationDate { get; set; }
    }
}
