using System;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Models
{
    public class Employees
    {
        [Key]
        public int IdEmployee { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio")]
        [MinLength(9, ErrorMessage = "El DNI debe tener al menos 9 caracteres")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Los Apellidos son obligatorios")]
        public string Surnames { get; set; }

        [Required(ErrorMessage = "Debe informar el puesto de trabajo")]
        public string Job { get; set; }

        [Required(ErrorMessage = "Debe ingresar un correo electr�nico")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo v�lido")]
        public string Email { get; set; }

        //[RegularExpression("/^[0-9]+$/", ErrorMessage = "El valor ha de ser num�rico")]
        public int Salary { get; set; }
    }
}
