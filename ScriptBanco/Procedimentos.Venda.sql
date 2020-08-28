DROP PROCEDURE IF EXISTS spexibir_venda_ano;
DROP PROCEDURE IF EXISTS spexibir_venda_mes;
DROP PROCEDURE IF EXISTS spbuscar_venda;
DROP PROCEDURE IF EXISTS spbuscar_data_venda;
DROP PROCEDURE IF EXISTS spbuscar_cliente_venda;
DROP PROCEDURE IF EXISTS spbuscar_funcionario_venda;
DROP PROCEDURE IF EXISTS spbuscar_data_cliente_venda;
DROP PROCEDURE IF EXISTS spbuscar_data_funcionario_venda;
DROP PROCEDURE IF EXISTS spbuscar_funcionario_cliente_venda;
DROP PROCEDURE IF EXISTS spinserir_venda;
DROP PROCEDURE IF EXISTS speditar_venda;
DROP PROCEDURE IF EXISTS spexcluir_venda;
DROP PROCEDURE IF EXISTS spvalidar_venda;

#############################################################
# PROCEDIMENTO PARA EXIBIR VENDA ANO
#############################################################

CREATE PROCEDURE spexibir_venda_ano ()
SELECT ALL
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE EXTRACT(YEAR FROM VEN.DT_Venda) = EXTRACT(YEAR FROM CURDATE())
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA EXIBIR VENDA MÊS
#############################################################

CREATE PROCEDURE spexibir_venda_mes ()
SELECT ALL
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE EXTRACT(MONTH FROM VEN.DT_Venda) = EXTRACT(MONTH FROM CURDATE())
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR DATA, CLIENTE E FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spbuscar_venda (DataInicio DATE, DataFinal DATE, parNM_Cliente VARCHAR(50), parID_Funcionario INT)
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE VEN.DT_Venda BETWEEN DataInicio AND DataFinal
AND CLI.NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
AND VEN.ID_Funcionario = parID_Funcionario
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR DATA
#############################################################

CREATE PROCEDURE spbuscar_data_venda (DataInicio DATE, DataFinal DATE)
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE VEN.DT_Venda BETWEEN DataInicio AND DataFinal
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR CLIENTE
#############################################################

CREATE PROCEDURE spbuscar_cliente_venda (parNM_Cliente VARCHAR(50))
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE CLI.NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
AND EXTRACT(MONTH FROM VEN.DT_Venda) = EXTRACT(MONTH FROM CURDATE())
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spbuscar_funcionario_venda (parID_Funcionario INT)
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE VEN.ID_Funcionario = parID_Funcionario
AND EXTRACT(MONTH FROM VEN.DT_Venda) = EXTRACT(MONTH FROM CURDATE())
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR DATA E CLIENTE
#############################################################

CREATE PROCEDURE spbuscar_data_cliente_venda (DataInicio DATE, DataFinal DATE, parNM_Cliente VARCHAR(50))
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE VEN.DT_Venda BETWEEN DataInicio AND DataFinal
AND CLI.NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR DATA E FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spbuscar_data_funcionario_venda (DataInicio DATE, DataFinal DATE, parID_Funcionario INT)
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE VEN.DT_Venda BETWEEN DataInicio AND DataFinal
AND VEN.ID_Funcionario = parID_Funcionario
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR VENDA POR DATA, CLIENTE E FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spbuscar_funcionario_cliente_venda (parNM_Cliente VARCHAR(50), parID_Funcionario INT)
SELECT 
VEN.ID_Venda,
VEN.DT_Venda,
FUN.NM_Funcionario,
CLI.NM_Cliente,
VEN.OBS_Venda,
VEN.DS_MetodoPagamento,
FORMAT(VEN.VL_Subtotal, 2, 'de_DE') AS VL_Subtotal,
FORMAT(VEN.VL_Lucro, 2, 'de_DE') AS VL_Lucro,
FORMAT(VEN.VL_Total, 2, 'de_DE') AS VL_Total
FROM tb_venda AS VEN
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_funcionario AS FUN
ON VEN.ID_Funcionario = FUN.ID_Funcionario
WHERE CLI.NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
AND VEN.ID_Funcionario = parID_Funcionario
AND EXTRACT(MONTH FROM VEN.DT_Venda) = EXTRACT(MONTH FROM CURDATE())
ORDER BY VEN.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA INSERIR VENDA
#############################################################

CREATE PROCEDURE spinserir_venda (
parID_Funcionario INT,
parID_Cliente INT)
INSERT INTO tb_venda(
ID_Funcionario,
ID_Cliente,
DT_Venda)
VALUES (
parID_Funcionario,
parID_Cliente,
NOW());

#############################################################
# PROCEDIMENTO PARA EDITAR VENDA
#############################################################

CREATE PROCEDURE speditar_venda (
parID_Venda INT,
parID_Funcionario INT,
parID_Cliente INT,
parOBS_Venda VARCHAR (1500),
parDS_MetodoPagamento VARCHAR(20),
parVL_Subtotal DECIMAL (10,2),
parVL_Lucro DECIMAL (10,2),
parVL_Total DECIMAL (10,2))
UPDATE TB_Venda SET
ID_Funcionario = parID_Funcionario,
ID_Cliente = parID_Cliente,
DT_Venda = NOW(),
OBS_Venda = parOBS_Venda,
DS_MetodoPagamento = parDS_MetodoPagamento,
VL_Subtotal = parVL_Subtotal,
VL_Lucro = parVL_Lucro,
VL_Total = parVL_Total
WHERE ID_Venda = parID_Venda;

#############################################################
# PROCEDIMENTO PARA EXCLUIR VENDA
#############################################################

CREATE PROCEDURE spexcluir_venda (parID_Venda INT)
DELETE FROM tb_venda
WHERE ID_Venda = parID_Venda;

#############################################################
# PROCEDIMENTO PARA VALIDAR VENDA
#############################################################

CREATE PROCEDURE spvalidar_venda ()
DELETE FROM tb_venda 
WHERE VL_Total IS NULL;