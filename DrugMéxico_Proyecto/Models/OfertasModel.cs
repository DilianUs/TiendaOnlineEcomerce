using System.Collections.Generic;

namespace DrugMéxico_Proyecto.Models
{
    public class OfertasModel
    {
        public int Id { get; set; }
        public int Id_producto { get; set; }
        public double Precio_producto { get; set; }
        public double Precio_producto_rebajado { get; set; } 
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public List<OfertasModel> Ofertas { get; set;}
    }
}
