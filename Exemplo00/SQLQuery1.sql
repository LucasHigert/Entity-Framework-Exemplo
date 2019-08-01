

CREATE TABLE animais(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR (100),
extinto BIT
);

SELECT*FROM animais;

-- Adicionar uma coluna na tabela
ALTER TABLE animais ADD peso DECIMAL (4,2) DEFAULT 0.0;

-- Atualizar
UPDATE animais SET peso=0;

-- Apagar uma coluna da tabela
--ALTER TABLE animais DROP CONSTRAINT
--DF__animais__peso__29572725; --Para encontrar, basta dar um "ALTER TABLE animais DROP COLUMN peso";

--ALTER TABLE animais DROP COLUMN peso;


CREATE TABLE habilidades(
id INT PRIMARY KEY IDENTITY (1,1),

id_animal INT,
FOREIGN KEY (id_animal) REFERENCES animais (id),

nome VARCHAR (100)
);