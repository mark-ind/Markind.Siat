namespace Markind.Siat;

public interface ISolicitudRecepcionFactura
{
    byte[] Archivo { get; set; }
    string FechaEnvio { get; set; }
    string HashArchivo { get; set; }
}
