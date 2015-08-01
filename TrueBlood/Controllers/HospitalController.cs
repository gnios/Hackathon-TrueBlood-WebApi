using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TrueBlood.Models;
using TrueBlood.Repositories;

namespace TrueBlood.Controllers
{
    [RoutePrefix("api/hospital")]
    public class HospitalController : CrudController<Hospital>
    {
        private static IHospitalRepository _repository;

        public override IRepository<Hospital> GetRepository()
        {
            return _repository = _repository ?? new HospitalRepository();
        }

        [HttpGet]
        [Route("list")]
        public IEnumerable<Hospital> List()
        {
            IEnumerable<Hospital> result;
            result = Repository.List();
            return result;
        }
    }
}