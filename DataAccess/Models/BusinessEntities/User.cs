using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class User : BusinessEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName {get; set; }

        public UserType UserType { get; set; }
    }
}