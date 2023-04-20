using AutoMapper;
using AspNet.UserIdentity.Boilerplate.Core.DTOs;
using AspNet.UserIdentity.Boilerplate.Core.Models.ResultModel;
using AspNet.UserIdentity.Boilerplate.Data;

namespace AspNet.UserIdentity.Boilerplate.Core.Configurations
{
	public class MapperInitilizer : Profile
	{
		public MapperInitilizer()
		{

			CreateMap<User, UserDTO>().ReverseMap();
			CreateMap<User, UserResult>();
			CreateMap<User, UserLoggedResult>();

		}
	}
}
