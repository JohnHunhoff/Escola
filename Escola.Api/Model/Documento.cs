using Escola.Api.Model.Enums;

namespace Escola.Api.Model
{
    public class Documento
    {
        public string Id { get; set; }
        public DocumentoTipo Tipo { get; set; }
        public string Numero { get; set; }
    }
}