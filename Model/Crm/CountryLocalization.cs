﻿using MensaGymnazium.IntranetGen3.Model.Localizations;
using Havit.Model.Localizations;
using System.ComponentModel.DataAnnotations;

namespace MensaGymnazium.IntranetGen3.Model.Crm
{
	public class CountryLocalization : ILocalization<Country>
	{
		public int Id { get; set; }

		public Country Parent { get; set; }
		public int ParentId { get; set; }

		public Language Language { get; set; }
		public int LanguageId { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
	}
}