namespace Markind.Siat;

public enum TipoRegistroCompra : short
{
    Ninguno = 0,
    Confirmada = 1,
    RegistradaPorDiferenciaDeMontos = 2,
    RegistradaPorDiferenciaDeFechas = 3,
    RegistradaSinRegistroPrevio = 4,
    RegistradaAnulada = 5,
    Acreditable = 6,
    RegistradaConNumeroDeDocumentoDiferente = 7,
}