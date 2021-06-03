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
    public class SupplierDAL: BaseClass
    {
        public DataTable getSupplierDetails(string supplierName)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT SupName,SupAddressLine1,SupAddressLine2,SupAddressLine3,TeleNoLand,MobileNo,FaxNo " +
                             "FROM Supplier " +
                             "WHERE Active = 1 " +
                             "AND SupName LIKE ('%" + supplierName + "%') " +
                             "ORDER BY SupID DESC ";//last records show top
                dt = Select(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertSupplierDetails(SupplierMaster supplier, SqlConnection connect, SqlTransaction transac)
        {
            int id = 0;
            try
            {
                string sqlQuery = "INSERT INTO Supplier(SupName,SupAddressLine1,SupAddressLine2,SupAddressLine3,TeleNoLand,MobileNo,FaxNo,CreatedBy,CreatedDate,Active) " +
                                  "VALUES('" + supplier.SupName + "','" + supplier.SupAddressLine1 + "','" + supplier.SupAddressLine2 + "','" + supplier.SupAddressLine3 + "', " +
                                  "'" + supplier.TeleNoLand + "','" + supplier.MobileNo + "','" + supplier.FaxNo + "','" + supplier.CreatedBy + "','" + supplier.CreatedOn + "','" + supplier.Active + "') SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY] ";
                id = InsertAndGetId(sqlQuery, connect, transac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        public int InsertSupplierContactPersonInfo(SupplierContactPersonMaster supplierConpersonMaster, SqlConnection connect, SqlTransaction transac)
        {
            int id = 0;
            try
            {
                string sqlQuery = "INSERT INTO SupplierContactPersonInfo(SupID,PersonName,Designation,PersonOfficeNumber,PersonMobileNo,Remarks,CreatedDate,CreatedBy,Active) " +
                                  "VALUES('" + supplierConpersonMaster.SupID + "','" + supplierConpersonMaster.PersonName + "','" + supplierConpersonMaster.Designation + "','" + supplierConpersonMaster.PersonOfficeNumber + "', " +
                                  "'" + supplierConpersonMaster.PersonMobileNo + "','" + supplierConpersonMaster.Remarks + "','" + supplierConpersonMaster.CreatedOn + "','" + supplierConpersonMaster.CreatedBy + "','" + supplierConpersonMaster.Active + "') SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]";
                id = InsertAndGetId(sqlQuery, connect, transac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }
    }
}
