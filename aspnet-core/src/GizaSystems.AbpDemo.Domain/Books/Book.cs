using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace GizaSystems.AbpDemo.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public Guid AuthorId { get; set; }
        // if u dun add this u ain't be able to write join queries while getting books with their authors 
        // public Author Author { get; set; }
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
    }
}
