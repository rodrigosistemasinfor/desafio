import { DomainBase } from "../domain/base/base.domain";

export class UsuarioModel extends DomainBase {
  
  
    public Nome: string;
    public CPF: string;
    public RG: string;
    public DataNacimento: Date;
    public NomeMae: string;
    public NomePai: string
    public DataCadastro: Date;


  constructor(data: any = {}) {
    super();

    if (data == null) {
      data = {};
    }

    this.Nome = data.nome || data.Nome;
    this.CPF = data.cpf || data.CPF;
    this.RG = data.rg || data.RG;
    this.DataNacimento = data.dataNacimento || data.DataNacimento;
    this.NomeMae = data.nomeMae || data.NomeMae;
    this.NomePai = data.nomePai || data.NomePai;
    this.DataCadastro = data.dataCadastro || data.DataCadastro;
  }
}
