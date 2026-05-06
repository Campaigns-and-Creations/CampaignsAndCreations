using Beyond_Sheet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_Sheet.Core.Services
{
	public interface IImport
	{
		Task<Character> ImportCharacter(string jsonLink);

	}
}
