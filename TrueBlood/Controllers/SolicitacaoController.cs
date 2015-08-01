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

        [HttpGet]
        [Route("listar")]
        public IEnumerable<Solicitacao> listar()
        {
            var solicitacoes = new List<Solicitacao>();


            for (int i = 0; i < 10; i++)
            {
                var solicitacao = new Solicitacao();
                var hospital = new Hospital();
                var paciente = new Paciente();

                hospital.Nome = "Hospital " + i;
                paciente.Nome = "Joaquina " + i;

                solicitacao.Hospital = hospital;
                solicitacao.Paciente = paciente;
                solicitacao.TipoSangue = EnumTipoSangue.ABNegativo;
                solicitacao.QuantidadeBolsa = i;
                solicitacoes.Add(solicitacao);
            }

            return solicitacoes;
        }
    }
}