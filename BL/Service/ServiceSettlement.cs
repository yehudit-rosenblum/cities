using BL.IService;
using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public class ServiceSettlement : IServiceSettlement
    {
        private readonly IRepositorySettlement repositorySettlement;
        public ServiceSettlement(IRepositorySettlement repositorySettlement) 
        {
            this.repositorySettlement = repositorySettlement;
        }

        public async Task<List<Settlement>> GetAll()
        {
            return await repositorySettlement.GetAll();
        }

        public async Task<Settlement> Add(Settlement settlement)
        {
            return await repositorySettlement.Add(settlement);
        }

        public async Task<bool> Delete(int id)
        {
            return await repositorySettlement.Delete(id);
        }

       

        public Task<Settlement> Update(Settlement settlement)
        {
            throw new NotImplementedException();
        }
    }
}
