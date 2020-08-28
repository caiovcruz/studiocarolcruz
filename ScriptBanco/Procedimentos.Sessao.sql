DROP PROCEDURE IF EXISTS spexibir_sessao;
DROP PROCEDURE IF EXISTS spexibir_sessao_disponivel;
DROP PROCEDURE IF EXISTS spbuscar_cliente_sessao_disponivel;
DROP PROCEDURE IF EXISTS spbuscar_cliente_sessao;
DROP PROCEDURE IF EXISTS spbuscar_procedimento_sessao_disponivel;
DROP PROCEDURE IF EXISTS spbuscar_procedimento_sessao;
DROP PROCEDURE IF EXISTS spinserir_sessao;
DROP PROCEDURE IF EXISTS speditar_sessao;
DROP PROCEDURE IF EXISTS spexcluir_sessao;

#############################################################
# PROCEDIMENTO PARA EXIBIR TODAS SESSÕES
#############################################################

CREATE PROCEDURE spexibir_sessao ()
SELECT ALL
SES.ID_Venda,
SES.ID_Procedimento,
CLI.NM_Cliente,
PROC.NM_Procedimento,
SES.NR_SessaoAtual,
SES.QTDE_Sessao,
SES.OBS_Sessao,
SES.DT_UltimaSessao
FROM tb_sessao AS SES
INNER JOIN tb_venda AS VEN
ON SES.ID_Venda = VEN.ID_Venda
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_procedimento AS PROC
ON SES.ID_Procedimento = PROC.ID_Procedimento
ORDER BY SES.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA EXIBIR SESSÕES DISPONÍVEIS
#############################################################

CREATE PROCEDURE spexibir_sessao_disponivel ()
SELECT ALL
SES.ID_Venda,
SES.ID_Procedimento,
CLI.NM_Cliente,
PROC.NM_Procedimento,
SES.NR_SessaoAtual,
SES.QTDE_Sessao,
SES.OBS_Sessao,
SES.DT_UltimaSessao
FROM tb_sessao AS SES
INNER JOIN tb_venda AS VEN
ON SES.ID_Venda = VEN.ID_Venda
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_procedimento AS PROC
ON SES.ID_Procedimento = PROC.ID_Procedimento
WHERE SES.QTDE_Sessao > SES.NR_SessaoAtual
ORDER BY SES.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR CLIENTE SESSÃO DISPONÍVEL
#############################################################

CREATE PROCEDURE spbuscar_cliente_sessao_disponivel (parNM_Cliente VARCHAR(50))
SELECT ALL
SES.ID_Venda,
SES.ID_Procedimento,
CLI.NM_Cliente,
PROC.NM_Procedimento,
SES.NR_SessaoAtual,
SES.QTDE_Sessao,
SES.OBS_Sessao,
SES.DT_UltimaSessao
FROM tb_sessao AS SES
INNER JOIN tb_venda AS VEN
ON SES.ID_Venda = VEN.ID_Venda
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_procedimento AS PROC
ON SES.ID_Procedimento = PROC.ID_Procedimento
WHERE CLI.NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
AND QTDE_Sessao > NR_SessaoAtual
ORDER BY SES.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR CLIENTE SESSÃO
#############################################################

CREATE PROCEDURE spbuscar_cliente_sessao (parNM_Cliente VARCHAR(50))
SELECT ALL
SES.ID_Venda,
SES.ID_Procedimento,
CLI.NM_Cliente,
PROC.NM_Procedimento,
SES.NR_SessaoAtual,
SES.QTDE_Sessao,
SES.OBS_Sessao,
SES.DT_UltimaSessao
FROM tb_sessao AS SES
INNER JOIN tb_venda AS VEN
ON SES.ID_Venda = VEN.ID_Venda
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_procedimento AS PROC
ON SES.ID_Procedimento = PROC.ID_Procedimento
WHERE CLI.NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
ORDER BY SES.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR PROCEDIMENTO SESSÃO DISPONÍVEL
#############################################################

CREATE PROCEDURE spbuscar_procedimento_sessao_disponivel (parNM_Procedimento VARCHAR(50))
SELECT ALL
SES.ID_Venda,
SES.ID_Procedimento,
CLI.NM_Cliente,
PROC.NM_Procedimento,
SES.NR_SessaoAtual,
SES.QTDE_Sessao,
SES.OBS_Sessao,
SES.DT_UltimaSessao
FROM tb_sessao AS SES
INNER JOIN tb_venda AS VEN
ON SES.ID_Venda = VEN.ID_Venda
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_procedimento AS PROC
ON SES.ID_Procedimento = PROC.ID_Procedimento
WHERE PROC.NM_Procedimento LIKE CONCAT(parNM_Procedimento, '%')
AND QTDE_Sessao > NR_SessaoAtual
ORDER BY SES.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA BUSCAR PROCEDIMENTO SESSÃO
#############################################################

CREATE PROCEDURE spbuscar_procedimento_sessao (parNM_Procedimento VARCHAR(50))
SELECT ALL
SES.ID_Venda,
SES.ID_Procedimento,
CLI.NM_Cliente,
PROC.NM_Procedimento,
SES.NR_SessaoAtual,
SES.QTDE_Sessao,
SES.OBS_Sessao,
SES.DT_UltimaSessao
FROM tb_sessao AS SES
INNER JOIN tb_venda AS VEN
ON SES.ID_Venda = VEN.ID_Venda
INNER JOIN tb_cliente AS CLI
ON VEN.ID_Cliente = CLI.ID_Cliente
INNER JOIN tb_procedimento AS PROC
ON SES.ID_Procedimento = PROC.ID_Procedimento
WHERE PROC.NM_Procedimento LIKE CONCAT(parNM_Procedimento, '%')
ORDER BY SES.ID_Venda DESC;

#############################################################
# PROCEDIMENTO PARA INSERIR SESSÃO
#############################################################

CREATE PROCEDURE spinserir_sessao (
parID_Venda INT,
parID_Procedimento INT,
parQTDE_Sessao INT)
INSERT INTO tb_sessao(
ID_Venda,
ID_Procedimento,
NR_SessaoAtual,
QTDE_Sessao,
DT_UltimaSessao)
VALUES (
parID_Venda,
parID_Procedimento,
1,
parQTDE_Sessao,
NOW());

#############################################################
# PROCEDIMENTO PARA EDITAR SESSÃO
#############################################################

CREATE PROCEDURE speditar_sessao (
parID_Venda INT,
parID_Procedimento INT,
parNR_SessaoAtual INT,
parQTDE_Sessao INT,
parOBS_Sessao VARCHAR(3000))
UPDATE tb_sessao SET
ID_Venda = parID_Venda,
ID_Procedimento = parID_Procedimento,
NR_SessaoAtual = parNR_SessaoAtual,
QTDE_Sessao = parQTDE_Sessao,
OBS_Sessao = parOBS_Sessao,
DT_UltimaSessao = NOW()
WHERE ID_Venda = parID_Venda
AND ID_Procedimento = parID_Procedimento;

#############################################################
# PROCEDIMENTO PARA EXCLUIR SESSÃO
#############################################################

CREATE PROCEDURE spexcluir_sessao (parID_Venda INT, parID_Procedimento INT)
DELETE FROM tb_sessao
WHERE ID_Venda = parID_Venda
AND ID_Procedimento = parID_Procedimento;