CREATE DATABASE EMPRESA5;
USE EMPRESA5;
CREATE TABLE Clientes5

(
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50),
    telefone VARCHAR (15),
	genero VARCHAR (50)
);
INSERT INTO Clientes5 (id, nome, telefone, genero) VALUES
(1, 'roberta', '9999-9999', 'F'),
(2, 'Denis', '8888-8888', 'M'),
(3, 'Valéria', '7777-7777', 'F'),
(4, 'Isabel', '5555-5555', 'F');

SELECT * FROM Clientes5;
SELECT * FROM Clientes5 WHERE genero = 'F';
INSERT INTO Clientes5 (id, nome, telefone, genero) VALUE (5, 'Miguel', '4444-4444', 'M');
UPDATE Clientes5 SET telefone='4444-4444' WHERE- '4';
DELETE FROM Clientes5 WHERE id='5';