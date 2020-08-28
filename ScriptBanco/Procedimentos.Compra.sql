DROP PROCEDURE IF EXISTS spexibir_compra;
DROP PROCEDURE IF EXISTS spbuscar_compra;
DROP PROCEDURE IF EXISTS spbuscar_data_compra;
DROP PROCEDURE IF EXISTS spbuscar_produto_compra;
DROP PROCEDURE IF EXISTS spinserir_compra;
DROP PROCEDURE IF EXISTS spfinalizar_compra;
DROP PROCEDURE IF EXISTS spexcluir_compra;
DROP PROCEDURE IF EXISTS spvalidar_compra;

#############################################################
# PROCEDIMENTO PARA EXIBIR COMPRA
#############################################################

CREATE PROCEDURE spexibir_compra ()
SELECT ALL
COM.ID_Compra,
COM.DT_Compra,
FORMAT(COM.VL_Compra, 2, 'de_DE') AS VL_Compra
FROM tb_compra AS COM
WHERE EXTRACT(MONTH FROM COM.DT_Compra) = EXTRACT(MONTH FROM CURDATE())
ORDER BY ID_Compra DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR COMPRA
#############################################################

CREATE PROCEDURE spbuscar_compra (DataInicio DATE, DataFinal DATE, parNM_Produto VARCHAR(50))
SELECT 
COM.ID_Compra,
COM.DT_Compra,
FORMAT(COM.VL_Compra, 2, 'de_DE') AS VL_Compra
FROM tb_compra AS COM
INNER JOIN tb_itemcompra AS ITEM
ON COM.ID_Compra = ITEM.ID_Compra
INNER JOIN tb_produto AS PROD
ON ITEM.ID_Produto = PROD.ID_Produto
WHERE COM.DT_Compra BETWEEN DataInicio AND DataFinal
AND PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
ORDER BY COM.ID_Compra DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR COMPRA POR DATA
#############################################################

CREATE PROCEDURE spbuscar_data_compra (DataInicio DATE, DataFinal DATE)
SELECT 
COM.ID_Compra,
COM.DT_Compra,
FORMAT(COM.VL_Compra, 2, 'de_DE') AS VL_Compra
FROM tb_compra AS COM
WHERE COM.DT_Compra BETWEEN DataInicio AND DataFinal
ORDER BY COM.ID_Compra DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR COMPRA POR PRODUTO
#############################################################

CREATE PROCEDURE spbuscar_produto_compra (parNM_Produto VARCHAR(50))
SELECT 
COM.ID_Compra,
COM.DT_Compra,
FORMAT(COM.VL_Compra, 2, 'de_DE') AS VL_Compra
FROM tb_compra AS COM
INNER JOIN tb_itemcompra AS ITEM
ON COM.ID_Compra = ITEM.ID_Compra
INNER JOIN tb_produto AS PROD
ON ITEM.ID_Produto = PROD.ID_Produto
WHERE PROD.NM_Produto LIKE CONCAT(parNM_Produto, '%')
AND EXTRACT(MONTH FROM COM.DT_Compra) = EXTRACT(MONTH FROM CURDATE())
ORDER BY COM.ID_Compra DESC;

#############################################################
# PROCEDIMENTO PARA INSERIR COMPRA
#############################################################

CREATE PROCEDURE spinserir_compra ()
INSERT INTO tb_compra (
DT_Compra)
VALUES (
NOW());

#############################################################
# PROCEDIMENTO PARA FINALIZAR COMPRA
#############################################################

CREATE PROCEDURE spfinalizar_compra (parID_Compra INT, parVL_Compra DECIMAL (10,2))
UPDATE tb_compra SET
VL_Compra = parVL_Compra
WHERE ID_Compra = parID_Compra;

#############################################################
# PROCEDIMENTO PARA EXCLUIR COMPRA
#############################################################

CREATE PROCEDURE spexcluir_compra (parID_Compra INT)
DELETE FROM tb_compra 
WHERE ID_Compra = parID_Compra;

#############################################################
# PROCEDIMENTO PARA VALIDAR COMPRA
#############################################################

CREATE PROCEDURE spvalidar_compra ()
DELETE FROM tb_compra 
WHERE VL_Compra IS NULL;