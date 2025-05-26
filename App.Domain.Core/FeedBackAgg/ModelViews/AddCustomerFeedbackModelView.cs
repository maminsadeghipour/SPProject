using System;
namespace App.Domain.Core.FeedBackAgg.ModelViews
{
	public class AddCustomerFeedbackModelView
	{
        public string Description { get; set; }
        public int? Rate { get; set; }             
        public int RequestId { get; set; }
    }
}

