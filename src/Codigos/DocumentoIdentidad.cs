namespace Markind.Siat;

public enum DocumentoIdentidad : byte
{
    Ninguno = 0,
    CarnetDeIdentidad = 1,
    CarnetDeIdentidadDeExtranjero = 2,
    Pasaporte = 3,
    OtroDocumentoDeIdentidad = 4,
    NumeroDeIdentificacionTributaria = 5,
}