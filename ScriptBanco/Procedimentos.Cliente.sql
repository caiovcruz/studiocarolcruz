DROP PROCEDURE IF EXISTS spinserir_cliente;
DROP PROCEDURE IF EXISTS spexibir_cliente;
DROP PROCEDURE IF EXISTS spexcluir_cliente;
DROP PROCEDURE IF EXISTS speditar_cliente;
DROP PROCEDURE IF EXISTS spbuscar_nome_cliente;
DROP PROCEDURE IF EXISTS spbuscar_cpf_cliente;

#############################################################
# PROCEDIMENTO PARA INSERIR CLIENTE
#############################################################

CREATE PROCEDURE spinserir_cliente (
parNM_Cliente VARCHAR(50),
parDS_Sexo VARCHAR(1),
parDT_Nascimento DATE,
parNR_CPF VARCHAR(11),
parNR_Telefone VARCHAR(11),
parDS_Email VARCHAR(80),
parNR_CEP VARCHAR(10),
parNM_Rua VARCHAR(50),
parNR_Casa VARCHAR(5),
parNM_Bairro VARCHAR(50),
parDS_Complemento VARCHAR(50),
parNM_Cidade VARCHAR(30),
parDS_UF VARCHAR(2))
INSERT INTO TB_Cliente (
NM_Cliente,
DS_Sexo,
DT_Nascimento,
NR_CPF,
NR_Telefone,
DS_Email,
NR_CEP,
NM_Rua,
NR_Casa,
NM_Bairro,
DS_Complemento,
NM_Cidade,
DS_UF,
Ativo) 
VALUES (
parNM_Cliente,
parDS_Sexo,
parDT_Nascimento,
parNR_CPF,
parNR_Telefone,
parDS_Email,
parNR_CEP,
parNM_Rua,
parNR_Casa,
parNM_Bairro,
parDS_Complemento,
parNM_Cidade,
parDS_UF,
1);

#############################################################
# PROCEDIMENTO PARA EXIBIR CLIENTE
#############################################################

CREATE PROCEDURE spexibir_cliente ()
SELECT  ALL
ID_Cliente,
NM_Cliente,
DS_Sexo,
NR_CPF,
DT_Nascimento,
NR_Telefone,
DS_Email,
NM_Rua,
NR_Casa,
DS_Complemento,
NM_Bairro,
NR_CEP,
NM_Cidade,
DS_UF
FROM tb_cliente 
WHERE Ativo = 1
ORDER BY NM_Cliente ASC;

#############################################################
# PROCEDIMENTO PARA EXCLUIR CLIENTE
#############################################################

CREATE PROCEDURE spexcluir_cliente (parID_Cliente INT)
UPDATE tb_cliente SET
Ativo = 0
WHERE ID_Cliente = parID_Cliente;

#############################################################
# PROCEDIMENTO PARA EDITAR CLIENTE
#############################################################

CREATE PROCEDURE speditar_cliente (
parID_Cliente INT,
parNM_Cliente VARCHAR(50),
parDS_Sexo VARCHAR(1),
parDT_Nascimento DATE,
parNR_CPF VARCHAR(11),
parNR_Telefone VARCHAR(11),
parDS_Email VARCHAR(80),
parNR_CEP VARCHAR(10),
parNM_Rua VARCHAR(50),
parNR_Casa VARCHAR(5),
parNM_Bairro VARCHAR(50),
parDS_Complemento VARCHAR(50),
parNM_Cidade VARCHAR(30),
parDS_UF VARCHAR(2))
UPDATE tb_cliente SET
NM_Cliente = parNM_Cliente,
DS_Sexo = parDS_Sexo,
DT_Nascimento = parDT_Nascimento,
NR_CPF = parNR_CPF,
NR_Telefone = parNR_Telefone,
DS_Email = parDS_Email,
NR_CEP = parNR_CEP,
NM_Rua = parNM_Rua,
NR_Casa = parNR_Casa,
NM_Bairro = parNM_Bairro,
DS_Complemento = parDS_Complemento,
NM_Cidade = parNM_Cidade,
DS_UF = parDS_UF
WHERE ID_Cliente = parID_Cliente;

#############################################################
# PROCEDIMENTO PARA BUSCAR CLIENTE POR NOME
#############################################################

CREATE PROCEDURE spbuscar_nome_cliente (parNM_Cliente VARCHAR (50))
SELECT
ID_Cliente,
NM_Cliente,
DS_Sexo,
NR_CPF,
DT_Nascimento,
NR_Telefone,
DS_Email,
NM_Rua,
NR_Casa,
DS_Complemento,
NM_Bairro,
NR_CEP,
NM_Cidade,
DS_UF
FROM tb_cliente 
WHERE Ativo = 1
AND NM_Cliente LIKE CONCAT(parNM_Cliente, '%')
ORDER BY NM_Cliente ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR CLIENTE POR CPF
#############################################################

CREATE PROCEDURE spbuscar_cpf_cliente (parNR_CPF VARCHAR (11))
SELECT
ID_Cliente,
NM_Cliente,
DS_Sexo,
NR_CPF,
DT_Nascimento,
NR_Telefone,
DS_Email,
NM_Rua,
NR_Casa,
DS_Complemento,
NM_Bairro,
NR_CEP,
NM_Cidade,
DS_UF
FROM tb_cliente 
WHERE Ativo = 1
AND NR_CPF LIKE CONCAT(parNR_CPF, '%')
ORDER BY NM_Cliente ASC;