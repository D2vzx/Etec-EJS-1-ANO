CREATE DATABASE IF NOT EXISTS EMPRESA;
USE EMPRESA;


CREATE TABLE IF NOT EXISTS Clientes 
(
  id INT AUTO_INCREMENT PRIMARY KEY,
    Cód_Cli INT,
    nome VARCHAR(50),
    cidade VARCHAR(50),
    salario DECIMAL(10,2),
    pagto VARCHAR(10),
    Valor_compra DECIMAL(10,2),
    Data_Compra DATE
);
INSERT INTO Clientes (Cód_Cli, nome, cidade, salario, pagto, Data_Compra, Valor_compra) VALUES
(1, 'Luciene', 'Dobrada', 500.00, 'A vista', '2002-08-10', 200.00),
(2, 'Luciana', 'Dobrada', 500.00, 'A prazo', '2002-08-20', 150.00),
(3, 'Thiago', 'Matão', 200.00, 'A prazo', '2002-08-15', 300.00),
(4, 'Fernando', 'Matão', 100.00, 'A vista', '2002-07-02', 20.00),
(5, 'John', 'Chicago', 500.00, 'A vista', '2002-07-13', 400.00),
(6, 'Luiz', 'Turvo', 150.00, 'A prazo', '2002-08-20', 300.00),
(7, 'Tatiane', 'Matão', 700.00, 'A prazo', '2002-08-20', 500.00),
(8, 'Vivian', 'Araraquara', 200.00, 'A prazo', '2002-06-10', 500.00),
(9, 'Viviana', 'Jaboticabal', 900.00, 'A vista', '2002-06-10', 500.00),
(10, 'Zildo', 'Matão', 150.00, 'A vista', '2002-08-20', 30.00),
(11, 'Lucilene', 'Jaboticabal', 100.00, 'A prazo', '2002-08-20', 30.00),
(12, 'Andréia', 'Araraquara', 500.00, 'A prazo', '2002-07-10', 20.00);

SELECT * FROM Clientes;


SELECT * FROM Clientes
WHERE salario > 3000;

SELECT id, nome
FROM Clientes
WHERE nome LIKE 'L%'
ORDER BY nome;

SELECT Clientes.nome
FROM Clientes
ORDER BY Clientes.nome;