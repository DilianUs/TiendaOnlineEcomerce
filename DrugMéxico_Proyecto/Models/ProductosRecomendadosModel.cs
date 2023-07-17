namespace DrugMéxico_Proyecto.Models
{
    public class ProductosRecomendadosModel
    {
        public int id { get; set; }
        public int id_producto { get; set; }
        public int precio_producto { get; set; }
        public int precio_producto_rebajado { get; set; }
        public string imagen { get; set; }
        public string nombre { get; set; }
    }
}
