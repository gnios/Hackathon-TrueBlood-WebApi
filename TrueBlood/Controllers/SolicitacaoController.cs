using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TrueBlood.Models;
using TrueBlood.Repositories;

namespace TrueBlood.Controllers
{
    [RoutePrefix("api/Solicitacao")]
    public class SolicitacaoController : CrudController<Solicitacao>
    {
        private static ISolicitacaoRepository _repository;

        public override IRepository<Solicitacao> GetRepository()
        {
            return _repository = _repository ?? new SolicitacaoRepository(); //TODO: utilizar intetor de dependência
        }
    }
}