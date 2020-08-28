DROP PROCEDURE IF EXISTS spexibir_produto;
DROP PROCEDURE IF EXISTS spexibir_produto_estoque;
DROP PROCEDURE IF EXISTS spbuscar_produto_estoque;
DROP PROCEDURE IF EXISTS spinserir_produto;
DROP PROCEDURE IF EXISTS speditar_produto;
DROP PROCEDURE IF EXISTS spexcluir_produto;

#############################################################
# PROCEDIMENTO PARA EXIBIR PRODUTO 
#############################################################

CREATE PROCEDURE spexibir_produto ()
SELECT ALL
ID_Produto,
NM_Produto,
DS_TipoArmazenamento
FROM tb_produto
WHERE Ativo = 1
ORDER BY NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA EXIBIR PRODUTO + ESTOQUE
#############################################################

CREATE PROCEDURE spexibir_produto_estoque ()
SELECT ALL
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(EST.QTDE_Estoque, 2, 'de_DE') AS QTDE_Estoque
FROM tb_produto AS PROD
INNER JOIN tb_estoque AS EST
ON PROD.ID_Produto = EST.ID_Produto
WHERE PROD.Ativo = 1
ORDER BY PROD.NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR PRODUTO + ESTOQUE
#############################################################

CREATE PROCEDURE spbuscar_produto_estoque (parNM_Produto VARCHAR (50))
SELECT
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(EST.QTDE_Estoque, 2, 'de_DE') AS QTDE_Estoque
FROM tb_produto AS PROD
INNER JOIN tb_estoque AS EST
ON PROD.ID_Produto = EST.ID_Produto
WHERE PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
AND PROD.Ativo = 1
ORDER BY PROD.NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR PRODUTO
#############################################################

CREATE PROCEDURE spinserir_produto (
parNM_Produto VARCHAR (50),
parDS_TipoArmazenamento VARCHAR (50))
INSERT INTO tb_produto (
NM_Produto,
DS_TipoArmazenamento,
Ativo)
VALUES (
parNM_Produto,
parDS_TipoArmazenamento,
1);

#############################################################
# PROCEDIMENTO PARA EDITAR PRODUTO
#############################################################

CREATE PROCEDURE speditar_produto (
parID_Produto INT,
parNM_Produto VARCHAR (50),
parDS_TipoArmazenamento VARCHAR (50))
UPDATE tb_produto SET
NM_Produto = parNM_Produto,
DS_TipoArmazenamento = parDS_TipoArmazenamento
WHERE ID_Produto = parID_Produto;

#############################################################
# PROCEDIMENTO PARA EXCLUIR PRODUTO
#############################################################

CREATE PROCEDURE spexcluir_produto (parID_Produto INT)
UPDATE tb_produto SET
Ativo = 0
WHERE ID_Produto = parID_Produto;