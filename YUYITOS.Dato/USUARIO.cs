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
    
    public partial class USUARIO
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CONTRASENHA { get; set; }
        public string TOKEN { get; set; }
        public int TIPO_USUARIO_ID { get; set; }
    
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
