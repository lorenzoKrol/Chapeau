using System.Collections.Generic;
using ChapeauModel.Models;
using ChapeauDAL.DAOs;

namespace ChapeauLogic.Services {
    public class TableService {
        private TableDAO tableDAO = new TableDAO();

        public List<Table> GetAllTables() {
            return tableDAO.GetAllTables();
        }

        public void ChangeOccupation(Table table, bool occupied) {
            tableDAO.ChangeOccupation(table, occupied);
        }
    }
}
