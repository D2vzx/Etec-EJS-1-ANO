
create database ESCOLA;
USE ESCOLA;

CREATE TABLE Alunos
(
     ID INT AUTO_INCREMENT PRIMARY KEY,
     NOME VARCHAR(100),
     IDADE INT,
     CIDADE VARCHAR(50)
);

INSERT INTO Alunos (NOME, IDADE, CIDADE) VALUES
('Ana', 20, 'São Paulo'),
('Bruno', 22, 'Rio de Janeiro'),
('Carla', 19, 'Belo Horizonte'),
('Daniel', 23, 'Porto Alegre');

SELECT * FROM Alunos;

select * FROM Alunos
WHERE IDADE > 21;

SELECT * FROM Alunos
ORDER BY NOME ASC;

select count(*) AS total
From Alunos
Where idade > 20;