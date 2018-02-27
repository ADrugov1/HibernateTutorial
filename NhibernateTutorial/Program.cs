using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace NhibernateTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNhibernateCfg();

            ////CRUD
            var repository = new HeroRepository();
            var wizard = new Hero
            {
                Name = "Jone Doe",
                HP = 100,
                MP = 100
            };
            var teacher = new Profession
            {
                Money = 1,
                Name = "Teacher"
            };
            wizard.Add(teacher);
            ////CREATE
            repository.Add(wizard);
            ////READ
            var someone = repository.GetHeroByHP(100);
            ////UPDATE
            ////someone.Profession = "Killer";
            ////repository.Update(someone);
            ////DELETE
           ////repository.Delete(someone);
        }

        public static void LoadNhibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Hero).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}
