using Sodexo.Entities;
using Sodexo.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
    }
}
