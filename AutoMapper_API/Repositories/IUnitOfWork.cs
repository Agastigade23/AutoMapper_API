namespace AutoMapper_API.Repositories
{
    public interface IUnitOfWork
    {
        IRepository Repository();
        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
