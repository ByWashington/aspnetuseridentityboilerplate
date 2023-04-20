namespace AspNet.UserIdentity.Boilerplate.Core.Models.ResultModel
{
	public class UserLoggedResult
	{

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Avatar { get; set; }

		public ICollection<string> Roles { get; set; }

		public string Token { get; set; }

	}
}
