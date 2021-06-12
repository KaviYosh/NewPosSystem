using BLL;
using BLL.API;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRegistrationDAL
    {
        public bool InsertUserRegistration(UserRegistrationMaster _userRegistration, SqlConnection connect, SqlTransaction transac)
        {
            bool status = false;
            try
            {
                string _sql = "INSERT INTO UserDetails (FirstName,LastName,NICNo,AddressLine1,AddressLine2,MobileNo1,MobileNo2,HomePhoneNo,Gender," +
                                                        "DateOfBirth,CreatedBy,CreatedDate,ModifyBy,ModifyDate,Active)" +
                               " VALUES('" + _userRegistration.FirstName + "','" + _userRegistration.LastName + "','" + _userRegistration.NICNo + "','" + _userRegistration.Address + "',"+
                                        " '" + _userRegistration.Address2 + "','" + _userRegistration.Mobile1 + "','" + _userRegistration.Mobile2 + "','" + _userRegistration.HomeNo + "',"+
                                        " '" + _userRegistration.Gender + "','" + _userRegistration.Bday + "','" + _userRegistration.CreatedBy + "','" + _userRegistration.CreatedOn + "',"+
                                        " '" + _userRegistration.ModifyOn + "'";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return status;
        }
    }
}
