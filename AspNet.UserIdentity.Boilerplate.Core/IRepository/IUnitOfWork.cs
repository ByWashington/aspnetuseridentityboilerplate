namespace AspNet.UserIdentity.Boilerplate.Core.IRepository
{
	public interface IUnitOfWork : IDisposable
    {
        Task Save();
    }
}
