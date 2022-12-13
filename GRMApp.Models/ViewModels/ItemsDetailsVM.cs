using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.Models.ViewModels
{
    public class ItemsDetailsVM
    {
        [Required]
        public int Score1 { get; set; }
        [Required]
        public int Score2 { get; set; }
        [Required]
        [DisplayName("Item List")]
        public IEnumerable<SelectListItem> ItemList { get; set; }
        public ItemsDetails ItemDetails1 { get; set; }
        public ItemsDetails ItemDetails2 { get; set; }
    }
}
