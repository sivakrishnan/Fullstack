using FullstackBackEnd.Entities;
using FullstackBackEnd.Models.Response;

namespace FullstackBackEnd.Repository.Interface
{
    public interface IRepoGender
    {
        Task<FSResponse> GetById(int id);
        Task<FSResponse> GetAll();
        Task<FSResponse> Insert(MASGender obj);
        Task<FSResponse> Update(MASGender obj);
        Task<FSResponse> SoftDeleteById(int id);
    }
}
