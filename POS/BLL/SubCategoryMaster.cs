using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.API
{
    public class SubCategoryMaster
    {
        int _subCatID;
        string _subName;
        string _mainCatID;
        int _createdBy;
        DateTime _createdOn;
        int _modifyBy;
        DateTime _modifyOn;
        int _active;

        public int SubCatID
        {
            get { return _subCatID; }
            set { _subCatID = value; }
        }
        public string SubName
        {
            get { return _subName; }
            set { _subName = value; }
        }
        public string MainCatID
        {
            get { return _mainCatID; }
            set { _mainCatID = value; }
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
        public int Active
        {
            get { return _active; }
            set { _active = value; }
        }
        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }
    }
}
