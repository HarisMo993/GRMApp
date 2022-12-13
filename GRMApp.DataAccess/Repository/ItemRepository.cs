using GRMApp.DataAccess.Data;
using GRMApp.DataAccess.IRepository;
using GRMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.DataAccess.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemDbContext _db;

        public ItemRepository(ItemDbContext db)
        {
            _db = db;
        }

        public void Add(Item item)
        {
                _db.Items.Add(item);
                _db.SaveChanges();
        }

        public IEnumerable<Item> GetAll()
        {
            int num = 1;

            IEnumerable<Item> items = _db.Items.ToList().OrderByDescending(u => u.Score);
            if (items != null)
            {
                foreach (var item in items)
                {
                    item.Position = num++;
                }
            }
            return items;
        }

        public void Update(int itemId)
        {
            var item = _db.Items.FirstOrDefault(i => i.Id == itemId);
            item.Score++;
            _db.Items.Update(item);
            _db.SaveChanges();
        }
    }
}
