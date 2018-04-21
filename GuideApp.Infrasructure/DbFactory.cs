using GuideApp.Data;

namespace GuideApp.Infrasructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        GuideAppContext dbContext;

        public GuideAppContext Init() => dbContext ?? (dbContext = new GuideAppContext());

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

    }
}
