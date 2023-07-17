namespace DrugMéxico_Proyecto.Models
{
    public class CarritoModel
    {
        public int idCarrito { get; set; }
        public int idUsuario { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }
        public string sku { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string imagen { get; set; }
    }
}
