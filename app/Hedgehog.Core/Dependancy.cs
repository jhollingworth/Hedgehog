using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class Dependancy : Entity
    {
        public virtual Project Project { get; set; }
        public virtual VersionNumber DependantVersion { get; set; }
        public virtual DependancyVersionRelation VersionRelation { get; set; }

        public enum DependancyVersionRelation
        {
            GreaterThan, LessThan, Equal
        }
    }
}