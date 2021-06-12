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
    public class MainCategoryDAL : BaseClass
    {
        public DataTable getSubCategoryDetails(string subCatName)
        {
            /// Create By: Kavinda Yoshana
            /// Create Date : 2021/06/08
            /// Des : grid view load select query

            try
            {
                DataTable dt = new DataTable();
                string sql = "Select CatName " +
                             "FROM MainCategory " +
                             "ORDER BY MainCatID DESC ";//last records show top

                dt = Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertSubCatDetails(ItemMaster itemMaster, SqlConnection connect, SqlTransaction transac)
        {
            bool status = false;
            try
            {
                string sqlQuery = "INSERT INTO MainCategory(CatName,CreatedBy,CreatedDate,Active) " +
                                  "VALUES('" + itemMaster.ManCatName + "','" + itemMaster.CreatedBy + "','" + itemMaster.CreatedOn + "','" + itemMaster.Active + "') ";
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
