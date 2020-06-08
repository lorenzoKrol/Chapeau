namespace ChapeauModel.Models {
    public class Table {
        // Properties
        public int TableID { get; set; }
        public bool Occupied { get; set; }

        public Table(int tableID, bool occupied) {
            TableID = tableID;
            Occupied = occupied;
        }

        public override bool Equals(object obj) {
            if (!(obj is Table other))
                return false;

            if (TableID != other.TableID || Occupied != other.Occupied)
                return false;

            return true;
        }
    }
}
