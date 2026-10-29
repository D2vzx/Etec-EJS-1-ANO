
CREATE DATABASE estoque_basico;
USE estoque_basico;
CREATE TABLE Categorias (

id_categoria INT PRIMARY KEY AUTO_INCREMENT,
nome_categoria VARCHAR(100) NOT NULL UNIQUE);
CREATE TABLE Produtos (
id_produto INT PRIMARY KEY AUTO_INCREMENT,
nome_produto VARCHAR(100) NOT NULL,
preco DECIMAL(10, 2) NOT NULL,
quantidade_estoque INT DEFAULT 0,
id_categoria INT,
FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria)
);
INSERT INTO Categorias (nome_categoria) VALUES ('Eletrônicos');
INSERT INTO Categorias (nome_categoria) VALUES ('Livros');
INSERT INTO Categorias (nome_categoria) VALUES ('Vestuário');
INSERT INTO Produtos (nome_produto, preco, quantidade_estoque, id_categoria)
VALUES ('Smartphone X', 1500.00, 50, 1); -- id_categoria 1 é 'Eletrônicos'
INSERT INTO Produtos (nome_produto, preco, quantidade_estoque, id_categoria)
VALUES ('O Senhor dos Anéis', 85.50, 100, 2); -- id_categoria 2 é 'Livros'
INSERT INTO Produtos (nome_produto, preco, quantidade_estoque, id_categoria)
VALUES ('Camiseta Básica', 49.90, 200, 3); -- id_categoria 3 é 'Vestuário'
INSERT INTO Produtos (nome_produto, preco, quantidade_estoque, id_categoria)
VALUES ('Notebook Gamer', 4500.00, 20, 1);
SELECT * FROM Produtos;
SELECT nome_produto, preco FROM Produtos WHERE preco > 100.00;
SELECT P.nome_produto, P.preco, C.nome_categoria
FROM Produtos P
JOIN Categorias C ON P.id_categoria = C.id_categoria;
UPDATE Produtos
SET preco = 1650.00
WHERE nome_produto = 'Smartphone X';
-- Deletar um produto
DELETE FROM Produtos
WHERE nome_produto = 'Camiseta Básica'
/