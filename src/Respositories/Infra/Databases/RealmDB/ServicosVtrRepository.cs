using Realms;
using src.Domain.Models.ServicosVtr;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class ServicosVtrRepository : IServicosVtrRepository
    {
        static readonly bool PERSISTENCIA_BANCO = true;
        private readonly IRepository<TabelaServicos> _repository;
        public ServicosVtrRepository()
        {
            _repository = new RealmDatabase<TabelaServicos>(
                "servicos_vtr.realm",
                new[] {typeof(ServicoVtr), typeof(TabelaServicos) }, 
                PERSISTENCIA_BANCO);
        }

        public async Task<object> Delete(object id)
        {
            return await _repository.Delete(id);
        }

        public async Task<IQueryable<TabelaServicos>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TabelaServicos> GetById(object id)
        {
            return await _repository.GetById(id);
        }

        public async Task<object> Save(TabelaServicos data)
        {
            return await _repository.Save(data);
        }

        public async Task<object> Update(TabelaServicos data)
        {
            return await _repository.Update(data);
        }
    }
}
