using Microsoft.AspNetCore.Identity;

namespace AspNet.UserIdentity.Boilerplate.Data
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

	}
}