USE ds_db_projeto_mvc;

CREATE TABLE tbl_usuario (
	idUsuario INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE,
	userName VARCHAR(100) NOT NULL UNIQUE,
	senha VARCHAR(50) NOT NULL,
	tipo VARCHAR(20) NOT NULL,
	ativo VARCHAR(10) NOT NULL DEFAULT 'ativo',
	cpf VARCHAR(14) NOT NULL UNIQUE,
    rg VARCHAR(12) NOT NULL UNIQUE
);

CREATE TABLE tbl_endereco (
	cep INT UNSIGNED UNIQUE NOT NULL,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    bairro VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    estado VARCHAR(100) NOT NULL,
    idUsuario INT,
    PRIMARY KEY (cep),
    FOREIGN KEY (idUsuario) REFERENCES tbl_usuario(idUsuario)
);

INSERT INTO tbl_usuario (idUsuario, nome, email, userName, senha, tipo, ativo, cpf, rg) VALUES
(DEFAULT, 'Alfino Admin', 'alfino.admin@hotmail.com', 'Admin', 'adm123', 'Administrador', DEFAULT, '12345678912', '958647321'),
(DEFAULT, 'Billy Bob', 'billybob@hotmail.com', 'BillyBoy', 'Billy2000', 'Cliente', DEFAULT, '12345678911', '159357987');

INSERT INTO tbl_endereco (cep, logradouro, numero, bairro, cidade, estado, idUsuario) VALUES 
('98765432', 'Rua de las pruebas', '6', 'La cucaracha', 'Acapulco', 'Guerrero', '1'),
('15632185', 'Hyland St', '8', 'Old Oakland', 'Lansing', 'Michigan', '2');

DELETE FROM tbl_usuario
WHERE idUsuario = 5
LIMIT 1;

ALTER TABLE tbl_usuario AUTO_INCREMENT = 0;

SELECT * FROM tbl_usuario;
SELECT * FROM tbl_endereco;

SELECT tu.nome, tu.tipo, te.cep, te.logradouro
FROM tbl_endereco te
INNER JOIN tbl_usuario tu
ON te.idUsuario = tu.idUsuario;