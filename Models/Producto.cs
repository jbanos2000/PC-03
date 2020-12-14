using System;
using System.ComponentModel.DataAnnotations;

namespace PC_03.Models
{
    public class Producto
    {
         public int id { get; set; }

        [Display(Name="Nombre del producto")]
        public string nombre{ get; set; }
      
        [Display(Name="URL de la foto")]
        public string url_producto { get; set; }
       
        [Display(Name="Descripción de la publicación")]
        public string descripcion { get; set; }
     
        [Display(Name="Precio a pagar")]
        public double precio { get; set; }

        [Display(Name="Celular para contacto")]       
        public int celular { get; set; }
 
        [Display(Name="Lugar de compra del producto")]
        public string lugarcompraproducto { get; set; }
        
        [Display(Name="Nombre del usuario")]
        public string usuario { get; set; }
    }
}
