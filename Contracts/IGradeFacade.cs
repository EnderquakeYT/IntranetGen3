﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.ComponentModel;

namespace MensaGymnazium.IntranetGen3.Contracts
{
	[ApiContract]
	public interface IGradeFacade
	{
		Task<Dto<List<GradeListItemDto>>> GetAllGradesAsync();
	}
}
