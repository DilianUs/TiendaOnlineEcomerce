namespace DrugMéxico_Proyecto.Models
{
    public class ProductoModel
    {
        public int tbProductosId { get; set; }
        public string sku { get; set; }
        public string nombre { get; set; }
        public int visibilidad { get; set; }
        public string descripcion_corta { get; set; }
        public string descripcion { get; set; }
        public int inventario { get; set; }

        public double precio_rebajado { get; set; }
        public double precio_normal { get; set; }

        public string marca { get; set; }
        public int monedero { get; set; }
        public string categoria { get; set; }

        public string imagenes { get; set; }



    }
}
