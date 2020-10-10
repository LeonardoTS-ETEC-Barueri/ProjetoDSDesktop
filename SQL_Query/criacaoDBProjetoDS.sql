USE ds_db_projeto_mvc;

CREATE TABLE tbl_usuario (
	idUsuario INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE,
	userName VARCHAR(100) NOT NULL UNIQUE,
	senha VARCHAR(50) NOT NULL,
	tipo VARCHAR(20) NOT NULL,
	ativo VARCHAR(10) NOT NULL DEFAULT 'ativo',
	cpf VARCHAR(14) NOT NULL UNIQUE
);

INSERT INTO tbl_usuario (idUsuario, nome, email, userName, senha, tipo, ativo, cpf) VALUES
(DEFAULT, 'Alfino Admin', 'alfino.admin@hotmail.com', 'Admin', 'adm123', 'Administrador', DEFAULT, '12345678912'),
(DEFAULT, 'Billy Bob', 'billybob@hotmail.com', 'BillyBoy', 'Billy2000', 'Cliente', DEFAULT, '12345678911');

SELECT * FROM tbl_usuario;