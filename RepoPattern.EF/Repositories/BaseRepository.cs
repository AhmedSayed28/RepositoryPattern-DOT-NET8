using Microsoft.EntityFrameworkCore;
using RepoPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T GetById(int id) => _context.Set<T>().Find(id);

        //public T GetByIdWithInclude(int id )
        //{
        //   _context.Set<T>().Include(x=>x).SingleOrDefault(id);
        //}
    }
}
