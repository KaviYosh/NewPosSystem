using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.API
{
    public class SupplierMaster
    {
        /// <summary>
        /// Created By : Kavinda Yoshana
        /// Created Date : 22/05/2021
        /// Des :this class use create get and set methods
        /// </summary>

        string _supName;
        string _supAddressLine1;
        string _supAddressLine2;
        string _supAddressLine3;
        string _teleNoLand;
        string _mobileNo;
        string _createdMachine;
        string _faxNo;
        int _active;
        int _createdBy;
        DateTime _createdOn;
        int _modifyBy;
        DateTime _modifyOn;

        public string SupName
        {
            get { return _supName; }
            set { _supName = value; }
        }

        public string SupAddressLine1
        {
            get { return _supAddressLine1; }
            set { _supAddressLine1 = value; }
        }

        public string SupAddressLine2
        {
            get { return _supAddressLine2; }
            set { _supAddressLine2 = value; }
        }

        public string SupAddressLine3
        {
            get { return _supAddressLine3; }
            set { _supAddressLine3 = value; }
        }

        public string TeleNoLand
        {
            get { return _teleNoLand; }
            set { _teleNoLand = value; }
        }

        public string MobileNo
        {
            get { return _mobileNo; }
            set { _mobileNo = value; }
        }

        public string FaxNo
        {
            get { return _faxNo; }
            set { _faxNo = value; }
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
