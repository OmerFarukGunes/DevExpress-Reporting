using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Print : DevExpress.XtraEditors.XtraForm
    {
        public Print()
        {
            InitializeComponent();
        }
        public void PrintReport(Students student, List<Lessons> lessons)
        {
            ReportStudents report = new ReportStudents();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
                report.InitData(student.StudentName, student.StudentSurname, student.Class,lessons);
                documentViewer2.DocumentSource = report;
                report.CreateDocument();
            }
        }
    }
}