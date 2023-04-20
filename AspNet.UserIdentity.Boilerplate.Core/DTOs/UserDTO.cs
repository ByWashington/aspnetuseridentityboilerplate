using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AspNet.UserIdentity.Boilerplate.Core.DTOs
{
	public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }

		public override string ToString() => JsonConvert.SerializeObject(this);

	}

    public class UserDTO : LoginUserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public ICollection<string> Roles { get; set; }

		public override string ToString() => JsonConvert.SerializeObject(this);

	}
}
