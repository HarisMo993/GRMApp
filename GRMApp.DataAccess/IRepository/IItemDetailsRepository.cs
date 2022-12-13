using GRMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMApp.DataAccess.IRepository
{
    public interface IItemDetailsRepository
    {
        IEnumerable<ItemsDetails> GetAll();
        void Add(ItemsDetails item);
    }
}
