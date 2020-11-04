using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_UserService.Models
{
    public class RequestUserModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
    }
}
