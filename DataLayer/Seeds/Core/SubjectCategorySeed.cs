using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensaGymnazium.IntranetGen3.Model;

namespace MensaGymnazium.IntranetGen3.DataLayer.Seeds.Core
{
	class SubjectCategorySeed
	{
		public override void SeedData()
		{
			var roles = new[]
			{
				new SubjectCategory()
				{
					Id = (int)SubjectCategory.Entry.NotDefined,
					Name = "Nedefinováno",
				},
				new SubjectCategory()
				{
					Id = (int)SubjectCategory.Entry.Graduational,
					Name = "Maturitní semináře",
				},
				new SubjectCategory()
				{
					Id = (int)SubjectCategory.Entry.Seminars,
					Name = "Nadstavbový seminář",
				},
				new SubjectCategory()
				{
					Id = (int)SubjectCategory.Entry.SpecialSeminars,
					Name = "Specializační semináře",
				},
				new SubjectCategory()
				{
					Id = (int)SubjectCategory.Entry.ForeignLanguage,
					Name = "Cizí jazyk",
				},
			};
			Seed(For(roles).PairBy(r => r.Id));
		}
	}
}
