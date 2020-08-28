DROP PROCEDURE IF EXISTS spexibir_item_venda;
DROP PROCEDURE IF EXISTS spbuscar_nome_item_venda;
DROP PROCEDURE IF EXISTS spinserir_item_venda;
DROP PROCEDURE IF EXISTS speditar_item_venda;
DROP PROCEDURE IF EXISTS spexcluir_item_venda;

#############################################################
# PROCEDIMENTO PARA EXIBIR ITEM VENDA
#############################################################

CREATE PROCEDURE spexibir_item_venda (parID_Venda INT)
SELECT 
ITEM.ID_Venda,
ITEM.ID_Procedimento,
CAT.NM_Categoria,
PROC.NM_Procedimento,
PROC.DS_Procedimento,
ITEM.QTDE_Sessao,
FORMAT(ITEM.PR_ItemVenda, 2, 'de_DE') AS PR_ItemVenda,
FORMAT(ITEM.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(ITEM.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal
FROM  tb_itemvenda AS ITEM
INNER JOIN tb_procedimento AS PROC
ON ITEM.ID_Procedimento = PROC.ID_Procedimento
INNER JOIN tb_categoria AS CAT
ON PROC.ID_Categoria = CAT.ID_Categoria
WHERE ITEM.ID_Venda = parID_Venda
ORDER BY PROC.NM_Procedimento ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR ITEM VENDA
#############################################################

CREATE PROCEDURE spbuscar_nome_item_venda (parNM_Procedimento VARCHAR (50))
SELECT
ITEM.ID_Venda,
ITEM.ID_Procedimento,
CAT.NM_Categoria,
PROC.NM_Procedimento,
PROC.DS_Procedimento,
ITEM.QTDE_Sessao,
FORMAT(ITEM.PR_ItemVenda, 2, 'de_DE') AS PR_ItemVenda,
FORMAT(ITEM.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(ITEM.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal
FROM  tb_itemvenda AS ITEM
INNER JOIN tb_procedimento AS PROC
ON ITEM.ID_Procedimento = PROC.ID_Procedimento
INNER JOIN tb_categoria AS CAT
ON PROC.ID_Categoria = CAT.ID_Categoria
WHERE PROC.NM_Procedimento LIKE CONCAT(parNM_Procedimento, '%')
ORDER BY PROC.NM_Procedimento ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR ITEM VENDA
#############################################################

CREATE PROCEDURE spinserir_item_venda (
parID_Venda INT,
parID_Procedimento INT,
parPR_ItemVenda DECIMAL (10,2),
parVL_Lucro DECIMAL (10,2),
parQTDE_Sessao INT,
parVL_Subtotal DECIMAL (10,2))
INSERT INTO tb_itemvenda(
ID_Venda,
ID_Procedimento,
PR_ItemVenda,
VL_Lucro,
QTDE_Sessao,
VL_Subtotal)
VALUES (
parID_Venda,
parID_Procedimento,
parPR_ItemVenda,
parVL_Lucro,
parQTDE_Sessao,
parVL_Subtotal);

#############################################################
# PROCEDIMENTO PARA EDITAR ITEM VENDA
#############################################################

CREATE PROCEDURE speditar_item_venda (
parID_Venda INT,
parID_Procedimento INT,
parPR_ItemVenda DECIMAL (10,2),
parVL_Lucro DECIMAL (10,2),
parQTDE_Sessao INT,
parVL_Subtotal DECIMAL (10,2))
UPDATE tb_itemvenda SET
ID_Procedimento = parID_Procedimento,
PR_ItemVenda = parPR_ItemVenda,
VL_Lucro = parVL_Lucro,
QTDE_Sessao = parQTDE_Sessao,
VL_Subtotal = parVL_Subtotal
WHERE ID_Venda = parID_Venda AND
ID_Procedimento = parID_Procedimento;

#############################################################
# PROCEDIMENTO PARA EXCLUIR ITEM VENDA
#############################################################

CREATE PROCEDURE spexcluir_item_venda (parID_Venda INT, parID_Procedimento INT)
DELETE FROM tb_itemvenda 
WHERE ID_Venda = parID_Venda
AND ID_Procedimento = parID_Procedimento;