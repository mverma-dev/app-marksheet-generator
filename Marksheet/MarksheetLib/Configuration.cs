using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksheetLib
{
    public class Configuration
    {
        public string ExcelFilePath { get; set; }
        public string LogoFilePath { get; set; }
        public string ClassSheetNamePrefix { get; set; }
        public string InitializeSheetNamePrefix { get; set; }
        public int InitializeSheet_ColumnIndex_Class { get; set; }
        public int InitializeSheet_ColumnIndex_Subjects { get; set; }
        public int InitializeSheet_ColumnIndex_Group { get; set; }
    }
}
