
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStore.MVC.Models
{
    public class Owner : DomainObject
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get => $"{FirstName} {LastName}";
            set => FullName = value;
        }
        [Required]
        [StringLength(20)]
        public string Street { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Occupation { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}

