using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MarksheetLib;

namespace Marksheet
{
    public partial class frmStudentMarks : Form
    {
        public DataSource DataSource { get; set; }
        public List<SubjectMarks> SubjectMarks { get; set; }

        public frmStudentMarks()
        {
            DataSource = new DataSource();
            SubjectMarks = new List<SubjectMarks>();
            InitializeComponent();
        }

        private void frmStudentMarks_Load(object sender, EventArgs e)
        {
            var classes = DataSource.GetClasses();
            cmbClasses.DataSource = classes;
            cmbClasses.SelectedIndex = 0;
            grdMarks.DataSource = SubjectMarks;
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClass = ((ComboBox)sender).SelectedItem.ToString();
            
            // grid
            SubjectMarks = DataSource.GetSubjectsForClass(selectedClass);
            grdMarks.DataSource = SubjectMarks;

            // roll number
            var rollNumberAutocomplete = new AutoCompleteStringCollection();
            rollNumberAutocomplete.AddRange(DataSource.GetRollNumbers(selectedClass).ToArray());
            txtRollNumber.AutoCompleteCustomSource = rollNumberAutocomplete;

            // student name
            var studentNameAutocomplete = new AutoCompleteStringCollection();
            studentNameAutocomplete.AddRange(DataSource.GetStudentNames(selectedClass).ToArray());
            txtStudentName.AutoCompleteCustomSource = studentNameAutocomplete;
        }

        private void cmbRollNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClass = cmbClasses.SelectedItem.ToString();
            var selectedRollNumber = ((ComboBox)sender).SelectedItem.ToString();

        }

        private void txtRollNumber_TextChanged(object sender, EventArgs e)
        {
            string rollNumber = ((TextBox)sender).Text;
            string className = cmbClasses.SelectedItem.ToString();
            SubjectMarks = DataSource.GetStudentMarksByRollNumber(className, rollNumber);
            if (SubjectMarks?.Any() ?? false)
            {
                grdMarks.DataSource = SubjectMarks;
                txtStudentName.Text = DataSource.GetStudentNameByRollNumber(className, rollNumber);
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var marksheetReportList = new List<MarksheetReport>();

            foreach (var subjectmark in SubjectMarks)
            {
                marksheetReportList.Add(
                new MarksheetReport
                {
                    Class = cmbClasses.SelectedItem.ToString(),
                    Name = txtStudentName.Text,
                    RollNumber = txtRollNumber.Text,
                    Subject = subjectmark.Subject,
                    Marks = subjectmark.Marks
                });
            }

            frmMarksheetReportViewer frmReportViewer = new frmMarksheetReportViewer();
            frmReportViewer.MarksheetReportList = marksheetReportList;
            frmReportViewer.Show();

            //MarksheetDataset dataset = new MarksheetDataset();
            //var dataTable = dataset.Tables[0];
            //dataTable.Rows.Add()
            //string constr = @"Data Source=.\Sql2005;Initial Catalog=Northwind;Integrated Security = true";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("SELECT TOP 20 * FROM Customers"))
            //    {
            //        using (SqlDataAdapter sda = new SqlDataAdapter())
            //        {
            //            cmd.Connection = con;
            //            sda.SelectCommand = cmd;
            //            using (Customers dsCustomers = new Customers())
            //            {
            //                sda.Fill(dsCustomers, "DataTable1");
            //                return dsCustomers;
            //            }
            //        }
            //    }
            //}
        }

        private void btnLoadMarks_Click(object sender, EventArgs e)
        {
            string rollNumber = txtRollNumber.Text;
            string className = cmbClasses.SelectedItem.ToString();
            SubjectMarks = DataSource.GetStudentMarksByRollNumber(className, rollNumber);
            if (SubjectMarks?.Any() ?? false)
            {
                grdMarks.DataSource = SubjectMarks;
                txtStudentName.Text = DataSource.GetStudentNameByRollNumber(className, rollNumber);
            }
        }
    }
}
