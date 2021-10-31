using System;
using System.ComponentModel.DataAnnotations;

namespace Data.DomainModels
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
    }
}
