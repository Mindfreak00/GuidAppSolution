using GuideApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Infrasructure
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly IDbFactory dbFactory;
        private GuideAppContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public GuideAppContext DbContext => dbContext ?? (dbContext = dbFactory.Init());

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
