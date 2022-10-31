using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CONECDBpract2
{
    class clstransacciones
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        
        public clstransacciones(){
            //con.ConnectionString = "data source=.\\SQLEXPRESS;initial catalog=ITCA08 ; user=sa; password=itca2022;";
            con.ConnectionString = "data source=.\\SQLEXPRESS;initial catalog=ITCA08 ; user=sa; Integrated Security=true;";

            //con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial catalog=bs_subastas;Integrated Security=true;";
        }

        public DataTable consulta(string sql) {
         DataTable mitabla = new DataTable();
            adapter = new SqlDataAdapter(sql,con);
            adapter.Fill(mitabla);

            return mitabla;

        }

        public bool ejecutarcomando(string sql)
        {
            cmd.CommandText = sql;
            cmd.Connection = con;

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return true;

        }






    }
}
