using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserRegistrationMaster
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NICNo { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string HomeNo { get; set; }
        public int Gender { get; set; }
        public DateTime Bday { get; set; }
        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyOn { get; set; }
        public int Active { get; set; }
    }
}
