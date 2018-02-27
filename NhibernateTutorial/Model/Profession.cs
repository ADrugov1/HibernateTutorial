using System;

namespace NhibernateTutorial
{
    public class Profession
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Money { get; set; }
        public virtual Hero Hero { get; set; }
    }
}
