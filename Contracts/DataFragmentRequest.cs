﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Collections;
using ProtoBuf;

namespace MensaGymnazium.IntranetGen3.Contracts
{
	[ProtoContract]
	public class DataFragmentRequest<TFilter>
	{
		[ProtoMember(1)]
		public TFilter Filter { get; init; }

		[ProtoMember(2)]
		public int StartIndex { get; init; }

		[ProtoMember(3)]
		public int? Count { get; init; }

		[ProtoMember(4)]
		public SortItem[] Sorting { get; init; }
	}
}
