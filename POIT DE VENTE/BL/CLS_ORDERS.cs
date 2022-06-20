using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace POIT_DE_VENTE.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_LAST_ORDER_FOR_PRINT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_FOR_PRINT", null);
            DAL.Close();
            return Dt;
        }


        public void ADD_ORDER(int ID_ORDER, DateTime DATE_ORDER, int ID_CUSTOMER,
                              string DESCRIPTION_ORDER, string SALESMAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[2].Value = ID_CUSTOMER;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.NVarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALESMAN", SqlDbType.NVarChar, 50);
            param[4].Value = SALESMAN;


            DAL.ExecuteCommed("ADD_ORDER", param);
            DAL.Close();

        }


        //حفظ عملية البيع 
        public void ADD_ORDER_DETAILS(string ID_PRODUCT, int ID_ORDER, int QTE,
                      string PRICE, double DISCOUNT, string AMOUNT, double TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.NVarChar, 50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.Float);
            param[6].Value = TOTAL_AMOUNT;

            DAL.ExecuteCommed("ADD_ORDER_DETAILS", param);
            DAL.Close();

        }
        public void ADD_ORDER_DETAILS_RETURN(string ID_PRODUCT, int ID_ORDER, int QTE,
                     string PRICE, double DISCOUNT, string AMOUNT, double TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.NVarChar, 50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.Float);
            param[6].Value = TOTAL_AMOUNT;

            DAL.ExecuteCommed("ADD_ORDER_DETAILS_RETURN", param);
            DAL.Close();

        }



        public DataTable VerifyQty(string ID_PRODUCT, int Qty_Entered)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Int);
            param[1].Value = Qty_Entered;

            Dt = DAL.SelectData("VerifyQty", param);
            DAL.Close();
            return Dt;
        }


        public DataTable GetOrderDetails(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;


            Dt = DAL.SelectData("GetOrderDetails", param);
            DAL.Close();
            return Dt;
        }


        public DataTable SearchOrders(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchOrders", param);
            DAL.Close();
            return Dt;
        }

    }
}
