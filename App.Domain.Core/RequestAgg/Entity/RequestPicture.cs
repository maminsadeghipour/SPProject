using System;
using System.Diagnostics.CodeAnalysis;

namespace App.Domain.Core.RequestAgg.Entity
{
	public class RequestPicture
	{
		public RequestPicture()
		{
		}

		public int Id { get; set; }
		public string Title { get; set; }
		public string PicturePath { get; set; }

		public Request Request { get; set; }
		//[AllowNull]
		public int? RequestId { get; set; }

		public bool IsDeleted { get; set; }    
    }
}

