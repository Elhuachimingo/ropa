using System.ComponentModel.DataAnnotations;

namespace ropa.Models
{
    public class Venta
    {
        [Required]
        public string Id { get; set; }//Id de la venta
        public string Cliente { get; set; }//Cliente de la venta, no es necesario a menos que sea importante
        //public Producto ProductoNombre { get; set; }// Nombre del producto
        [Required]
        public double PrecioV { get; set; }//Precio de venta
        [Required]
        public int Cantidad { get; set; }//Cantidad vendida
    }
}