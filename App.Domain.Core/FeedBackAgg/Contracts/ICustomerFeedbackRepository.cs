using System.Threading.Tasks;
using App.Domain.Core.FeedBackAgg.Entity;

namespace App.Domain.Core.FeedBackAgg.Contracts
{
	public interface ICustomerFeedbackRepository
	{
        Task Add(CostumerFeedback feeback,CancellationToken cancellationToken);
        Task<List<CostumerFeedback>> GetAll(CancellationToken cancellationToken);
        Task<CostumerFeedback> GetById(int id, CancellationToken cancellationToken);
        Task Update(CostumerFeedback feedback, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}

