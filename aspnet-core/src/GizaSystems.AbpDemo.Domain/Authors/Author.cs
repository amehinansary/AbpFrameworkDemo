using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace GizaSystems.AbpDemo.Authors
{
    public class Author : FullAuditedAggregateRoot<Guid>
    { // FullAuditedAggregateRoot hat means when you delete it, it is not deleted in the database, but just marked as deleted
        public string Name { get; private set; } // restricts to set this property from out of this class.
        public DateTime BirthDate { get; set; }
        public string ShortBio { get; set; }

        private Author()
        {
            /* This constructor is for deserialization / ORM purpose */
        }
        // internal to force to use these methods only in the domain layer, using the AuthorManager
        internal Author(Guid id, [NotNull] string name, DateTime birthDate, [CanBeNull] string shortBio = null)
            : base(id)
        {
            SetName(name);
            BirthDate = birthDate;
            ShortBio = shortBio;
        }

        internal Author ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull] string name)
        { // Check class is an ABP Framework utility class to help you while checking method arguments
          // (it throws ArgumentException on an invalid case).
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: AuthorConsts.MaxNameLength
            );
        }
    }
}
