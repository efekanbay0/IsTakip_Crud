using IsTakip.Entities.Classes.AlinanIslerClasses;
using IsTakip.Entities.Classes.BaseObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.IsOnceligiClasses
{
	public class IsOnceligi :BaseObject
	{
		enum OncelikDurum
		{
			Dusuk, Orta, Yuksek
		}

		public int AlinanIslerId { get; set; }
		public virtual AlinanIsler AlinanIsler { get; set; }
	}
}
