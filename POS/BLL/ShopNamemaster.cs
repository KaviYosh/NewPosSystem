using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.API
{
    public class ShopNamemaster
    {
        int _shopID;
        string _shopFIrstName;
        string _shopSecondName;
        string _ShopLastName;
        int _createdBy;
        DateTime _createdOn;
        int _modifyBy;
        DateTime _modifyOn;
        int _active;

        public int ShopID
        {
            get { return _shopID; }
            set { _shopID = value; }
        }
        public string ShopFIrstName
        {
            get { return _shopFIrstName; }
            set { _shopFIrstName = value; }
        }
        public string ShopSecondName
        {
            get { return _shopSecondName; }
            set { _shopSecondName = value; }
        }
        public string ShopLastName
        {
            get { return _ShopLastName; }
            set { _ShopLastName = value; }
        }
        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
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
    }
}
