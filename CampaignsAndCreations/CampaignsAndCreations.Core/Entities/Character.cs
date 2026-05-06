using Beyond_Sheet.Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_Sheet.Core.Entities
{
	public class Character
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string? SocialName { get; set; }
		public string? Gender { get; set; }
		public string? Faith { get; set; }
		public int? Age { get; set; }
		public string? Hair { get; set; }
		public string? Eyes { get; set; }
		public string? Skin { get; set; }
		public int? Height { get; set; }
		public decimal? Weight { get; set; }
		public bool Inspiration { get; set; }
		public int BaseHitPoints { get; set; }
		public int? BonusHitPoints { get; set; }
		public int? OverrideHitPoints { get; set; }
		public int RemovedHitPoints { get; set; }
		public int TemporaryHitPoints { get; set; }
		public int StrengthRoll { get; set; }
		public int DexterityRoll { get; set; }
        public int ConstitutionRoll { get; set; }
        public int IntelligenceRoll { get; set; }
        public int WisdomRoll { get; set; }
        public int CharismaRoll { get; set; }
        public Allignement Allignement { get; set; }
		public Race Race { get; set; }
		public ICollection<DndClass> Classes {get;set;}

	}
}
