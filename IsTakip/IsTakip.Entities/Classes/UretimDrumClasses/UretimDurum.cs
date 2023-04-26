using IsTakip.Entities.Classes.BaseObjectClasses;
using IsTakip.Entities.Classes.UretimEmriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Classes.UretimDrumClasses
{
    public class UretimDurum : BaseObject
    {
		enum DurusTipi
		{
			Baslamadi, Islemde, Tamamlandi
		}
		
		public ICollection <UretimEmri> UretimEmris { get; set; }
	}
}
