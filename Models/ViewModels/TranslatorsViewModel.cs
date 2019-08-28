using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.ViewModels
{
    public class TranslatorCreateViewModel
    {
       
        public int TranslatorID { get; set; }
        [Display(Name ="نام")]
        [Required(ErrorMessage ="وارد نمودن{0} نام ازامیست")]
        public string Name { get; set; }
        [Display(Name ="نام خانوادگی")]
        [Required(ErrorMessage = "وارد نمودن{0} نام ازامیست")]
        public string Family { get; set; }


    }

}
