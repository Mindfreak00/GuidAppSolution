using GuideApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Infrasructure
{
    public interface IDbFactory : IDisposable
    {
        GuideAppContext Init();
    }
}
