using System.Collections.Generic;
using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class Project : Entity
    {
        public virtual string Name { get; set; }
        public virtual User Owner { get; set; }
        public virtual List<User> Authors { get; set; }
        public virtual List<Link> Links { get; set; }
        public virtual List<Version> Versions { get; set; }
        public virtual List<Link> Tutorials { get; set; }
        public virtual List<Vote> Votes { get; set; }
    }
}