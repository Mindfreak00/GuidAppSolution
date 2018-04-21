using GuideApp.Data.Models;
using GuideApp.Infrasructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Repository
{
    public class TipRepository : RepositoryBase<Tip>, ITipRepository
    {
        public TipRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
