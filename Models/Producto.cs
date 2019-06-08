using System.ComponentModel.DataAnnotations;

namespace ropa.Models
{
    public class Producto
    {
        public int Id { get; set; }//id del producto
        [Required]
        public string Nombre { get; set; }//Nombre del producto
        [Required]
        public double PrecioC { get; set; }//Precio de compra del producto
        [Required]
        public int Cantidad { get; set; }//Cantidad en el inventario
        [Required]

        public string Desc { get; set; }//Descripcion del producto
        public string Color1 { get; set; }//Color primario
        [Required]

        public string Color2 { get; set; }//Color secundario
        public string Foto { get; set; }//Foto del producto

        //public venta ventaid { get; set; }
        //public string venta { get; set; }
    }
}