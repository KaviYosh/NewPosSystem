using BLL.API;
using DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //this class use write all the database queries
    public class CustomerDAL : BaseClass
    {
        public DataTable getCustomerDetails( string customerName)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT FirstName,LastName,NIC,AddressLine_1,AddressLine_2,TeleNo " +
                             "FROM CustomerDetails " +
                             "WHERE Active = 1 " +
                             "AND FirstName LIKE ('%"+ customerName + "%') " +
                             "ORDER BY CustomerID DESC ";//last records show top
                dt = Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool InsertCustomerDetails(CustomerMaster customer, SqlConnection connect, SqlTransaction transac)
        {
            bool status = false;
            try
            {
                string sqlQuery = "INSERT INTO CustomerDetails(FirstName,LastName,NIC,AddressLine_1,AddressLine_2,TeleNo,Active,CreatedBy,CreatedDate) " +
                                  "VALUES('" + customer.FristName + "','" + customer.LastName + "','" + customer.NIC + "','" + customer.AddLine1 + "', "+
                                  "'" + customer.AddLine2 + "','" + customer.MobileNo + "','" + customer.Active + "','" + customer.CreatedBy + "','" + customer.CreatedOn + "') ";
                status = Insert(sqlQuery, connect, transac);
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }
    }
}
