using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrueBlood.Models;


namespace TrueBlood.Repositories
{
    interface ISolicitacaoRepository : IRepository<Solicitacao>
    {
    }

    public class SolicitacaoRepository : Repository<Solicitacao>, ISolicitacaoRepository
    {
    }
}