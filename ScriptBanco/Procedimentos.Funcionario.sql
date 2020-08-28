DROP PROCEDURE IF EXISTS spexibir_funcionario;
DROP PROCEDURE IF EXISTS spbuscar_nome_funcionario;
DROP PROCEDURE IF EXISTS spbuscar_cpf_funcionario;
DROP PROCEDURE IF EXISTS spinserir_funcionario;
DROP PROCEDURE IF EXISTS speditar_funcionario;
DROP PROCEDURE IF EXISTS spexcluir_funcionario;

#############################################################
# PROCEDIMENTO PARA EXIBIR FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spexibir_funcionario ()
SELECT ALL
ID_Funcionario,
NM_Funcionario,
DS_Sexo,
NR_CPF,
DT_Nascimento,
NR_Telefone,
DS_Email,
DS_Cargo,
FORMAT(VL_Salario, 2, 'de_DE') AS VL_Salario,
DT_Admissao,
NM_Rua,
NR_Casa,
DS_Complemento,
NM_Bairro,
NR_CEP,
NM_Cidade,
DS_UF
FROM tb_funcionario
WHERE DT_Demissao IS NULL
ORDER BY NM_Funcionario ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR FUNCIONÁRIO POR NOME
#############################################################

CREATE PROCEDURE spbuscar_nome_funcionario (parNM_Funcionario VARCHAR (50))
SELECT
ID_Funcionario,
NM_Funcionario,
DS_Sexo,
NR_CPF,
DT_Nascimento,
NR_Telefone,
DS_Email,
DS_Cargo,
FORMAT(VL_Salario, 2, 'de_DE') AS VL_Salario,
DT_Admissao,
NM_Rua,
NR_Casa,
DS_Complemento,
NM_Bairro,
NR_CEP,
NM_Cidade,
DS_UF
FROM tb_funcionario AS FUN
WHERE NM_Funcionario LIKE CONCAT(parNM_Funcionario, '%')
AND DT_Demissao IS NULL
ORDER BY NM_Funcionario ASC;

#############################################################
# PROCEDIMENTO PARA BUSCAR FUNCIONÁRIO POR CPF
#############################################################

CREATE PROCEDURE spbuscar_cpf_funcionario (parNR_CPF VARCHAR (11))
SELECT
ID_Funcionario,
NM_Funcionario,
DS_Sexo,
NR_CPF,
DT_Nascimento,
NR_Telefone,
DS_Email,
DS_Cargo,
FORMAT(VL_Salario, 2, 'de_DE') AS VL_Salario,
DT_Admissao,
NM_Rua,
NR_Casa,
DS_Complemento,
NM_Bairro,
NR_CEP,
NM_Cidade,
DS_UF
FROM tb_funcionario AS FUN
WHERE NR_CPF LIKE CONCAT(parNR_CPF, '%')
AND DT_Demissao IS NULL
ORDER BY NM_Funcionario ASC;

#############################################################
# PROCEDIMENTO PARA INSERIR FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spinserir_funcionario (
parNM_Funcionario VARCHAR(50),
parDS_Sexo VARCHAR(1),
parDT_Nascimento DATE,
parNR_CPF NUMERIC(11,0),
parNR_Telefone NUMERIC(11,0),
parDS_Email VARCHAR(80),
parNR_CEP VARCHAR(10),
parNM_Rua VARCHAR(50),
parNR_Casa VARCHAR(5),
parNM_Bairro VARCHAR(50),
parDS_Complemento VARCHAR(50),
parNM_Cidade VARCHAR(30),
parDS_UF VARCHAR(2),
parDS_Cargo VARCHAR(30),
parVL_Salario DECIMAL(10,2),
parDT_Admissao DATE)
INSERT INTO TB_Funcionario (
NM_Funcionario,
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
DS_Cargo,
VL_Salario,
DT_Admissao) 
VALUES (
parNM_Funcionario,
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
parDS_Cargo,
parVL_Salario,
parDT_Admissao);

#############################################################
# PROCEDIMENTO PARA EDITAR FUNCIONÁRIO
#############################################################

CREATE PROCEDURE speditar_funcionario (
parID_Funcionario INT,
parNM_Funcionario VARCHAR(50),
parDS_Sexo VARCHAR(1),
parDT_Nascimento DATE,
parNR_CPF NUMERIC(11,0),
parNR_Telefone NUMERIC(11,0),
parDS_Email VARCHAR(80),
parNR_CEP VARCHAR(10),
parNM_Rua VARCHAR(50),
parNR_Casa VARCHAR(5),
parNM_Bairro VARCHAR(50),
parDS_Complemento VARCHAR(50),
parNM_Cidade VARCHAR(30),
parDS_UF VARCHAR(2),
parDS_Cargo VARCHAR(30),
parVL_Salario DECIMAL(10,2),
parDT_Admissao DATE)
UPDATE TB_Funcionario SET
NM_Funcionario = parNM_Funcionario,
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
DS_UF = parDS_UF,
DS_Cargo = parDS_Cargo,
VL_Salario = parVL_Salario,
DT_Admissao = parDT_Admissao
WHERE ID_Funcionario = parID_Funcionario;

#############################################################
# PROCEDIMENTO PARA EXCLUIR FUNCIONÁRIO
#############################################################

CREATE PROCEDURE spexcluir_funcionario (parID_Funcionario INT)
UPDATE TB_Funcionario SET
DT_Demissao = NOW()
WHERE ID_Funcionario = parID_Funcionario;