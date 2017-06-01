using Sodexo.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
    }
}
