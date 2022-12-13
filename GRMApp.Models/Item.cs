using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.Models
{
	public class Item
	{
		public int Id { get; set; }
		public int Position { get; set; }
		[Required]
		[DisplayName("Item Name")]
		public string Name { get; set; }
		public int Score { get; set; }
        
    }
}
