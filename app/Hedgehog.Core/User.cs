using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class User : Entity
    {
        public virtual string Username { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
    }
}