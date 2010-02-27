using System;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Conventions;
using Hedgehog.Core;
using Hedgehog.Data.NHibernateMaps.Conventions;
using SharpArch.Core.DomainModel;
using SharpArch.Data.NHibernate.FluentNHibernate;
using ForeignKeyConvention = Hedgehog.Data.NHibernateMaps.Conventions.ForeignKeyConvention;
using ManyToManyTableNameConvention = Hedgehog.Data.NHibernateMaps.Conventions.ManyToManyTableNameConvention;

namespace Hedgehog.Data.NHibernateMaps
{
    public class AutoPersistenceModelGenerator : IAutoPersistenceModelGenerator
    {
        #region IAutoPersistenceModelGenerator Members

        public AutoPersistenceModel Generate()
        {
            var mappings = new AutoPersistenceModel();
            mappings.AddEntityAssembly(typeof (Class1).Assembly).Where(GetAutoMappingFilter);
            mappings.Conventions.Setup(GetConventions());
            mappings.Setup(GetSetup());
            mappings.UseOverridesFromAssemblyOf<AutoPersistenceModelGenerator>();
            return mappings;
        }

        #endregion

        private static Action<AutoMappingExpressions> GetSetup()
        {
            return c => { c.FindIdentity = type => type.Name == "Id"; };
        }

        private static Action<IConventionFinder> GetConventions()
        {
            return c =>
                       {
                           c.Add<ForeignKeyConvention>();
                           c.Add<HasManyConvention>();
                           c.Add<HasManyToManyConvention>();
                           c.Add<ManyToManyTableNameConvention>();
                           c.Add<PrimaryKeyConvention>();
                           c.Add<ReferenceConvention>();
                           c.Add<TableNameConvention>();
                       };
        }

        /// <summary>
        /// Provides a filter for only including types which inherit from the IEntityWithTypedId interface.
        /// </summary>
        private static bool GetAutoMappingFilter(Type t)
        {
            return t.IsSubclassOf(typeof (Entity));
        }
    }
}