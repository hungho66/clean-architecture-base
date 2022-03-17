using DailyTask.Domain.Entities;

namespace DailyTask.Application.Contracts.Persistence
{
    public interface IDailyTaskRepository : IAsyncRepository<Product>
    {

    }
}