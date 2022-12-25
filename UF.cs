  public class UF
  {
      public int IdUF { get; protected set; }
      public string Sigla { get; protected set; }
      public string Nome { get; protected set; }

      protected UFModelo()
      {
      }

      public UFModelo(int idUf, string sigla, string nome)
      {
          IdUF = idUf;
          Sigla = sigla;
          Nome = nome;
      }

      public virtual IList<Municipio> Municipios { get; protected set; }
  }
