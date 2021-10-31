using System;

namespace Data.DomainModels
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
