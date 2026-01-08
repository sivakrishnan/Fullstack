using FullstackBackEnd.Models.Response;
using FullstackBackEnd.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FullstackBackEnd.Controllers.Master
{
    [Route("api/gender")]
    public class MASGenderController : ControllerBase
    {
        private readonly IRepoGender _repo;
        private readonly FSResponse _res;
        public MASGenderController(IRepoGender repo)
        {
            _repo = repo;
            _res=new();
        }

        [HttpPost("getall")]
        public async Task<IActionResult> Register()
        {
            var _res = await _repo.GetAll();
            return Ok(_res);
        }
    }
}
