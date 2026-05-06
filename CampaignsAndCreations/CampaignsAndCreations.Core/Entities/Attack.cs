using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_Sheet.Core.Entities
{
    abstract class Attack
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private Random _rn;

        public Attack(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }

        public virtual int UseAttack(Character player) 
        {
            return 0;
        }
    }
}
