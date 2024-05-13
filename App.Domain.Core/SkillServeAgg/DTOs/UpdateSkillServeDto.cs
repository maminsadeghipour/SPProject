using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using App.Domain.Core.SkillServeAgg.Entity;

namespace App.Domain.Core.SkillServeAgg.DTOs
{
	public class UpdateSkillServeDto
    {
		public UpdateSkillServeDto()
		{
		}

        public int Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "عنوان الزامی است")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "توضیحات الزامی است")]
        public string Description { get; set; }

        [Display(Name = "حداقل دستمزد")]
        [Required(ErrorMessage = "حداقل دستمزد الزامی است")]
        public int MinWage { get; set; }

        [Display(Name = "دسته بندی")]
        [Required(ErrorMessage = "دسته بندی الزامی است")]
        public int CategoryId { get; set; }
        public SkillServeCategory? Category { get; set; }
    }
}

