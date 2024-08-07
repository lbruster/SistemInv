﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es Requerido")]
        [MaxLength(60, ErrorMessage = "Nombre debe ser un Maximo de 60 Caracteres")]
        public string Nombre { get; set;}

        [Required(ErrorMessage = "Descriocion es Requerido")]
        [MaxLength(100, ErrorMessage = "Descripcion debe ser un Maximo de 100 Caracteres")]
        public  string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es Requerido")]
        public bool Estado { get; set; }


    }
}
