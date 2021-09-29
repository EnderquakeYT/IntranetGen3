﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Havit.Data.Patterns.Repositories;
using MensaGymnazium.IntranetGen3.Contracts.Crm;
using MensaGymnazium.IntranetGen3.Model.Crm;

namespace MensaGymnazium.IntranetGen3.DataLayer.Repositories.Crm
{
	public partial interface IContactRepository
	{
		public List<Contact> GetAllIncludingDeleted();
		Task<List<ContactReferenceVM>> GetAllContactReferencesAsync(CancellationToken cancellationToken = default);
	}
}