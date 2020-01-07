using System.ComponentModel.DataAnnotations;

namespace apisii.Models {

    public class Empresa {

        [Key]
        public int ID_EMPRESA { get; set; } 


        public string RutEmpresa { get; set; }

         [Required]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "El RUT del representante debe ser entre 10 y 12 caracteres")]
        public string RutRepresentante { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "La razón social empresa debe ser entre 5 y 250 caracteres")]
        public string RznSocial { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "El domicilio de la empresa debe ser entre 5 y 200 caracteres")]
        public string Direccion { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "El giro de la empresa debe ser entre 5 y 200 caracteres")]
        public string Giro { get; set; }

        public string Region { get; set; }

        public string Ciudad { get; set; }

        public string Comuna { get; set; }

        [StringLength(250)]
        public string urlCertificado { get; set; }

        [StringLength(200)]
        public string img { get; set; }

        public int estado { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 9, ErrorMessage = "El giro de la empresa debe ser entre 5 y 200 caracteres")]
        public string fono { get; set; }


        [Required]
        public byte[] password_hash { get; set; }

        [Required]
        public byte[] password_salt { get; set; }

        [Required]
        public string password_cert { get; set; }

        public string role { get; set; }

        public int pyme { get; set; }

    }



}