DROP PROCEDURE IF EXISTS spinserir_lote;
DROP PROCEDURE IF EXISTS speditar_lote;
DROP PROCEDURE IF EXISTS spexibir_lote;
DROP PROCEDURE IF EXISTS spbuscar_lote;
DROP PROCEDURE IF EXISTS spbuscar_lote_data;
DROP PROCEDURE IF EXISTS spbaixa_lote;
DROP PROCEDURE IF EXISTS spvalidar_lote;
DROP PROCEDURE IF EXISTS spobter_quantidade_lote;

#############################################################
# PROCEDIMENTO PARA INSERIR LOTE
#############################################################

CREATE PROCEDURE spinserir_lote (
parID_Produto INT,
parQTDE_Lote DECIMAL (10,2),
parDT_Validade DATE)
INSERT INTO tb_lote (
ID_Produto,
QTDE_Lote,
DT_Validade)
VALUES (
parID_Produto,
parQTDE_Lote,
parDT_Validade);

#############################################################
# PROCEDIMENTO PARA EDITAR LOTE
#############################################################

CREATE PROCEDURE speditar_lote (
parID_Produto INT,
parQTDE_Lote DECIMAL (10,2),
parDT_Validade DATE)
UPDATE tb_lote SET
QTDE_Lote = QTDE_Lote + parQTDE_Lote
WHERE ID_Produto = parID_Produto
AND DT_Validade = parDT_Validade;

#############################################################
# PROCEDIMENTO PARA EXIBIR LOTE
#############################################################

CREATE PROCEDURE spexibir_lote ()
SELECT ALL
ID_Lote,
ID_Produto,
QTDE_Lote,
DT_Validade
FROM tb_lote
ORDER BY ID_Lote DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR LOTE POR DATA
#############################################################

CREATE PROCEDURE spbuscar_lote_data (parID_Produto INT, parDT_Validade DATE)
SELECT ALL
ID_Lote,
ID_Produto,
QTDE_Lote,
DT_Validade
FROM tb_lote
WHERE ID_Produto = parID_Produto
AND DT_Validade = parDT_Validade
ORDER BY ID_Lote DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR LOTE
#############################################################

CREATE PROCEDURE spbuscar_lote (parID_Produto INT)
SELECT ALL
LOTE.ID_Lote,
LOTE.ID_Produto,
PROD.NM_Produto,
LOTE.QTDE_Lote,
LOTE.DT_Validade
FROM tb_lote AS LOTE
INNER JOIN tb_produto AS PROD
ON LOTE.ID_Produto = PROD.ID_Produto
WHERE LOTE.ID_Produto = parID_Produto
ORDER BY ID_Lote DESC;

#############################################################
# PROCEDIMENTO PARA BAIXA NO LOTE
#############################################################

CREATE PROCEDURE spbaixa_lote (
parID_Produto INT,
parQTDE_Lote DECIMAL (10,2),
parDT_Validade DATE)
UPDATE tb_lote SET
QTDE_Lote = QTDE_Lote - parQTDE_Lote
WHERE ID_Produto = parID_Produto
AND DT_Validade = parDT_Validade;

#############################################################
# PROCEDIMENTO PARA EXCLUIR LOTE
#############################################################

CREATE PROCEDURE spvalidar_lote ()
DELETE FROM tb_lote
WHERE QTDE_Lote <= 0;

#############################################################
# PROCEDIMENTO PARA OBTER QUANTIDADE DO LOTE
#############################################################

CREATE PROCEDURE spobter_quantidade_lote (parID_Produto INT, parDT_Validade DATE)
SELECT ALL
ID_Lote,
ID_Produto,
QTDE_Lote,
DT_Validade
FROM tb_lote
WHERE ID_Produto = parID_Produto
AND DT_Validade = parDT_Validade;