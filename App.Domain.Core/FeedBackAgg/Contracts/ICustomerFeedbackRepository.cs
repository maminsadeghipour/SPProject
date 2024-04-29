using App.Domain.Core.FeedBackAgg.Entity;

namespace App.Domain.Core.FeedBackAgg.Contracts
{
	public interface ICustomerFeedbackRepository
	{
        void Add(CostumerFeedback feeback);
        List<CostumerFeedback> GetAll();
        CostumerFeedback GetById(int id);
        void Update(CostumerFeedback feedback);
        void DeleteById(int id);
    }
}

