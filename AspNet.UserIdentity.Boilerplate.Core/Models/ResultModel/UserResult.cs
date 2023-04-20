namespace AspNet.UserIdentity.Boilerplate.Core.Models.ResultModel
{
	public class UserResult
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string PhoneNumber { get; set; }

		public ICollection<string> Roles { get; set; }

		public string Email { get; set; }

	}
}
