CREATE DATABASE crud_animal

CREATE TABLE peixe_Lambari (
    codigo_lambari INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    sexo VARCHAR(10) NOT NULL,
    habitat VARCHAR(100) NOT NULL,
    comprimento DECIMAL(5, 2),
    peso DECIMAL(5, 2)
);