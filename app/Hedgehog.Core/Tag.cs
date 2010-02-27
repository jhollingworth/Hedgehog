using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class Tag : Entity
    {
        public virtual string Text { get; set; }
    }
}