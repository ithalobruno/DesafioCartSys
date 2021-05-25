using System.Collections.Generic;

namespace DesafioCartSys.Business.Models
{
    public partial class Cliente : Entidade
    {
        
        public string Nome { get; set; }

        public string Documento { get; set; }

        public EstadoCivil Estado_Civil { get; set; }

        public bool Ativo { get; set; }


    }
}
