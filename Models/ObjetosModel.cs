using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    public class ObjetosModel
    {
        public int ObjetoId { get; set; }

        public string ObjetoNome { get; set; } = string.Empty;

        public string ObjetoCor { get; set; } = string.Empty;

        public string ObjetoObservacao { get; set; } = string.Empty;

        public string ObjetoLocalDesaparecimeto { get; set; } = string.Empty;

        public string? ObjetoFoto { get; set; }

        public DateTime ObjetoDtDesaparecimeto { get; set; }

        public DateTime? ObjetoDtEncontro { get; set; }

        public byte ObjetoStatus { get; set; }

        public int UsuarioId { get; set; }

    }
}
