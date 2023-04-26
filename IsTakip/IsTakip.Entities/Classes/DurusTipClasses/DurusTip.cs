using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.UretimDurusClasses;
using IsTakip.Entities.Classes.UretimEmriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.DurusTipClasses
{
	public class DurusTip : BaseObject
	{
		public string Tanim { get; set; }
		public string Aciklama { get; set; }

		
		public ICollection<UretimDurus> UretimDurus { get; set; }

	}
}

