using Newtonsoft.Json;
using System;
using System.Data;

namespace StudentInfoWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            StudentInfoService.StudentInfoServiceClient studentInfo = new StudentInfoService.StudentInfoServiceClient();
            string jsonresult = studentInfo.GetStudentInfoByID(int.Parse(txtStudentID.Text));

            DataTable dtStudentInfo = (DataTable)JsonConvert.DeserializeObject(jsonresult, (typeof(DataTable)));

            if (dtStudentInfo.Rows.Count > 0)
            {
                lblResult.Text = "Student Details are as follows";
                lblStudentID.Text = dtStudentInfo.Rows[0]["StudentID"].ToString();
                lblName.Text = dtStudentInfo.Rows[0]["Name"].ToString();
                lblGender.Text = dtStudentInfo.Rows[0]["Gender"].ToString();
                lblCity.Text = dtStudentInfo.Rows[0]["City"].ToString();
                divStudentInfo.Visible = true;
            }
            else
            {
                lblResult.Text = "No Student Information available for this Student ID";
                divStudentInfo.Visible = false;
            }
        }
    }
}