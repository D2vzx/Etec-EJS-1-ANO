
create database Empresa;
USE Empresa;

CREATE table Clientes
(
       CÓD_CLI INT AUTO_INCREMENT PRIMARY KEY,
       Nome VARCHAR(100),
       Salario INT,
       Pagto int,
       Data_compra int,
	   valor_compra int
);

INSERT INTO Clientes (CÓD_CLI, Nome, Salario, Pagto, Data_compra, valor_compra) VALUES
('Luciena', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),       
('Luciene', 'Dobrada', 500.00, 'A vista', 20/08/02, 150.00),
('Thiago', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00),  
('Luciene', 'Dobrada', 500.00, 'A vista', 10/08/02, 200.00);        