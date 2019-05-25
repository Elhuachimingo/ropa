using System;

namespace ropa.Models
{
    public class Producto
    {
        public string Id { get; set; }//id del producto
        public string Nombre { get; set; }//Nombre del producto
        public double PrecioC { get; set; }//Precio de compra del producto
        public int Cantidad { get; set; }//Cantidad en el inventario
        public string Desc { get; set; }//Descripcion del producto
        public string Color1 { get; set; }//Color primario
        public string Color2 { get; set; }//Color secundario
        public string Foto { get; set; }//Foto del producto
        //public venta ventaid { get; set; }
        //public string venta { get; set; }
    }
}