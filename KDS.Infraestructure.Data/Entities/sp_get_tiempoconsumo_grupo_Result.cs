//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KDS.Infraestructure.Data.Entities
{
    using System;
    
    public partial class sp_get_tiempoconsumo_grupo_Result
    {
        public Nullable<long> row { get; set; }
        public string CodGrupo { get; set; }
        public string DescGrupo { get; set; }
        public byte Cantidad { get; set; }
        public byte MinComensales { get; set; }
        public byte MaxComensales { get; set; }
        public short Tiempo { get; set; }
        public int CodTiempoConsumo { get; set; }
    }
}
