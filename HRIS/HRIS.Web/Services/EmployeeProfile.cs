using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HRIS.Web.Services
{
    public class EmployeeProfile : IEmployeeProfile
    {
        private readonly string _connectionString;

        public EmployeeProfile(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        private SqlCommand PrepareCommand(string sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);

            return command;
        }

        public dynamic GetEmployeeProfileData()
        {
            string command = "Select * from Hrms_Company_Employee_Profile";
            using SqlCommand sqlCommand = PrepareCommand(command);

            if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                sqlCommand.Connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            List<SelectListItem> employeeProfileList = new List<SelectListItem>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                employeeProfileList.Add(new SelectListItem { Text = dr["EmployeeName"].ToString(), Value = dr["EmployeeProfileId"].ToString() }); ;
            }

            var data = from value in employeeProfileList select new { value.Text, value.Value };

            return data;
        }
    }
}
