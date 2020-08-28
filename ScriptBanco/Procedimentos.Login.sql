DROP PROCEDURE IF EXISTS spexibir_login;
DROP PROCEDURE IF EXISTS spbuscar_usuario_login;
DROP PROCEDURE IF EXISTS spinserir_login;
DROP PROCEDURE IF EXISTS speditar_login;
DROP PROCEDURE IF EXISTS spexcluir_login;
DROP PROCEDURE IF EXISTS spvalidar_login;

#############################################################
# PROCEDIMENTO PARA EXIBIR LOGIN
#############################################################

CREATE PROCEDURE spexibir_login ()
SELECT ALL
ID_Login,
DS_Usuario,
DS_Senha
FROM tb_login
WHERE Ativo = 1
ORDER BY DS_Usuario ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR USUARIO LOGIN
#############################################################

CREATE PROCEDURE spbuscar_usuario_login (parDS_Usuario VARCHAR (20))
SELECT
ID_Login,
DS_Usuario,
DS_Senha
FROM tb_login
WHERE Ativo = 1
AND DS_Usuario LIKE CONCAT(parDS_Usuario, '%')
ORDER BY DS_Usuario ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR LOGIN
#############################################################

CREATE PROCEDURE spinserir_login (
parDS_Usuario VARCHAR (20),
parDS_Senha VARCHAR (20))
INSERT INTO tb_login (
DS_Usuario,
DS_Senha,
Ativo)
VALUES (
parDS_Usuario,
parDS_Senha,
1);

#############################################################
# PROCEDIMENTO PARA EDITAR LOGIN
#############################################################

CREATE PROCEDURE speditar_login (
parID_Login INT,
parDS_Usuario VARCHAR (20),
parDS_Senha VARCHAR (20))
UPDATE tb_login SET
DS_Usuario = parDS_Usuario,
DS_Senha = parDS_Senha
WHERE ID_Login = parID_Login;

#############################################################
# PROCEDIMENTO PARA EXCLUIR LOGIN
#############################################################

CREATE PROCEDURE spexcluir_login (parID_Login INT)
UPDATE tb_login SET
Ativo = 0
WHERE ID_Login = parID_Login;

#############################################################
# PROCEDIMENTO PARA VALIDAR LOGIN
#############################################################

CREATE PROCEDURE spvalidar_login (
parDS_Usuario VARCHAR (20),
parDS_Senha VARCHAR (20))
SELECT ALL
ID_Login,
DS_Usuario,
DS_Senha
FROM tb_login
WHERE Ativo = 1
AND DS_Usuario = parDS_Usuario
AND DS_Senha = parDS_Senha
ORDER BY ID_Login DESC;