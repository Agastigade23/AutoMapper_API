﻿using AutoMapper_API.Entities;

namespace AutoMapper_API.Resources
{
    public class PersonResource
    {
        public int Id { get; init; }
        public string ? FirstName { get; init; }
        public string ? LastName { get; init; }
        public IList<Address>? Addresses { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}
