using System;

namespace Api.Domain.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
