using NHibernate;
using NHibernate.Cfg;

namespace NhibernateTutorial
{
    public class HibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var cfg = new Configuration();
                    cfg.Configure();
                    cfg.AddAssembly(typeof(Hero).Assembly);
                    _sessionFactory = cfg.BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
