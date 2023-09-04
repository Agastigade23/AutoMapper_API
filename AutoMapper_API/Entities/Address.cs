using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace AutoMapper_API.Entities
{
    public record Address :IEntity
    {
        public string ? Country { get; init; } = default;
        public string ? POBox { get; init; }
        public string ? City { get; init; }
        public string ? Street { get; init; }
        public string ? Apartment { get; init; }

        [ForeignKey("Person")]
        public int PersonId { get; init; }
        public virtual Person ? Person { get; init; }
    }
}
