using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoService
{
    public class StudentInfoService : IStudentInfoService
    {
        public string GetStudentInfoByID(int studentID)
        {
            DataTable dtStudentInfo = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentInfoDBConnection"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Students WHERE StudentID = @StudentID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@StudentID", studentID));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtStudentInfo);

                System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in dtStudentInfo.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dtStudentInfo.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                return serializer.Serialize(rows);
            }
        }
    }
}
