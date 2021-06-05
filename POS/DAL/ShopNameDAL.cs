using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.API;
using DAL.Common;
using System.Data;

namespace DAL
{
    public class ShopNameDAL : BaseClass
    {
        public DataTable getShopName()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT ShopFIrstName,ShopSecondName,ShopLastName " +
                             "FROM ShopName " +
                             "WHERE Active = 1 ";
                dt = Select(sql);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
