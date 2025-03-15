using WebApplication1.Models;
using WebApplication1.DAOs.MSSDAOs;

namespace WebApplication1.Services
{
    public class RolesService
    {
            RolesMSSDAOs _rolesDao = new();


            async public Task<List<RolModel>> GetAll()
            {
                return await _rolesDao.GetAll();
            }
        
    }
}
