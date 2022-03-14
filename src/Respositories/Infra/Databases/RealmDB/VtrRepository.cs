using Realms;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class VtrRepository<T> : IVtrRepository<T>
        where T : RealmObject
    {
        static readonly bool PERSISTENCIA_BANCO = true;
        private readonly IRepository<T> _repository;
        public VtrRepository()
        {
            _repository = new RealmDatabase<T>("vtr.realm", PERSISTENCIA_BANCO);
        }

        public async Task<object> Delete(object id)
        {
            return await _repository.Delete(id);
        }

        public async Task<IQueryable<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetById(object id)
        {
            return await _repository.GetById(id);
        }

        public async Task<object> Save(T data)
        {
            return await _repository.Save(data);
        }

        public async Task<object> Update(T data)
        {
            return await _repository.Update(data);
        }
    }
}
