using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class VersionNumber : Entity
    {
        public virtual int Major { get; set; }
        public virtual int Minor { get; set; }
        public virtual int Revision { get; set; }
    }
}