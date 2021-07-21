
namespace Report
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtFromStudent = new System.Windows.Forms.NumericUpDown();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLessonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPassed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.StudentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.numericChartRangeControlClient2 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGraduationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtFromStudent);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1150, 765);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtFromStudent
            // 
            this.dtFromStudent.Location = new System.Drawing.Point(132, 12);
            this.dtFromStudent.Name = "dtFromStudent";
            this.dtFromStudent.Size = new System.Drawing.Size(186, 22);
            this.dtFromStudent.TabIndex = 10;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(132, 731);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(1006, 22);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lessonsBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1126, 655);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colStudentId,
            this.colLessonName,
            this.colGrade,
            this.colIsPassed});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 94;
            // 
            // colStudentId
            // 
            this.colStudentId.FieldName = "StudentId";
            this.colStudentId.MinWidth = 25;
            this.colStudentId.Name = "colStudentId";
            this.colStudentId.Visible = true;
            this.colStudentId.VisibleIndex = 1;
            this.colStudentId.Width = 94;
            // 
            // colLessonName
            // 
            this.colLessonName.FieldName = "LessonName";
            this.colLessonName.MinWidth = 25;
            this.colLessonName.Name = "colLessonName";
            this.colLessonName.Visible = true;
            this.colLessonName.VisibleIndex = 2;
            this.colLessonName.Width = 94;
            // 
            // colGrade
            // 
            this.colGrade.FieldName = "Grade";
            this.colGrade.MinWidth = 25;
            this.colGrade.Name = "colGrade";
            this.colGrade.Visible = true;
            this.colGrade.VisibleIndex = 3;
            this.colGrade.Width = 94;
            // 
            // colIsPassed
            // 
            this.colIsPassed.FieldName = "IsPassed";
            this.colIsPassed.MinWidth = 25;
            this.colIsPassed.Name = "colIsPassed";
            this.colIsPassed.OptionsColumn.ReadOnly = true;
            this.colIsPassed.Visible = true;
            this.colIsPassed.VisibleIndex = 4;
            this.colIsPassed.Width = 94;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(999, 700);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(139, 27);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Data Yükle";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(864, 700);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 27);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Çıktı Al";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.StudentId,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1150, 765);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLoad;
            this.layoutControlItem2.Location = new System.Drawing.Point(987, 688);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(143, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(143, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(143, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1130, 659);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(852, 688);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(135, 31);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(135, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(135, 31);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 688);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(852, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(720, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(410, 29);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 719);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1130, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 16);
            // 
            // StudentId
            // 
            this.StudentId.Control = this.dtFromStudent;
            this.StudentId.Location = new System.Drawing.Point(0, 0);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(310, 29);
            this.StudentId.TextSize = new System.Drawing.Size(108, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(310, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(410, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 16);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colStudentName
            // 
            this.colStudentName.FieldName = "StudentName";
            this.colStudentName.MinWidth = 25;
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.Visible = true;
            this.colStudentName.VisibleIndex = 1;
            this.colStudentName.Width = 94;
            // 
            // colStudentSurname
            // 
            this.colStudentSurname.FieldName = "StudentSurname";
            this.colStudentSurname.MinWidth = 25;
            this.colStudentSurname.Name = "colStudentSurname";
            this.colStudentSurname.Visible = true;
            this.colStudentSurname.VisibleIndex = 2;
            this.colStudentSurname.Width = 94;
            // 
            // colClass
            // 
            this.colClass.FieldName = "Class";
            this.colClass.MinWidth = 25;
            this.colClass.Name = "colClass";
            this.colClass.Visible = true;
            this.colClass.VisibleIndex = 3;
            this.colClass.Width = 94;
            // 
            // colGraduationDate
            // 
            this.colGraduationDate.FieldName = "GraduationDate";
            this.colGraduationDate.MinWidth = 25;
            this.colGraduationDate.Name = "colGraduationDate";
            this.colGraduationDate.Visible = true;
            this.colGraduationDate.VisibleIndex = 4;
            this.colGraduationDate.Width = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 765);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karne";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFromStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.NumericUpDown dtFromStudent;
        private DevExpress.XtraLayout.LayoutControlItem StudentId;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentId;
        private DevExpress.XtraGrid.Columns.GridColumn colLessonName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPassed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colGraduationDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

