using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IRepositorySettlement
    {
        Task<List<Settlement>> GetAll();
        Task<bool> Delete(int id);
        Task<Settlement> Add(Settlement settlement);
        Task<Settlement> Update(Settlement settlement);
    }
}
