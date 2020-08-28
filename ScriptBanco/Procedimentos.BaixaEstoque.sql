DROP PROCEDURE IF EXISTS spbaixa_estoque;
DROP PROCEDURE IF EXISTS spregistrar_baixa_estoque;
DROP PROCEDURE IF EXISTS spexcluir_baixa_estoque;
DROP PROCEDURE IF EXISTS spexibir_baixa_estoque;
DROP PROCEDURE IF EXISTS spbuscar_baixa_estoque;
DROP PROCEDURE IF EXISTS spbuscar_data_baixa_estoque;
DROP PROCEDURE IF EXISTS spbuscar_produto_baixa_estoque;

#############################################################
# PROCEDIMENTO PARA BAIXA ESTOQUE
#############################################################

CREATE PROCEDURE spbaixa_estoque (
parID_Produto INT,
parQTDE_BaixaEstoque DECIMAL (10,2))
UPDATE tb_estoque SET
QTDE_Estoque = QTDE_Estoque - parQTDE_BaixaEstoque
WHERE ID_Produto = parID_Produto;

#############################################################
# PROCEDIMENTO PARA REGISTRAR BAIXA ESTOQUE
#############################################################

CREATE PROCEDURE spregistrar_baixa_estoque (
parID_Produto INT,
parQTDE_BaixaEstoque DECIMAL (10,2),
parDT_ValidadeBaixaEstoque DATE)
INSERT INTO tb_baixaestoque (
ID_Produto,
QTDE_BaixaEstoque,
DT_BaixaEstoque,
DT_ValidadeBaixaEstoque)
VALUES (
parID_Produto,
parQTDE_BaixaEstoque,
CURDATE(),
parDT_ValidadeBaixaEstoque);

#############################################################
# PROCEDIMENTO PARA EXCLUIR BAIXA ESTOQUE
#############################################################

CREATE PROCEDURE spexcluir_baixa_estoque (parID_BaixaEstoque INT)
DELETE FROM tb_baixaestoque
WHERE ID_BaixaEstoque = parID_BaixaEstoque;

#############################################################
# PROCEDIMENTO PARA EXIBIR BAIXA ESTOQUE
#############################################################

CREATE PROCEDURE spexibir_baixa_estoque ()
SELECT 
BAIXA.ID_BaixaEstoque,
BAIXA.DT_BaixaEstoque,
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(BAIXA.QTDE_BaixaEstoque, 2, 'de_DE') AS QTDE_BaixaEstoque,
BAIXA.DT_ValidadeBaixaEstoque
FROM tb_baixaestoque AS BAIXA
INNER JOIN tb_produto AS PROD
ON BAIXA.ID_Produto = PROD.ID_Produto
WHERE EXTRACT(MONTH FROM BAIXA.DT_BaixaEstoque) = EXTRACT(MONTH FROM CURDATE())
ORDER BY BAIXA.ID_BaixaEstoque DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR BAIXA ESTOQUE
#############################################################

CREATE PROCEDURE spbuscar_baixa_estoque (DataInicio DATE, DataFinal DATE, parNM_Produto VARCHAR(50))
SELECT 
BAIXA.ID_BaixaEstoque,
BAIXA.DT_BaixaEstoque,
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(BAIXA.QTDE_BaixaEstoque, 2, 'de_DE') AS QTDE_BaixaEstoque,
BAIXA.DT_ValidadeBaixaEstoque
FROM tb_baixaestoque AS BAIXA
INNER JOIN tb_produto AS PROD
ON BAIXA.ID_Produto = PROD.ID_Produto
WHERE BAIXA.DT_BaixaEstoque BETWEEN DataInicio AND DataFinal
AND PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
ORDER BY BAIXA.ID_BaixaEstoque DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR BAIXA ESTOQUE POR DATA
#############################################################

CREATE PROCEDURE spbuscar_data_baixa_estoque (DataInicio DATE, DataFinal DATE)
SELECT 
BAIXA.ID_BaixaEstoque,
BAIXA.DT_BaixaEstoque,
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(BAIXA.QTDE_BaixaEstoque, 2, 'de_DE') AS QTDE_BaixaEstoque,
BAIXA.DT_ValidadeBaixaEstoque
FROM tb_baixaestoque AS BAIXA
INNER JOIN tb_produto AS PROD
ON BAIXA.ID_Produto = PROD.ID_Produto
WHERE BAIXA.DT_BaixaEstoque BETWEEN DataInicio AND DataFinal
ORDER BY BAIXA.ID_BaixaEstoque DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR BAIXA ESTOQUE POR PRODUTO
#############################################################

CREATE PROCEDURE spbuscar_produto_baixa_estoque (parNM_Produto VARCHAR(50))
SELECT 
BAIXA.ID_BaixaEstoque,
BAIXA.DT_BaixaEstoque,
PROD.ID_Produto,
PROD.NM_Produto,
PROD.DS_TipoArmazenamento,
FORMAT(BAIXA.QTDE_BaixaEstoque, 2, 'de_DE') AS QTDE_BaixaEstoque,
BAIXA.DT_ValidadeBaixaEstoque
FROM tb_baixaestoque AS BAIXA
INNER JOIN tb_produto AS PROD
ON BAIXA.ID_Produto = PROD.ID_Produto
WHERE PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
AND EXTRACT(MONTH FROM BAIXA.DT_BaixaEstoque) = EXTRACT(MONTH FROM CURDATE())
ORDER BY BAIXA.ID_BaixaEstoque DESC;