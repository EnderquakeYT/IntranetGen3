﻿using Havit.NewProjectTemplate.Model.Attrida;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.NewProjectTemplate.Entity.Configurations.Attrida
{
	public class AttridaObjectConfiguration : IEntityTypeConfiguration<AttridaObject>
	{
		public void Configure(EntityTypeBuilder<AttridaObject> builder)
		{
			builder.Ignore(ao => ao.Documents);
			builder.Ignore(ao => ao.Comments);
		}
	}
}
