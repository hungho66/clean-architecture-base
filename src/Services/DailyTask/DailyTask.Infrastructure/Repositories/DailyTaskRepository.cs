using DailyTask.Application.Contracts.Persistence;
using DailyTask.Domain.Entities;

namespace DailyTask.Infrastructure.Repositories
{
    public class DailyTaskRepository : RepositoryBase<Product>, IDailyTaskRepository
    {

    }
}