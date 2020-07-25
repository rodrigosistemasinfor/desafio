USE TESTE

CREATE TABLE dbo.Usuario (
	Id int IDENTITY NOT NULL PRIMARY KEY,
	Nome varchar(100) NOT NULL,
    CPF varchar(14) NOT NULL UNIQUE,
    RG varchar(20) NOT NULL UNIQUE,
    DataNacimento datetime NOT NULL,
    NomeMae varchar(100),
    NomePai varchar(100),
    DataCadastro  datetime NOT NULL DEFAULT GETDATE()
)