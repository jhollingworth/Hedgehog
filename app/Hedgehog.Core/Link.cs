using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class Link : Entity
    {
        public virtual string Text { get; set; }
        public virtual string Url { get; set; }
    }
}