using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_Sheet.Core.Entities
{
    public abstract class Spell
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimumSpellSlot { get; set; }
        public bool Scaled { get; set; }

        public Spell( string name, string description, int minimumSpellSlot, bool scaled)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            MinimumSpellSlot = minimumSpellSlot;
            Scaled = scaled;
        }

        public virtual void Cast(int spellSlot)
        {

        }
    }
}
