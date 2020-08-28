DROP PROCEDURE IF EXISTS spexibir_procedimento;
DROP PROCEDURE IF EXISTS spbuscar_procedimento;
DROP PROCEDURE IF EXISTS spbuscar_nome_procedimento;
DROP PROCEDURE IF EXISTS spbuscar_categoria_procedimento;
DROP PROCEDURE IF EXISTS spinserir_procedimento;
DROP PROCEDURE IF EXISTS speditar_procedimento;
DROP PROCEDURE IF EXISTS spexcluir_procedimento;

#############################################################
# PROCEDIMENTO PARA EXIBIR PROCEDIMENTO
#############################################################

CREATE PROCEDURE spexibir_procedimento ()
SELECT ALL
PROC.ID_Procedimento,
CAT.NM_Categoria,
PROC.NM_Procedimento,
PROC.DS_Procedimento
FROM tb_procedimento AS PROC
INNER JOIN tb_categoria AS CAT
ON PROC.ID_Categoria = CAT.ID_Categoria
WHERE PROC.Ativo = 1
ORDER BY PROC.NM_Procedimento ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR PROCEDIMENTO
#############################################################

CREATE PROCEDURE spbuscar_procedimento (parID_Categoria INT, parNM_Procedimento VARCHAR (50))
SELECT
PROC.ID_Procedimento,
CAT.NM_Categoria,
PROC.NM_Procedimento,
PROC.DS_Procedimento
FROM tb_procedimento AS PROC
INNER JOIN tb_categoria AS CAT
ON PROC.ID_Categoria = CAT.ID_Categoria 
WHERE PROC.Ativo = 1
AND PROC.ID_Categoria = parID_Categoria
AND PROC.NM_Procedimento LIKE CONCAT(parNM_Procedimento, '%')
ORDER BY PROC.NM_Procedimento ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR PROCEDIMENTO POR NOME
#############################################################

CREATE PROCEDURE spbuscar_nome_procedimento (parNM_Procedimento VARCHAR (50))
SELECT
PROC.ID_Procedimento,
CAT.NM_Categoria,
PROC.NM_Procedimento,
PROC.DS_Procedimento
FROM tb_procedimento AS PROC
INNER JOIN tb_categoria AS CAT
ON PROC.ID_Categoria = CAT.ID_Categoria 
WHERE PROC.Ativo = 1
AND PROC.NM_Procedimento LIKE CONCAT(parNM_Procedimento, '%')
ORDER BY PROC.NM_Procedimento ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR PROCEDIMENTO POR CATEGORIA
#############################################################

CREATE PROCEDURE spbuscar_categoria_procedimento (parID_Categoria INT)
SELECT
PROC.ID_Procedimento,
CAT.NM_Categoria,
PROC.NM_Procedimento,
PROC.DS_Procedimento
FROM tb_procedimento AS PROC
INNER JOIN tb_categoria AS CAT
ON PROC.ID_Categoria = CAT.ID_Categoria 
WHERE PROC.Ativo = 1
AND PROC.ID_Categoria = parID_Categoria
ORDER BY PROC.NM_Procedimento ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR PROCEDIMENTO
#############################################################

CREATE PROCEDURE spinserir_procedimento (
parID_Categoria INT,
parNM_Procedimento VARCHAR (50),
parDS_Procedimento VARCHAR (3000))
INSERT INTO tb_procedimento (
ID_Categoria,
NM_Procedimento,
DS_Procedimento,
Ativo)
VALUES (
parID_Categoria,
parNM_Procedimento,
parDS_Procedimento,
1);

#############################################################
# PROCEDIMENTO PARA EDITAR PROCEDIMENTO
#############################################################

CREATE PROCEDURE speditar_procedimento (
parID_Procedimento INT,
parID_Categoria INT,
parNM_Procedimento VARCHAR (50),
parDS_Procedimento VARCHAR (3000))
UPDATE tb_procedimento SET
ID_Categoria = parID_Categoria,
NM_Procedimento = parNM_Procedimento,
DS_Procedimento = parDS_Procedimento
WHERE ID_Procedimento = parID_Procedimento;

#############################################################
# PROCEDIMENTO PARA EXCLUIR PROCEDIMENTO
#############################################################

CREATE PROCEDURE spexcluir_procedimento (parID_Procedimento INT)
UPDATE tb_procedimento SET
Ativo = 0
WHERE ID_Procedimento = parID_Procedimento;