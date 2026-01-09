using FullstackBackEnd.DbContext;
using FullstackBackEnd.Entities;
using FullstackBackEnd.Models.Response;
using FullstackBackEnd.Repository.Interface;
using FullstackBackEnd.Utility;

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

        public async Task<FSResponse> SoftDeleteById(int id)
        {
            var data = _dbContext.MASGenders.Where(x => x.PKMASGenderID==id).SingleOrDefault();

            if (data==null)
            {
                _res.IsSuccess= false;
                _res.ResMsg=StaticData.CURD_DATA_NOTFOUND;
                return _res;
            }
            else
            {
                data.IsActive= false;
                data.IsDeleted= true;

                _dbContext.Update(data);
                int affectedRow = _dbContext.SaveChanges();

                if (affectedRow>0)
                {
                    _res.IsSuccess = true;
                    _res.ResMsg=StaticData.CURD_SOFTDELETE_SUCCESS;
                    _res.Result=data;
                }
                else
                {
                    _res.IsSuccess= false;
                    return _res;

                }
            }

            _res.Result= _dbContext.MASGenders.Where(x => x.IsDeleted == false).ToList();
            return _res;
            return _res;
        }
    }
}
