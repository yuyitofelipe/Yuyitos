//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YUYITOS.Dato
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_ORDEN
    {
        public int ID_DETALLE_ORDEN { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal ORDEN_ID { get; set; }
        public int CANT_DETALLE_O { get; set; }
        public string ESTADO_DET_ORDEN { get; set; }
        public int PRODUCTO_PROVEEDOR_ID { get; set; }
    
        public virtual ORDEN ORDEN { get; set; }
        public virtual PRODUCTO_PROVEEDOR PRODUCTO_PROVEEDOR { get; set; }
    }
}
