using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MEBank
{
    public partial class Main : Form
    {
        public Login loginScreen;
        public OpenAccount oaScreen;
        public Profile profileScreen;
        public Register registerScreen;

        private String ConnectionStringSettings;
        public String AccountType;

        public Main()
        {
            InitializeComponent();
            GetConnectionStrings();

            loginScreen = new Login();
            loginScreen.Dock = DockStyle.Fill;
            this.Controls.Add(loginScreen);
            loginScreen.Visible = true;
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public SqlConnection GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    ConnectionStringSettings = cs.ConnectionString;
                }
            }
            SqlConnection conn = new SqlConnection(ConnectionStringSettings);
            return conn;
        }

        public Dictionary<string, string> ExecuteSP(String SPName, List<SqlParameter> param, String process, String mode, List<String> dataList)
        {
            var connection = new SqlConnection(ConnectionStringSettings);
            Dictionary<string, string> returnData = new Dictionary<string, string>();
            String data = "";
            try
            {
                    connection.Open();
                    using (var command = new SqlCommand(SPName, connection))
                    {
                        command.Notification = null;
                        command.CommandType = CommandType.StoredProcedure;
                        foreach (var item in param)
                        {
                            command.Parameters.Add(new SqlParameter(item.ParameterName, item.SqlDbType) { Size = item.Size, Value = item.SqlValue, Direction = item.Direction });
                        }

                        SqlParameter Result = new SqlParameter("@Result", SqlDbType.Int);
                        Result.Direction = ParameterDirection.Output;
                        command.Parameters.Add(Result);

                        SqlParameter ErrorMsg = new SqlParameter("@ErrorMsg", SqlDbType.VarChar, 1000);
                        ErrorMsg.Direction = ParameterDirection.Output;
                        command.Parameters.Add(ErrorMsg);

                        if (mode=="Query")
                        {
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                //if (reader["Result"].Equals(-1))
                                //{
                                //    throw new Exception(reader["ErrorMsg"] + " : ExecuteSP");
                                //}

                                foreach (var item in dataList)
                                {
                                    data = Convert.ToString(reader[item]);
                                    returnData.Add(data, item);
                                }
                            }
                        return returnData;
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                            int retVal = Convert.ToInt32(command.Parameters["@Result"].Value);
                            if (retVal == -1)
                            {
                                var errMsg = Convert.ToString(command.Parameters["@ErrorMsg"].Value);
                                throw new Exception(errMsg);
                            }
                            foreach (var item in dataList)
                            {
                                data = Convert.ToString(command.Parameters[item].Value);
                                //returnData[item] = data;
                                returnData.Add(item, data);
                            }
                            return returnData;
                        }
                    }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " : ExecuteSP");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
