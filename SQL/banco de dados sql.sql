create database Escola; 
USE Escola ;
CREATE TABLE Alunos
(
   id INT AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(100), 
idade INT, 
cidade VARCHAR(50)
);
INSERT INTO Alunos (nome, idade, cidade) VALUES
('Ana', 20, 'São Paulo'),
('Bruno', 22, 'Rio de Janeiro'),
('Carla', 19, 'Belo Horizonte'),
('Daniel', 23, 'Porto Alegre');
SELECT * FROM Alunos;
SELECT * FROM Alunos
WHERE idade > 21;