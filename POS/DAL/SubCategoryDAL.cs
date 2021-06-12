using DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.API;
using System.Data.SqlClient;

namespace DAL
{
    public class SubCategoryDAL : BaseClass
    {
        public DataTable getMainCategoryDetails()
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/04
            /// Des : Main category details select query to combo box

            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT MainCatID,CatName " +
                             "FROM MainCategory " +
                             "WHERE Active = 1 " +
                             "ORDER BY MainCatID DESC ";//last records show top
                dt = Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getSubCategoryDetails(string subCatName)
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/06
            /// Des : grid view load select query

            try
            {
                DataTable dt = new DataTable();
                string sql = "Select MC.CatName,SC.SubName " +
                             "FROM SubCategory SC " +
                             "INNER JOIN MainCategory MC " +
                             "ON SC.MainCatID = MC.MainCatID " +
                             "WHERE SC.Active = 1 " +
                             "ORDER BY SC.SubCatID DESC ";//last records show top

                dt = Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertSubCatDetails(SubCategoryMaster subCategory, SqlConnection connect, SqlTransaction transac)
        {
            bool status = false;
            try
            {
                string sqlQuery = "INSERT INTO SubCategory(SubName,MainCatID,CreatedBy,CreatedDate,Active) " +
                                  "VALUES('" + subCategory.SubName + "','" + subCategory.MainCatID + "','" + subCategory.CreatedBy + "','" + subCategory.CreatedOn + "','" + subCategory.Active + "') ";
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
