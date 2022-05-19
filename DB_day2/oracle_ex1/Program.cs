using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace oracle_ex1 {
    internal class Program {
        static void Main() {
            try {
                string constr = "User Id = sys as sysdba; Password = 1234; Data Source = (DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 141.223.217.197)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
                OracleConnection conn = new OracleConnection(constr);
                conn.Open();

                OracleCommand cmd = new OracleCommand("getDept", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter output = cmd.Parameters.Add("refcur_ret", OracleDbType.RefCursor);
                output.Direction = ParameterDirection.ReturnValue;

                OracleParameter input = cmd.Parameters.Add("deptno", OracleDbType.Int16);
                input.Direction = ParameterDirection.ReturnValue;
                input.Value = 10;

                cmd.ExecuteNonQuery();

                OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                Console.Write(reader.GetName(0) + "\t");
                Console.WriteLine(reader.GetName(1));
                Console.WriteLine("----------------------");

                while (reader.Read()) {
                    Console.Write(reader[0].ToString() + "\t");
                    Console.WriteLine(reader[1].ToString());
                }

                reader.Close();
                reader.Dispose();
                output.Dispose();
                input.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
