using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
  public  class SqlDbHelper
    {
        private SqlConnection sqlConnection;
        public SqlDbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

       public int ExecuteCommand(string commandText, Dictionary<string,object> parameters)
        {
            SqlCommand sqlCommand = createCommand(commandText, parameters);
            sqlCommand.Connection.Open();
            var affectedRowsCount = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return affectedRowsCount;

        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            addParametersToCommand(sqlCommand,parameters);
            return sqlCommand;
        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }


    }
}
