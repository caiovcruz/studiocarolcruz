DROP PROCEDURE IF EXISTS spexibir_item_compra;
DROP PROCEDURE IF EXISTS spbuscar_nome_item_compra;
DROP PROCEDURE IF EXISTS spinserir_item_compra;
DROP PROCEDURE IF EXISTS speditar_item_compra;
DROP PROCEDURE IF EXISTS spexcluir_item_compra;

#############################################################
# PROCEDIMENTO PARA EXIBIR ITEM COMPRA
#############################################################

CREATE PROCEDURE spexibir_item_compra (parID_Compra INT)
SELECT 
ITEM.ID_Compra,
ITEM.ID_Produto,
PROD.NM_Produto,
ITEM.DT_Validade,
PROD.DS_TipoArmazenamento,
FORMAT(ITEM.QTDE_ItemCompra, 2, 'de_DE') AS QTDE_ItemCompra,
FORMAT(ITEM.VL_ItemCompra, 2, 'de_DE') AS VL_ItemCompra
FROM  tb_itemcompra AS ITEM
INNER JOIN tb_produto AS PROD
ON ITEM.ID_Produto = PROD.ID_Produto
WHERE ID_Compra = parID_Compra
ORDER BY PROD.NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR ITEM COMPRA POR NOME
#############################################################

CREATE PROCEDURE spbuscar_nome_item_compra (parNM_Produto VARCHAR (50))
SELECT
ITEM.ID_Compra,
ITEM.ID_Produto,	
PROD.NM_Produto,
ITEM.DT_Validade,
PROD.DS_TipoArmazenamento,
FORMAT(ITEM.QTDE_ItemCompra, 2, 'de_DE') AS QTDE_ItemCompra,
FORMAT(ITEM.VL_ItemCompra, 2, 'de_DE') AS VL_ItemCompra
FROM  tb_itemcompra AS ITEM
INNER JOIN tb_produto AS PROD
ON ITEM.ID_Produto = PROD.ID_Produto
WHERE PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
ORDER BY PROD.NM_Produto ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR ITEM COMPRA
#############################################################

CREATE PROCEDURE spinserir_item_compra (
parID_Compra INT,
parID_Produto INT,
parDT_Validade DATE,
parQTDE_ItemCompra INT,
parVL_ItemCompra DECIMAL (10,2))
INSERT INTO tb_itemcompra(
ID_Compra,
ID_Produto,
DT_Validade,
QTDE_ItemCompra,
VL_ItemCompra)
VALUES (
parID_Compra,
parID_Produto,
parDT_Validade,
parQTDE_ItemCompra,
parVL_ItemCompra);

#############################################################
# PROCEDIMENTO PARA EDITAR ITEM COMPRA
#############################################################

CREATE PROCEDURE speditar_item_compra (
parID_Compra INT,
parID_Produto INT,
parDT_Validade DATE,
parDT_ValidadeEditar DATE,
parQTDE_ItemCompra INT,
parVL_ItemCompra DECIMAL (10,2))
UPDATE tb_itemcompra SET
DT_Validade = parDT_ValidadeEditar,
QTDE_ItemCompra = parQTDE_ItemCompra,
VL_ItemCompra = parVL_ItemCompra
WHERE ID_Compra = parID_Compra 
AND ID_Produto = parID_Produto
AND DT_Validade = parDT_Validade;

#############################################################
# PROCEDIMENTO PARA EXCLUIR ITEM COMPRA
#############################################################

CREATE PROCEDURE spexcluir_item_compra (parID_Compra INT, parID_Produto INT, parDT_Validade DATE) 
DELETE FROM tb_itemcompra 
WHERE ID_Compra = parID_Compra
AND ID_Produto = parID_Produto
AND DT_Validade = parDT_Validade;