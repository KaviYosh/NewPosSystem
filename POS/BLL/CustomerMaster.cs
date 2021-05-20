using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.API
{
    public class CustomerMaster
    {
        //this class use create get and set methods
        string _fristName;
        string _lastName;
        string _nic;
        string _addLine1;
        string _addLine2;
        string _mobileNo;
        int _active;
        int _createdBy;
        DateTime _createdOn;
        int _modifyBy;
        DateTime _modifyOn;

        public string FristName
        {
            get { return _fristName; }
            set { _fristName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string NIC
        {
            get { return _nic; }
            set { _nic = value; }
        }

        public string AddLine1
        {
            get { return _addLine1; }
            set { _addLine1 = value; }
        }

        public string AddLine2
        {
            get { return _addLine2; }
            set { _addLine2 = value; }
        }

        public string MobileNo
        {
            get { return _mobileNo; }
            set { _mobileNo = value; }
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
    }
}
