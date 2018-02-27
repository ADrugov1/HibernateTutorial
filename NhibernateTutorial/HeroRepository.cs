using NHibernate;

namespace NhibernateTutorial
{
    public class HeroRepository
    {
        public void Add(Hero hero)
        {
            using (ISession session = HibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(hero);
                    transaction.Commit();
                }
            }
        }
        public Hero GetHeroByHP(int HP)
        {
            using (ISession session = HibernateHelper.OpenSession())
            {
                var queryResult = session.QueryOver<Hero>().Where(x => x.HP == HP).SingleOrDefault();
                return queryResult ?? new Hero();
            }
        }
        public void Update(Hero hero)
        {
            using (ISession session = HibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(hero);
                    transaction.Commit();
                }
            }
        }

        public void Delete(Hero hero)
        {
            using (ISession session = HibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(hero);
                    transaction.Commit();
                }
            }
        }
    }
}
