DROP PROCEDURE IF EXISTS spexibir_estoque;
DROP PROCEDURE IF EXISTS spbuscar_produto_estoque;
DROP PROCEDURE IF EXISTS spinserir_estoque;
DROP PROCEDURE IF EXISTS speditar_estoque;
DROP PROCEDURE IF EXISTS spexcluir_estoque;

#############################################################
# PROCEDIMENTO PARA EXIBIR ESTOQUE
#############################################################

CREATE PROCEDURE spexibir_estoque ()
SELECT 
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(EST.QTDE_Estoque, 2, 'de_DE') AS QTDE_Estoque
FROM tb_estoque AS EST
INNER JOIN tb_produto AS PROD
ON EST.ID_Produto = PROD.ID_Produto
ORDER BY PROD.NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR ESTOQUE
#############################################################

CREATE PROCEDURE spbuscar_produto_estoque (parNM_Produto VARCHAR (50))
SELECT 
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(EST.QTDE_Estoque, 2, 'de_DE') AS QTDE_Estoque
FROM tb_estoque AS EST
INNER JOIN tb_produto AS PROD
ON EST.ID_Produto = PROD.ID_Produto
WHERE PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
ORDER BY PROD.NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR ESTOQUE
#############################################################

CREATE PROCEDURE spinserir_estoque (
parID_Produto INT,
parQTDE_Estoque DECIMAL (10,2))
INSERT INTO tb_estoque (
ID_Produto,
QTDE_Estoque)
VALUES (
parID_Produto,
parQTDE_Estoque);

#############################################################
# PROCEDIMENTO PARA EDITAR ESTOQUE
#############################################################

CREATE PROCEDURE speditar_estoque (
parID_Produto INT,
parQTDE_Estoque DECIMAL (10,2))
UPDATE tb_estoque SET
QTDE_Estoque = QTDE_Estoque + parQTDE_Estoque
WHERE ID_Produto = parID_Produto;

#############################################################
# PROCEDIMENTO PARA EXCLUIR ESTOQUE
#############################################################

CREATE PROCEDURE spexcluir_estoque (parID_Produto INT)
DELETE FROM tb_estoque
WHERE ID_Produto = parID_Produto;