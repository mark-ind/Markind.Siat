namespace Markind.Siat;

public abstract class SolicitudFacturacion : SolicitudServicio
{
    public DocumentoSector CodigoDocumentoSector { get; set; }
    public TipoEmision CodigoEmision { get; set; }
    public Modalidad CodigoModalidad { get; set; }
    public required string Cufd { get; set; }
    public required string Cuis { get; set; }
    public TipoFactura TipoFacturaDocumento { get; set; }
}