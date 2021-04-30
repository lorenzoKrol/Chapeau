using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ChapeauDAL {
    public abstract class Base {
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        public Base() {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection() {
            if (connection.State == ConnectionState.Closed ||
                connection.State == ConnectionState.Broken) {
                connection.Open();
            }
            return connection;
        }

        private void CloseConnection() {
            connection.Close();
        }

        // For inserting, updating and deleting queries
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters) {
            SqlCommand command = new SqlCommand();

            try {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            finally {
                CloseConnection();
            }
        }

        // For inserting, updating and deleting queries with identity
        protected int ExecuteEditIdentityQuery(string query, params SqlParameter[] sqlParameters) {
            SqlCommand command = new SqlCommand();
            int identity;

            try {
                command.Connection = OpenConnection();
                command.CommandText = $"{query}; SELECT CAST(scope_identity() AS INT)";
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                identity = (int)command.ExecuteScalar();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            finally {
                CloseConnection();
            }

            return identity;
        }

        // For inserting, updating and deleting queries with transaction
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction) {
            SqlCommand command = new SqlCommand(query, connection, sqlTransaction);

            try {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        // For select queries
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters) {
            SqlCommand command = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataTable dataTable;

            try {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();

                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                return null;
                throw;
            }
            finally {
                CloseConnection();
            }

            return dataTable;
        }
    }
}
