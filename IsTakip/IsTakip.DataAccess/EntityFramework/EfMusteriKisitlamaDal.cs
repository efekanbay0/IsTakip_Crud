using IsTakip.DataAccess.Abstract;
using IsTakip.DataAccess.Concrete;
using IsTakip.Entities.Classes.MusteriKisitlamaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.EntityFramework
{
	public class EfMusteriKisitlamaDal : GenericRepository<MusteriKisitlama>,IMusteriKisitlamaDal
	{
	}
}
