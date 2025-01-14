﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Patterns.QueryServices;
using Havit.Extensions.DependencyInjection.Abstractions;
using MensaGymnazium.IntranetGen3.Contracts;
using MensaGymnazium.IntranetGen3.DataLayer.DataSources;
using Microsoft.EntityFrameworkCore;

namespace MensaGymnazium.IntranetGen3.DataLayer.Queries
{
	[Service]
	public class SubjectListQuery : QueryBase<SubjectListItemDto>, ISubjectListQuery
	{
		private readonly ISubjectDataSource subjectDataSource;

		public SubjectListQuery(ISubjectDataSource subjectDataSource)
		{
			this.subjectDataSource = subjectDataSource;
		}

		public SubjectListQueryFilter Filter { get; set; }

		protected override IQueryable<SubjectListItemDto> Query()
		{
			// TODO Filter
			// TODO Richer DTO?

			return subjectDataSource.Data
				.Select(s => new SubjectListItemDto()
				{
					SubjectId = s.Id,
					Name = s.Name,
				});
		}

		public async Task<DataFragmentResult<SubjectListItemDto>> GetDataFragmentAsync(int startIndex, int? count, CancellationToken cancellationToken = default)
		{
			return new()
			{
				Data = await SelectDataFragmentAsync(startIndex, count, cancellationToken),
				TotalCount = await CountAsync(cancellationToken)
			};
		}

	}
}
