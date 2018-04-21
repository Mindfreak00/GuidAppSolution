using GuideApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Data
{
    public class GuideAppContext : DbContext
    {
        public GuideAppContext() : base("name=DefaultConnection")
        {

        }

        public virtual DbSet<Tip> Tips { get; set; }
        public virtual DbSet<ContentTip> Contents { get; set; }
    }
}
