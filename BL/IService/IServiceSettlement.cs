using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BL.IService
{
    public interface IServiceSettlement
    {
        Task<List<Settlement>> GetAll();
        Task<bool> Delete(int id);
        Task<Settlement> Add(Settlement settlement);
        Task<Settlement> Update(Settlement settlement);
    }
}
