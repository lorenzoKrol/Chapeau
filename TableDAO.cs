using ChapeauModel.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ChapeauDAL.DAOs {
    public class TableDAO : Base {
        public List<Table> GetAllTables() {
            string query = "SELECT table_id, occupied " +
                "FROM [TABLE]";
            return ReadTables(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public Table GetTable(int tableID) {
            string query = "SELECT table_id, occupied " +
                "FROM [TABLE] " +
                $"WHERE table_id = {tableID}";
            return ReadTable(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        private Table ReadTable(DataTable dataTable) {
            DataRow row = dataTable.Rows[0];
            return new Table(
                tableID: (int)row["table_id"],
                occupied: bool.Parse(row["occupied"].ToString())
            );
        }

        private List<Table> ReadTables(DataTable dataTable) {
            return (from row in dataTable.AsEnumerable()
                    select new Table(
                        tableID: (int)row["table_id"],
                        occupied: bool.Parse((string)row["occupied"])
                   )).ToList();
        }

        public void ChangeOccupation(Table table, bool occupied) {
            string query = "UPDATE [TABLE] " +
                $"SET occupied = '{occupied}' " +
                $"WHERE table_id = {table.TableID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
