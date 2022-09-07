using Mapster;
using Markind.Siat.Generated.FacturacionCodigos;

namespace Markind.Siat;

public class Message
{
    public int? codigoAmbiente { get; set; }
    public string? codigoSistema { get; set; }
    public long? Nit { get; set; }
    public int? codigoPuntoVenta { get; set; }
    public int? codigoSucursal { get; set; }
    public string? cuis { get; set; }
    public int? codigoModalidad {get; set;}
    public string? certificado {get;set;}
    public DateTime? fechaRevocacion {get; set;}
    public long? nitParaVerificacion {get; set;}
}