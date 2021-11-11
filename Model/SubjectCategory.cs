using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensaGymnazium.IntranetGen3.Model
{
	public class SubjectCategory
	{
		public int Id { get; set; }

		[MaxLength(20)]
		public string Name { get; set; }
		public enum Entry
		{
			NotDefined = 0,

			Graduational = 1,

			Seminars = 2,

			SpecialSeminars = 4,

			ForeignLanguage = 8
		}
	}
}
