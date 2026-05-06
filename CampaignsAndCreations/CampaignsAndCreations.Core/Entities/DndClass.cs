using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Beyond_Sheet.Core.Entities
{
	public abstract class DndClass
	{
        private Random _rn;

		public Guid Id { get; set; }
        public int Lvl {  get; set; }
        public int ClassHp { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int ConstitutionModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public int WisdomModifier { get; set; }
        public int CharismaModifier { get; set; }
		public int HitPointDie {  get; set; }

        List<Spell> Spells { get; set; }
		List<Attack> Attacks { get; set; }
		List<Feat> Feat {  get; set; }
		List<SavingThrowProficiencie> SavingThrowProficiencies { get; set; }
        List<SkillProficiencie> SkillProficiencies { get; set; }
        List<WeaponProficiencie> WeaponProficiencies { get; set; }
        List<ToolProficiencie> ToolProficiencies { get; set; }
        List<ArmorProfciencie> ArmorProfciencies { get; set; }

        public DndClass()
		{
            Id = Guid.NewGuid();
            Lvl = 1;
            ClassHp = 0;
        }

        public void LvlUp() 
        {
            Lvl += 1;
            ClassHp += _rn.Next(1, HitPointDie + 1);
            CheckLevelUp();

        }

        public abstract void CheckLevelUp();
    }
}
