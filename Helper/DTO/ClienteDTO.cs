using Factory;
using Helper.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }


        [Required]
        [MaxLength(20)]
        public string Identificacion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required]
        [Display(Name = "Fecha de expedicion")]
        public DateTime FechaExpedicion { get; set; }


        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Empresa donde labora")]
        public string EmperesaDondeLabora { get; set; }
        
        [Required]
        [Display(Name ="Tipo de identificacion")]        
        public int? TipoIdentificacionId { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }
        
        [Required]
        [Display(Name = "Sector")]
        public int AreaId { get; set; }
        public Area Area { get; set; }
    
        public List<PrestamoDTO> Prestamos { get; set; }
        public List<TelefonoDTO> Telefonos { get; set; }

        public List<ReferenciaDTO> Referencias { get; set; }
        [MaxLength(255)]
        public string Observacion { get; set; }

        [Display(Name = "Telefonos")]
        public string ListaTelefono
        {
            get
            {
                string _tel = "";
                if (Telefonos != null)
                {
                    foreach (var telefono in Telefonos)
                    {
                        _tel = telefono .TipoTelefono.Nombre+": "+ telefono.NumeroTelefonico + Environment.NewLine;
                    }

                }
                return _tel;
            }
        }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto {
            get
            {
                return Nombre + " " + Apellido;
            }
        }

    }
}
