using FullstackBackEnd.DbContext;
using FullstackBackEnd.Entities;
using FullstackBackEnd.Models.Response;
using FullstackBackEnd.Repository.Interface;

namespace FullstackBackEnd.Repository
{
    public class RepoGender : IRepoGender
    {
        private readonly FullstackDBContext _dbContext;
        private readonly FSResponse _res;        

        public RepoGender(FullstackDBContext dbContext)
        {
            _dbContext = dbContext;
            _res = new();
        }
        public async Task<FSResponse> GetAll()
        {
           
                _res.Result= _dbContext.MASGenders.Where(x => x.IsDeleted == false).ToList();
           
            
            return _res;
        }

        public async Task<FSResponse> GetById(int id)
        {
            return _res;
        }

        public async Task<FSResponse> Insert(MASGender obj)
        {
            return _res;
        }

        public async Task<FSResponse> Update(MASGender obj)
        {
            return _res;
        }
    }
}
