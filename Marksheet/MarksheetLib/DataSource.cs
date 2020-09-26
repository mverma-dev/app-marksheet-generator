using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace MarksheetLib
{
    public class DataSource : IDisposable
    {
        public const string InitializeSheetName = "Initialize";
        public const string ClassSheetNamePrefix = "Class";

        public Application Application { get; set; }
        public Workbook Workbook { get; set; }
        public Worksheet Worksheet { get; set; }
        public Range Range { get; set; }

        public DataSource()
        {
            Application = Application == null ? new Application() : Application;
            Workbook = Workbook == null ? Application.Workbooks.Open(@"C:\Marksheet\MarksCopy.xlsx") : Workbook;
        }

        public List<string> GetClasses()
        {
            List<string> classList = new List<string>();
            Worksheet = Workbook.Worksheets[InitializeSheetName];
            if (Worksheet == null)
            {
                return classList;
            }

            Range = Worksheet.UsedRange;

            int rowCount = Range.Rows.Count;

            for (int row = 2; row < rowCount; row++)
            {
                // class name is in column 1
                var cellValue = Range.Cells[row, 1].Value2;
                if (cellValue == null)
                {
                    continue;
                }
                string @class = Convert.ToString(cellValue);
                if (!classList.Contains(@class))
                {
                    classList.Add(@class);
                }
            }
            return classList;
        }

        public List<SubjectMarks> GetSubjectsForClass(string className)
        {
            Worksheet = Workbook.Worksheets[InitializeSheetName];
            if (Worksheet == null)
            {
                return new List<SubjectMarks>();
            }

            Range = Worksheet.UsedRange;

            int rowCount = Range.Rows.Count;

            string @class = string.Empty;
            List<SubjectMarks> subjectMarks = new List<SubjectMarks>();
            for (int row = 2; row < rowCount; row++)
            {
                // columnn 1 for class name
                var cellValue = Range.Cells[row, 1].Value2;
                if (cellValue != null)
                {
                    @class = Convert.ToString(cellValue);
                }

                if (@class != className)
                {
                    continue;
                }

                // column 2 for Subject name
                var subject = Range.Cells[row, 2].Value2;
                if (subject == null)
                {
                    continue;
                }

                var subjectMark = new SubjectMarks
                {
                    Subject = Convert.ToString(subject)
                };
                subjectMarks.Add(subjectMark);
            }
            return subjectMarks;
        }

        public List<string> GetRollNumbers(string className)
        {
            List<string> rollNumbers = new List<string>() { string.Empty };
            Worksheet = Workbook.Worksheets[$"{ClassSheetNamePrefix} {className}"];
            if (Worksheet == null)
            {
                return rollNumbers;
            }

            Range = Worksheet.UsedRange;

            int rowCount = Range.Rows.Count;

            for (int row = 3; row < rowCount; row++)
            {
                // columnn 2 for roll numbers
                var cellValue = Range.Cells[row, 2].Value2;
                if (cellValue != null)
                {
                    rollNumbers.Add(Convert.ToString(cellValue));
                }
            }
            return rollNumbers;
        }

        public List<string> GetStudentNames(string className)
        {
            List<string> studentList = new List<string>() { string.Empty };
            Worksheet = Workbook.Worksheets[$"{ClassSheetNamePrefix} {className}"];
            if (Worksheet == null)
            {
                return studentList;
            }

            Range = Worksheet.UsedRange;

            int rowCount = Range.Rows.Count;

            for (int row = 3; row < rowCount; row++)
            {
                // columnn 3 for student name
                var cellValue = Range.Cells[row, 3].Value2;
                if (cellValue != null)
                {
                    studentList.Add(Convert.ToString(cellValue));
                }
            }
            return studentList;
        }

        public string GetStudentNameByRollNumber(string className, string rollNumber)
        {
            Worksheet = Workbook.Worksheets[$"{ClassSheetNamePrefix} {className}"];
            if (Worksheet == null)
            {
                return string.Empty;
            }
            Range = Worksheet.UsedRange;
            int rowCount = Range.Rows.Count;
            int columnCount = Range.Columns.Count;

            int row = 0;
            // get row index for roll number
            for (row = 3; row <= rowCount; row++)
            {
                // column 2 for roll number
                var cellValue = Range.Cells[row, 2].Value2;
                if (cellValue != null)
                {
                    if (Convert.ToString(cellValue) == rollNumber)
                    {
                        break;
                    }
                }
            }

            // column 3 for student name
            var studentName = Range.Cells[row, 3].Value2;
            if (studentName == null)
            {
                return string.Empty;
            }

            return Convert.ToString(studentName);
        }

        public List<SubjectMarks> GetStudentMarksByRollNumber(string className, string rollNumber)
        {
            Worksheet = Workbook.Worksheets[$"{ClassSheetNamePrefix} {className}"];
            if (Worksheet == null)
            {
                return new List<SubjectMarks>();
            }
            Range = Worksheet.UsedRange;
            int rowCount = Range.Rows.Count;
            int columnCount = Range.Columns.Count;

            int row = 0;
            // get row index for roll number
            for (row = 3; row <= rowCount; row++)
            {
                // column 2 for roll number
                var cellValue = Range.Cells[row, 2].Value2;
                if (cellValue != null)
                {
                    if (Convert.ToString(cellValue) == rollNumber)
                    {
                        break;
                    }
                }
            }

            List<SubjectMarks> subjectMarksList = new List<SubjectMarks>();
            // get subject columns, subject starts from column 4
            for (int column = 4; column <= columnCount; column++)
            {
                var subjectName = Range.Cells[1, column].Value2;
                if (subjectName == null)
                {
                    continue;
                }

                var marks = Range.Cells[row, column].Value2;
                if (marks == null)
                {
                    continue;
                }

                var subjectMarks = new SubjectMarks
                {
                    Subject = Convert.ToString(subjectName),
                    Marks = marks.ToString()
                };

                //var subjectMarks = new SubjectMarks
                //{
                //    Subject = Convert.ToString(subjectName),
                //    Marks = Convert.ToDecimal(Range.Cells[row, column].Value2)
                //};
                subjectMarksList.Add(subjectMarks);
            }
            return subjectMarksList;
        }

        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(Range);
            Marshal.ReleaseComObject(Worksheet);
            Workbook?.Close();
            Marshal.ReleaseComObject(Workbook);
            Application?.Quit();
            Marshal.ReleaseComObject(Application);
        }

    }
}
