using DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubCategoryDAL : BaseClass
    {
        public DataTable getMainCategoryDetails()
        {
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
    }
}
