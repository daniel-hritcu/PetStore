using System;
using System.ComponentModel.DataAnnotations;

namespace PetStore.MVC.Models
{
    public enum Breed
    {
        Dog,
        Cat,
        Fish,
        Hamster,
        GuineaPig
    }
    public class Pet : DomainObject
    {
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public Breed Breed { get; set; }
        [Required]
        public Owner Owner { get; set; }
    }
}