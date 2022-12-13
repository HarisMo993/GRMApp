using GRMApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.DataAccess.Data
{
	public class ItemDbContext : DbContext
	{
		public ItemDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Item> Items { get; set; }
		public DbSet<ItemsDetails> ItemsDeails { get; set; }
	}
}
