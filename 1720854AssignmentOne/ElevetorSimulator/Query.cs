using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace ElevetorSimulator
{
    class Query
    {
        public void insertdata(string action)
        {
            string sql = "insert into [ElevatorRecord] ([Date],[Time],[Actions]) values (@date, @time, @action)";
            OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.con);
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToString("HH:mm:ss tt");

            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@action", action);
            cmd.ExecuteNonQuery();

        }

        public DataTable ViewLog()
        {

            string sql = "SELECT Date,Time,Actions FROM ElevatorRecord";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, DatabaseConnection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ElevatorRecord");
            return ds.Tables[0];
        }
        public void clear()
        {
            string sql = "DELETE * FROM ElevatorRecord";
            OleDbCommand cmd = new OleDbCommand(sql, DatabaseConnection.con);
            cmd.ExecuteNonQuery();
            
        }
    }
}
