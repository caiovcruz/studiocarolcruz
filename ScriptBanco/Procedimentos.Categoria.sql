DROP PROCEDURE IF EXISTS spexibir_categoria;
DROP PROCEDURE IF EXISTS spbuscar_categoria;
DROP PROCEDURE IF EXISTS spinserir_categoria;
DROP PROCEDURE IF EXISTS speditar_categoria;
DROP PROCEDURE IF EXISTS spexcluir_categoria;

#############################################################
# PROCEDIMENTO PARA EXIBIR CATEGORIA
#############################################################

CREATE PROCEDURE spexibir_categoria ()
SELECT ALL 
ID_Categoria,
NM_Categoria,
DS_categoria FROM tb_categoria
ORDER BY NM_Categoria ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR CATEGORIA
#############################################################

CREATE PROCEDURE spbuscar_categoria (parNM_Categoria VARCHAR (50))
SELECT 
ID_Categoria, 
NM_Categoria,
DS_Categoria FROM tb_categoria
WHERE NM_Categoria LIKE CONCAT(parNM_Categoria, '%')
ORDER BY NM_Categoria ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR CATEGORIA
#############################################################

CREATE PROCEDURE spinserir_categoria (
parNM_Categoria VARCHAR (50),
parDS_Categoria VARCHAR (1500))
INSERT INTO tb_categoria (NM_Categoria, DS_Categoria)
VALUES (parNM_Categoria, parDS_Categoria);

#############################################################
# PROCEDIMENTO PARA EDITAR CATEGORIA
#############################################################

CREATE PROCEDURE speditar_categoria (
parID_Categoria INT,
parNM_Categoria VARCHAR (50),
parDS_Categoria VARCHAR (1500))
UPDATE tb_categoria SET 
NM_Categoria = parNM_Categoria,
DS_Categoria = parDS_Categoria
WHERE ID_Categoria = parID_Categoria;

#############################################################
# PROCEDIMENTO PARA EXCLUIR CATEGORIA
#############################################################

CREATE PROCEDURE spexcluir_categoria (parID_Categoria INT)
DELETE FROM tb_categoria 
WHERE ID_Categoria = parID_Categoria;