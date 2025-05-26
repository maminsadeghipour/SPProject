using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.RequestAgg.DTOs
{
	public class AddRequestDto
	{
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "عنوان الزامی می باشد")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "توضیحات الزامی می باشد")]
        public string Description { get; set; }

        [Display(Name = "تاریخ اتمام")]
        [Required(ErrorMessage = "تاریخ الزامی می باشد")]
        public DateTime DeadLine { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "آدرس الزامی می باشد")]
        public int AddressId { get; set; }

        [Display(Name = "عکس")]
        [Required(ErrorMessage = "عکس الزامی می باشد")]
        public List<IFormFile> Pictures { get; set; }

        public int SkillServeId { get; set; }
        

    }
}

