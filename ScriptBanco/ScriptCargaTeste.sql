USE studiocarolcruz;

INSERT INTO 
	tb_funcionario(
	NM_Funcionario,
	DS_Sexo,
	DT_Nascimento,
	NR_CPF,
	NR_Telefone,
	DS_Email,
	NR_CEP,
	NM_Rua,
	NR_Casa,
	NM_Bairro,
	DS_Complemento,
	NM_Cidade,
	DS_UF,
	DS_Cargo,
	VL_Salario,
	DT_Admissao)

	VALUES(
		'Caio',
		'M',
		'2001-01-08',
		43867140812,
		15974079495,
		'caio.vcruz@outlook.com',
		18076290,
		'Rubião de Almeida',
		1426,
		'Jardim São Conrado',
		'',
		'Sorocaba',
		'SP',
		'Gerente',
		7000.00,
		'2010-01-08');

INSERT INTO
	tb_login(
		DS_Usuario,
		DS_Senha,
		Ativo)

	VALUES(
		'caiovcruz',
		'cruz11',
		1);

INSERT INTO 
	tb_cliente(
		NM_Cliente,
		DS_Sexo,
		DT_Nascimento,
		NR_CPF,
		NR_Telefone,
		DS_Email,
		NR_CEP,
		NM_Rua,
		NR_Casa,
		NM_Bairro,
		DS_Complemento,
		NM_Cidade,
		DS_UF,
		Ativo)

	VALUES(
		'Caio',
		'M',
		'2001-01-08',
		43867140812,
		15974079495,
		'caio.vcruz@outlook.com',
		18076290,
		'Rubião de Almeida',
		1426,
		'Jardim São Conrado',
		'',
		'Sorocaba',
		'SP',
		1);

INSERT INTO
	tb_produto(
		NM_Produto,
		DS_TipoArmazenamento,
        Ativo)
	
	VALUES(
		'Tinta Preta',
		'Unidade(s)',
        1);

INSERT INTO
	tb_compra(
		DT_Compra,
        VL_Compra)

	VALUES(
		NOW(),
        100.00);

INSERT INTO
	tb_itemcompra(
		ID_Compra,
		ID_Produto,
        DT_Validade,
		QTDE_ItemCompra,
		VL_ItemCompra)

	VALUES(
		1,
        1,
        CURDATE(),
        10,
        100.00);

INSERT INTO
	tb_estoque(
		ID_Produto,
		QTDE_Estoque)
	
	VALUES(
		1,
		0.00);
        
INSERT INTO
	tb_lote(
		ID_Produto,
		QTDE_Lote,
        DT_Validade)
	
	VALUES(
		1,
		15.00,
        '2020-11-18');
        
INSERT INTO
	tb_lote(
		ID_Produto,
		QTDE_Lote,
        DT_Validade)
	
	VALUES(
		1,
		5.00,
        '2020-12-10');
    
        
INSERT INTO
	tb_baixaestoque(
		ID_Produto,
		QTDE_BaixaEstoque,
        DT_BaixaEstoque,
        DT_ValidadeBaixaEstoque)
	
	VALUES(
		1,
		5.00,
        NOW(),
        '2020-11-18');

INSERT INTO 
	tb_categoria(
		NM_Categoria,
		DS_Categoria)

	VALUES(
		'Cabelo',
		'Categoria para procedimentos de cabelo em geral');

INSERT INTO
	tb_procedimento(
		ID_Categoria,
		NM_Procedimento,
		DS_Procedimento,
		Ativo)

	VALUES(
		1,
		'Pintura Cabelo Longo',
		'Procedimento de pintura de cabelo longo',
		1);

INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-01-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        1220.00,
		1460.00);
        
INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-03-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        602.00,
		850.00);

INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-03-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        400.00,
		650.00);
        
INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-04-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        2220.00,
		2460.00);
        
INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-05-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        550.00,
		990.00);
        
INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-06-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        150.00,
		460.00);
        
INSERT INTO
	tb_venda(
		ID_Funcionario,
		ID_Cliente,
		DT_Venda,
		OBS_Venda,
		DS_MetodoPagamento,
        VL_Subtotal,
		VL_Lucro,
		VL_Total)

	VALUES(
		1,
		1,
		'2020-07-01',
		'Cliente já estava com química no cabelo',
		'Dinheiro',
        65.00,
        1325.00,
		1468.00);

INSERT INTO 
	tb_itemvenda(
		ID_Venda,
		ID_Procedimento,
        PR_ItemVenda,
        VL_Lucro,
		QTDE_Sessao,
		VL_Subtotal)

	VALUES(
		1,
		1,
        30.00,
        20.00,
		1,
		65.00);

INSERT INTO 
	tb_sessao(
		ID_Venda,
		ID_Procedimento,
        NR_SessaoAtual,
		QTDE_Sessao,
        DT_UltimaSessao)

	VALUES(
		1,
		1,
        2,
		5,
        NOW());

SELECT * FROM tb_sessao;
SELECT * FROM tb_itemvenda;
SELECT * FROM tb_venda;
SELECT * FROM tb_procedimento;
SELECT * FROM tb_categoria;
SELECT * FROM tb_compra;
SELECT * FROM tb_itemcompra;
SELECT * FROM tb_estoque;
SELECT * FROM tb_lote;
SELECT * FROM tb_baixaestoque;
SELECT * FROM tb_produto;
SELECT * FROM tb_login;
SELECT * FROM tb_cliente;
SELECT * FROM tb_funcionario;