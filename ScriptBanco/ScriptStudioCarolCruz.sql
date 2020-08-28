DROP TABLE IF EXISTS tb_sessao;
DROP TABLE IF EXISTS tb_itemvenda;
DROP TABLE IF EXISTS tb_venda;
DROP TABLE IF EXISTS tb_procedimento;
DROP TABLE IF EXISTS tb_categoria;
DROP TABLE IF EXISTS tb_lote;
DROP TABLE IF EXISTS tb_estoque;
DROP TABLE IF EXISTS tb_itemcompra;
DROP TABLE IF EXISTS tb_compra;
DROP TABLE IF EXISTS tb_baixaestoque;
DROP TABLE IF EXISTS tb_produto;
DROP TABLE IF EXISTS tb_login;
DROP TABLE IF EXISTS tb_cliente;
DROP TABLE IF EXISTS tb_funcionario;

CREATE TABLE tb_funcionario 
(
	ID_Funcionario INT NOT NULL AUTO_INCREMENT,
	NM_Funcionario VARCHAR(50) NOT NULL,
	DS_Sexo VARCHAR(1),
	DT_Nascimento DATE NOT NULL,
	NR_CPF VARCHAR(11) NOT NULL,
	NR_Telefone VARCHAR(11) NOT NULL,
	DS_Email VARCHAR(80),
	NR_CEP VARCHAR(10),
	NM_Rua VARCHAR(50) NOT NULL,
	NR_Casa VARCHAR(5) NOT NULL,
	NM_Bairro VARCHAR(50) NOT NULL,
	DS_Complemento VARCHAR(50),
	NM_Cidade VARCHAR(40),
	DS_UF VARCHAR(2),
	DS_Cargo VARCHAR(30) NOT NULL,
	VL_Salario DECIMAL(10,2) NOT NULL,
	DT_Admissao DATE NOT NULL,
	DT_Demissao DATE,
    PRIMARY KEY (ID_Funcionario)
);

CREATE TABLE tb_cliente 
(
	ID_Cliente INT NOT NULL AUTO_INCREMENT,
	NM_Cliente VARCHAR(50) NOT NULL,
	DS_Sexo VARCHAR(1),
	DT_Nascimento DATE,
	NR_CPF VARCHAR(11),
	NR_Telefone VARCHAR(11) NOT NULL,
	DS_Email VARCHAR(80),
	NR_CEP VARCHAR(10),
	NM_Rua VARCHAR(50) NOT NULL,
	NR_Casa VARCHAR(5) NOT NULL,
	NM_Bairro VARCHAR(50) NOT NULL,
	DS_Complemento VARCHAR(50),
	NM_Cidade VARCHAR(30),
	DS_UF VARCHAR(2),
	Ativo BIT(1) NOT NULL,
	PRIMARY KEY (ID_Cliente)
);

CREATE TABLE tb_login 
(
	ID_Login INT NOT NULL AUTO_INCREMENT,
	DS_Usuario VARCHAR(20) NOT NULL,
	DS_Senha VARCHAR(20) NOT NULL,
	Ativo BIT NOT NULL,
    PRIMARY KEY (ID_Login)
);

CREATE TABLE tb_produto
(
	ID_Produto INT NOT NULL AUTO_INCREMENT,
	NM_Produto VARCHAR(50) NOT NULL,
	DS_TipoArmazenamento VARCHAR(50) NOT NULL,
    Ativo BIT NOT NULL,
    PRIMARY KEY (ID_Produto)
);

CREATE TABLE tb_compra
(
	ID_Compra INT NOT NULL AUTO_INCREMENT,
	DT_Compra DATETIME NOT NULL,
    VL_Compra DECIMAL(10,2),
	PRIMARY KEY (ID_Compra)
);

CREATE TABLE tb_itemcompra
(
	ID_Compra INT NOT NULL,
	ID_Produto INT NOT NULL,
    DT_Validade DATE,
	QTDE_ItemCompra DECIMAL(10,2) NOT NULL,
    VL_ItemCompra DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (ID_Compra, ID_Produto, DT_Validade),
    FOREIGN KEY (ID_Compra) REFERENCES tb_compra(ID_Compra) ON DELETE CASCADE,
	FOREIGN KEY (ID_Produto) REFERENCES tb_produto(ID_Produto)
);

CREATE TABLE tb_estoque
(
	ID_Produto INT NOT NULL,
	QTDE_Estoque DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (ID_Produto),
	FOREIGN KEY (ID_Produto) REFERENCES tb_produto(ID_Produto)
);

CREATE TABLE tb_lote
(
	ID_Lote INT NOT NULL AUTO_INCREMENT,
	ID_Produto INT NOT NULL,
	QTDE_Lote DECIMAL(10,2) NOT NULL,
    DT_Validade DATE NOT NULL,
	PRIMARY KEY (ID_Lote, ID_Produto),
	FOREIGN KEY (ID_Produto) REFERENCES tb_produto(ID_Produto)
);

CREATE TABLE tb_baixaestoque
(
	ID_BaixaEstoque INT NOT NULL AUTO_INCREMENT,
    ID_Produto INT NOT NULL,
    QTDE_BaixaEstoque DECIMAL(10,2) NOT NULL,
    DT_BaixaEstoque DATETIME NOT NULL,
    DT_ValidadeBaixaEstoque DATE NOT NULL,
    PRIMARY KEY (ID_BaixaEstoque),
    FOREIGN KEY (ID_Produto) REFERENCES tb_produto(ID_Produto)
);

CREATE TABLE tb_categoria
(
	ID_Categoria INT NOT NULL AUTO_INCREMENT,
	NM_Categoria VARCHAR(50) NOT NULL,
	DS_Categoria VARCHAR(1500),
    PRIMARY KEY (ID_Categoria)
);

CREATE TABLE tb_procedimento
(
	ID_Procedimento INT NOT NULL AUTO_INCREMENT,
	ID_Categoria INT NOT NULL,
	NM_Procedimento VARCHAR(50) NOT NULL,
	DS_Procedimento VARCHAR(3000) NOT NULL,
	Ativo BIT NOT NULL,
    PRIMARY KEY (ID_Procedimento),
	FOREIGN KEY (ID_Categoria) REFERENCES tb_categoria(ID_Categoria)
);

CREATE TABLE tb_venda
(
	ID_Venda INT NOT NULL AUTO_INCREMENT,
	ID_Funcionario INT NOT NULL,
	ID_Cliente INT NOT NULL,
	DT_Venda DATETIME NOT NULL,
	OBS_Venda VARCHAR(1500),
	DS_MetodoPagamento VARCHAR(20),
    VL_Subtotal DECIMAL(10,2),
	VL_Lucro DECIMAL(10,2),
    VL_Total DECIMAL(10,2),
    PRIMARY KEY (ID_Venda),
	FOREIGN KEY (ID_Cliente) REFERENCES tb_cliente(ID_Cliente),
	FOREIGN KEY (ID_Funcionario) REFERENCES tb_funcionario(ID_Funcionario)
);

CREATE TABLE tb_itemvenda
(
	ID_Venda INT NOT NULL,
	ID_Procedimento INT NOT NULL,
    PR_ItemVenda DECIMAL(10,2) NOT NULL,
    VL_Lucro DECIMAL(10,2) NOT NULL,
    QTDE_Sessao INT NOT NULL,
	VL_Subtotal DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (ID_Venda, ID_Procedimento),
	FOREIGN KEY (ID_Venda) REFERENCES tb_venda(ID_Venda) ON DELETE CASCADE,
	FOREIGN KEY (ID_Procedimento) REFERENCES tb_procedimento(ID_Procedimento)
);

CREATE TABLE tb_sessao
(
	ID_Venda INT NOT NULL,
	ID_Procedimento INT NOT NULL,
    NR_SessaoAtual INT NOT NULL,
    QTDE_Sessao INT NOT NULL,
    OBS_Sessao VARCHAR(3000),
    DT_UltimaSessao DATETIME NOT NULL,
	PRIMARY KEY (ID_Venda, ID_Procedimento),
	FOREIGN KEY (ID_Venda) REFERENCES tb_venda(ID_Venda) ON DELETE CASCADE,
	FOREIGN KEY (ID_Procedimento) REFERENCES tb_procedimento(ID_Procedimento)
);