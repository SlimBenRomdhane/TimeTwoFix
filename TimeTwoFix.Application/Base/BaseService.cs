using AutoMapper;
using TimeTwoFix.Core.Interfaces.Repositories.Base;

namespace TimeTwoFix.Application.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _repository = baseRepository;
            _mapper = mapper;

        }
        public async Task<T> AddAsyncServiceGeneric(T entity)
        {
            var res = await _repository.AddAsyncGeneric(entity);
            return res;

        }

        public async Task DeleteAsyncServiceGeneric(int id)
        {
            var enityToDelete = await _repository.GetByIdAsyncGeneric(id);
            if (enityToDelete == null)
            {
                throw new Exception("Entity not found");
            }
            await _repository.DeleteAsyncGeneric(enityToDelete);

        }

        public async Task<IEnumerable<T>> GetAllAsyncServiceGeneric()
        {
            var res = await _repository.GetAllAsyncGeneric();
            return res;
        }

        public async Task<T?> GetByIdAsyncServiceGeneric(int id)
        {
            var res = await _repository.GetByIdAsyncGeneric(id);
            if (res == null)
            {
                throw new Exception("Entity not found");
            }
            return res;
        }

        public async Task UpdateAsyncServiceGeneric(T entity)
        {
            await _repository.UpdateAsyncGeneric(entity);

        }
    }
}
