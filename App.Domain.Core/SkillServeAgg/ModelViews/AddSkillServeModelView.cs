using System;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.SkillServeAgg.ModelViews
{
	public class AddSkillServeModelView
	{
		public AddSkillServeModelView()
		{
		}

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
    }
}

