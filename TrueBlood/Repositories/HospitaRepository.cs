using System.Collections.Generic;
using TrueBlood.Models;

namespace TrueBlood.Repositories
{
    public interface IHospitalRepository : IRepository<Hospital>
    {
        IEnumerable<Hospital> Filter(string query);
    }

    public class HospitalRepository : Repository<Hospital>, IHospitalRepository
    {
        public IEnumerable<Hospital> Filter(string query)
        {
            query = query.Trim().ToLower();
            return Filter(p => p.Nome != null && p.Nome.ToLower().Contains(query));
        }
    }
}