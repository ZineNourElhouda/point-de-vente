using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

 namespace POIT_DE_VENTE.DAL
 {
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //this constructor inisialize the connection object
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server=MITCOMPUTERS-PC; Database=POIT_DE_VENTE_BDD_00; Integrated Security=true");
        }
        //method to open the connection
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        ///method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        //methode to read data from database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //method to insert,update,and delete data from database
        public void ExecuteCommed(string stored_procedure, SqlParameter[] param) 
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }

        
    }
 }

