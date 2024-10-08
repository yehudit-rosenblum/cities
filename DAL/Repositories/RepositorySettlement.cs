using DAL.IRepositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RepositorySettlement : IRepositorySettlement
    {
        private readonly SettlementContext db;
        public RepositorySettlement(SettlementContext db)
        {
            this.db = db;
        }

        public async Task<Settlement> Add(Settlement settlement)
        {
            await db.Settlements.AddAsync(settlement);
            await db.SaveChangesAsync();
            Settlement newSettlement =await db.Settlements
                .FirstOrDefaultAsync(s => s.SettlementName == settlement.SettlementName);
            return newSettlement;


        }

        public async Task<bool> Delete(int id)
        {
            Settlement settlement=await db.Settlements.FirstOrDefaultAsync(s => s.Id == id);
            if(settlement != null)
            {
                db.Settlements.Remove(settlement);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Settlement>> GetAll()
        {
          return await db.Settlements.ToListAsync();
        }

        public async Task<Settlement> Update(Settlement settlement)
        {
            Settlement s = await db.Settlements.FirstOrDefaultAsync(s => s.Id == settlement.Id);
            s.SettlementName= settlement.SettlementName;
            await db.SaveChangesAsync();
            return s;
        }
    }
}
