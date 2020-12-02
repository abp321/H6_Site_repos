using System.Collections.Generic;

namespace H6_Site
{
    public class DataModel
    {
        public string Table { get; set; }
        public string Fields { get; set; }
        public int Limit { get; set; }
        public string SearchStmt { get; set; }
        public KeyValuePair<string,string> OrderStmt { get; set; }

        public string Query 
        {
            get
            {
                string limit = Limit == 0 ? "" : $"top ({Limit})";
                string order = OrderStmt.Key == null || OrderStmt.Value == null ? "" : $"order by {OrderStmt.Key} {OrderStmt.Value}";
                string where = string.IsNullOrEmpty(SearchStmt) || string.IsNullOrWhiteSpace(SearchStmt) ? "" : SearchStmt;

                return $"select {limit} {Fields} from {Table} {where} {order}"; 
            }
        }
    }
}
