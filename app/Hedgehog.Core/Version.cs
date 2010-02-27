using System;
using System.Collections.Generic;
using SharpArch.Core.DomainModel;

namespace Hedgehog.Core
{
    public class Version : Entity
    {
        public virtual Project Project { get; set; }
        public virtual int Downloads { get; set; }
        public virtual VersionNumber VersionNumber { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual List<Vote> Votes { get; set; }
    }
}