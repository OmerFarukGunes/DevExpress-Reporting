using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
namespace Report
{
    public partial class ReportStudents : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportStudents()
        {
            InitializeComponent();
        }

        long total = 0;
        public void InitData(string studentName,string studentSurname,int Class,List<Lessons>lessons)
        {
            StudentName.Value = studentName;
            StudentSurname.Value = studentSurname;
            StudentClass.Value = Class.ToString();
            GraduationDate.Value = DateTime.Now;
            foreach (var item in lessons)
            {
                total += item.Grade;
            }
            total = total / lessons.Count;
            TotalGrade.Value = total;
            if (total > 80)
                Mesaj.Value = "Üstün Başarından dolayı tebrik ederim";
            else if(total>60)
                Mesaj.Value = "Az daha gayret göstermelisin";
            else
                Mesaj.Value = "Daha yolun çok";
            objectDataSource1.DataSource = lessons;
        }

    }
}
