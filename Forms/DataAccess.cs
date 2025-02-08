using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    internal class DataAccess
    {

        private SqlConnection sqlCon;
        public SqlConnection SqlCon
        {
            get { return sqlCon; }
            set { sqlCon = value; }
        }

        private SqlCommand sqlCom;
        public SqlCommand SqlCom
        {
            get { return sqlCom; }
            set { sqlCom = value; }

        }

        private SqlDataAdapter sqlAdc;
        public SqlDataAdapter SqlAdc
        {
            get { return sqlAdc; }
            set { sqlAdc = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public DataAccess()
        {
            this.SqlCon = new SqlConnection("Data Source=DESKTOP-HG04DSD\\SQLEXPRESS;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=777777;Trust Server Certificate=True");
            this.sqlCon.Open();
        }

        public void QueryText(string query)
        {
            this.SqlCom = new SqlCommand(query, this.SqlCon);

        }

        public DataSet ExecuteQuery(string query)
        {
            Ds = new DataSet();
            this.SqlCom = new SqlCommand(query, this.SqlCon);
            this.SqlAdc = new SqlDataAdapter(this.SqlCom);
            this.SqlAdc.Fill(Ds);
            return Ds;

        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.SqlCom = new SqlCommand(sql, this.SqlCon);//this.QueryText(sql);
            this.SqlAdc = new SqlDataAdapter(this.SqlCom);
            this.Ds = new DataSet();
            this.SqlAdc.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.SqlCom = new SqlCommand(sql, this.SqlCon);//this.QueryText(sql);
            int u = this.SqlCom.ExecuteNonQuery();
            return u;
        }


    }
}
