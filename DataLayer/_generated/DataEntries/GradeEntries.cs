﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Patterns;
using Havit.Data.Patterns.DataEntries;
using Havit.Data.Patterns.Repositories;

namespace MensaGymnazium.IntranetGen3.DataLayer.DataEntries
{
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public class GradeEntries : DataEntries<MensaGymnazium.IntranetGen3.Model.Grade>, IGradeEntries 
	{
		public MensaGymnazium.IntranetGen3.Model.Grade Kvarta
        {
            get
            {
				if (kvarta == null)
				{
					kvarta = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Kvarta);
				}
				return kvarta;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade kvarta;

		public MensaGymnazium.IntranetGen3.Model.Grade Kvinta
        {
            get
            {
				if (kvinta == null)
				{
					kvinta = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Kvinta);
				}
				return kvinta;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade kvinta;

		public MensaGymnazium.IntranetGen3.Model.Grade Oktava
        {
            get
            {
				if (oktava == null)
				{
					oktava = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Oktava);
				}
				return oktava;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade oktava;

		public MensaGymnazium.IntranetGen3.Model.Grade Prima
        {
            get
            {
				if (prima == null)
				{
					prima = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Prima);
				}
				return prima;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade prima;

		public MensaGymnazium.IntranetGen3.Model.Grade Sekunda
        {
            get
            {
				if (sekunda == null)
				{
					sekunda = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Sekunda);
				}
				return sekunda;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade sekunda;

		public MensaGymnazium.IntranetGen3.Model.Grade Septima
        {
            get
            {
				if (septima == null)
				{
					septima = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Septima);
				}
				return septima;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade septima;

		public MensaGymnazium.IntranetGen3.Model.Grade Sexta
        {
            get
            {
				if (sexta == null)
				{
					sexta = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Sexta);
				}
				return sexta;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade sexta;

		public MensaGymnazium.IntranetGen3.Model.Grade Tercie
        {
            get
            {
				if (tercie == null)
				{
					tercie = GetEntry(MensaGymnazium.IntranetGen3.Model.Grade.Entry.Tercie);
				}
				return tercie;
            }
        }
		private MensaGymnazium.IntranetGen3.Model.Grade tercie;

		public GradeEntries(MensaGymnazium.IntranetGen3.DataLayer.Repositories.IGradeRepository repository)
			: base(repository)
		{
		}
	}
}