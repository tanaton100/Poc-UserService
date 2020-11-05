
using Microsoft.AspNetCore.Mvc;

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
