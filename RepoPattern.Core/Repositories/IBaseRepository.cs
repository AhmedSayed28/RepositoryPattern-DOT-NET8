using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern.Core.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        T GetByIdWithInclude(int id);
    }
}
