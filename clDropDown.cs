using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PathLab
{
    public class clsDropDown
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsSelected { get; set; }
    }

    public static class clsGender
    {
        public static DataTable GetGender()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            DataRow drSelect = dt.NewRow();
            drSelect["Text"] = "Select";
            drSelect["Value"] = "";
            dt.Rows.Add(drSelect);
            
            DataRow drMale = dt.NewRow();
            drMale["Text"] = "Male";
            drMale["Value"] = "M";
            dt.Rows.Add(drMale);

            DataRow drFeMale = dt.NewRow();
            drFeMale["Text"] = "FeMale";
            drFeMale["Value"] = "F";
            dt.Rows.Add(drFeMale);
            dt.AcceptChanges();
            return dt;
        }
    }


}
