using System;
using App.Domain.Core.RequestAgg.Enum;

namespace App.Domain.Core.RequestAgg.DTOs
{
	public class UpdateRequestDto
	{
		public UpdateRequestDto()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public RequestSate RequestState { get; set; }
        //public int? NewRequestState { get; set; }
    }
}

