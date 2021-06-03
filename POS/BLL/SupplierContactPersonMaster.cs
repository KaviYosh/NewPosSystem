using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.API
{
    /// <summary>
    /// Created By : Kavinda Yoshana
    /// Created Date : 30/05/2021
    /// Des :this class use create get and set methods
    /// </summary>
    public class SupplierContactPersonMaster
    {
        string _prsonName;
        string _designation;
        string _personOfficeNumber;
        string _personMobileNo;
        string _remarks;
        int _supID;
        int _active;
        int _createdBy;
        DateTime _createdOn;
        int _modifyBy;
        DateTime _modifyOn;
        string _createdMachine;

        public int SupID
        {
            get { return _supID; }
            set { _supID = value; }
        }
        public string PersonName
        {
            get { return _prsonName; }
            set { _prsonName = value; }
        }
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }
        public string PersonOfficeNumber
        {
            get { return _personOfficeNumber; }
            set { _personOfficeNumber = value; }
        }
        public string PersonMobileNo
        {
            get { return _personMobileNo; }
            set { _personMobileNo = value; }
        }
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        public DateTime ModifyOn
        {
            get { return _modifyOn; }
            set { _modifyOn = value; }
        }
        public int ModifyBy
        {
            get { return _modifyBy; }
            set { _modifyBy = value; }
        }
        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }
        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
        public int Active
        {
            get { return _active; }
            set { _active = value; }
        }
        public string CreateMachine
        {
            get { return _createdMachine; }
            set { _createdMachine = value; }
        }
    }
}
