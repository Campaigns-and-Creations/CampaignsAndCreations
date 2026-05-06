using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignsAndCreations.Core.Entities
{
    public abstract class Feat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Feat(string name, string description) 
        { 
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
    }
}
