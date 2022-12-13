using GRMApp.DataAccess.Data;
using GRMApp.DataAccess.IRepository;
using GRMApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.DataAccess.Repository
{
    public class ItemDetailsRepository : IItemDetailsRepository
    {
        private readonly ItemDbContext _db;

        public ItemDetailsRepository(ItemDbContext db)
        {
            _db = db;
        }

        public void Add(ItemsDetails item)
        {
            _db.ItemsDeails.Add(item);
        }

        public IEnumerable<ItemsDetails> GetAll()
        {
            IEnumerable<ItemsDetails> items = _db.ItemsDeails.Include(u => u.Item).ToList();
            return items;
        }
    }
}
