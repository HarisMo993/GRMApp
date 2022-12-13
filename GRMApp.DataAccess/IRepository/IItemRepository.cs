using GRMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.DataAccess.IRepository
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
        void Add(Item item);
        void Update(int itemId);
    }
}
