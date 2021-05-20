using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.API
{
    public class ItemMaster
    {
        int _manCatiD;
        string _manCatName;
        int _status;
        int _createdBy;
        DateTime _createdOn;
        int _modifyBy;
        DateTime _modifyOn;

        public int ManCatiD
        {
            get { return _manCatiD; }
            set { _manCatiD = value; }
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
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string ManCatName
        {
            get { return _manCatName; } 
            set { _manCatName = value; }
        }
    }
}
