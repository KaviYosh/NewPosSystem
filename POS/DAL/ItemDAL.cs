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
    public class ItemDAL : BaseClass
    {
        public bool InsertMainCategory(ItemMaster item, SqlConnection connect, SqlTransaction transac)
        {
            bool status = false;
            try
            {
                string sqlQuery = "INSERT INTO Main_Category (Main_Cat_Name,Status,Created_By,Created_On) " +
                                  "VALUES('"+item.ManCatName+"','"+item.Status+"','"+item.CreatedBy+"','"+item.CreatedOn+"') ";
                status = Insert(sqlQuery, connect, transac);
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }

        public DataTable getManCatDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT Main_Cat_Id,Main_Cat_Name " +
                             "FROM Main_Category " +
                             "WHERE Status = 1 " +
                             "ORDER BY Main_Cat_Id DESC ";
                dt = Select(sql);
                return dt;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool UpdateMainCategory(ItemMaster item, SqlConnection connect, SqlTransaction transac)
        {
            bool status = false;
            try
            {
                string sqlQuery = "UPDATE Main_Category " +
                                  "SET Main_Cat_Name='" + item.ManCatName + "', " +
                                  "Modify_By='" + item.ModifyBy + "', " +
                                  "Modify_On='" + item.ModifyOn + "'  " +
                                  "WHERE Main_Cat_Id='" + item.ManCatiD + "' ";
                status = Update(sqlQuery, connect, transac);
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }
    }
}
