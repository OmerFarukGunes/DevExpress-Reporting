using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Form1 :  XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtFromStudent != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select l.Id, l.StudentId, l.LessonName ,l.Grade" + " from Lesson l left join Student s on s.Id=l.StudentId" +
                         $" where l.StudentId = '{dtFromStudent.Value}'";
                    string obj = $" select s.* from Student s where s.Id = '{dtFromStudent.Value}'";
                    List<Lessons> list = db.Query<Lessons>(query, CommandType.Text).ToList();
                    Students Student = db.Query<Students>(obj, CommandType.Text).First();
                    using (Print prnt = new Print())
                    {
                        prnt.PrintReport(Student, list);
                        prnt.ShowDialog();
                    }
                }
            }
             
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using(IDbConnection db= new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select l.Id, l.StudentId, l.LessonName ,l.Grade" + " from Lesson l left join Student s on s.Id=l.StudentId" +
                     $" where l.StudentId = '{dtFromStudent.Value}'";
                lessonsBindingSource.DataSource = db.Query<Lessons>(query, CommandType.Text);
            }
        }
    }
}
