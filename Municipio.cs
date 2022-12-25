    public class MunicipioModelo
    {
        public int IdMunicipio { get; protected set; }
        public string Nome { get; protected set; }
        public int IdUF { get; protected set; }
        public UF UF { get; protected set; }

        protected MunicipioModelo()
        {
        }

        public MunicipioModelo(int idMunicipio, string nome, UF uf)
        {
            IdMunicipio = idMunicipio;
            Nome = nome;
            IdUF = uf.IdUF;
            UF = uf;
        }
    }
