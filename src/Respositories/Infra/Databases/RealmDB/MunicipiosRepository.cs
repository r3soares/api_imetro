using src.Domain.Models.Municipios;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class MunicipiosRepository : IMunicipiosRepository
    {
        private readonly IRepository<Municipio> _repository;
        public MunicipiosRepository()
        {
            _repository = new RealmDatabase<Municipio>("municipios.realm", new[] { typeof(Municipio), typeof(Estado) });
        }

        public async Task<object> Delete(object id)
        {
            return await _repository.Delete(id);
        }

        public async Task<IQueryable<Municipio>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Municipio> GetById(object id)
        {
            return await _repository.GetById(id);
        }

        public async Task<object> Save(Municipio data)
        {
            return await _repository.Save(data);
        }

        public async Task<object> Update(Municipio data)
        {
            return await _repository.Update(data);
        }
    }
}
