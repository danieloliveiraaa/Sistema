create database Software;

use Software
	

create table Cliente(
Id_cli int Not null Primary key,
Nome varchar(50) not null,
Endereco varchar(100) not null,
cpf varchar(11) not null,
rg varchar(9) not null,
email varchar(100),
telefone varchar(11), 
);


drop table Cliente



--EXEMPLO COUNT
/*
select count(*) as CONT_ID --NOME DO RESULTADO, DO COUNT
from Cliente
where Id_cli = 1
or cpf = '3345729' 
or rg = '3973489'
*/





create table Funcionario(
Id_func int not null primary key,
nome varchar(50) not null, 
email varchar(100) not null,
cargo varchar(30) not null,
empresa varchar (50) not null,
telefone varchar(11) not null, --11951459813
endereco varchar(100) not null,
cpf varchar(11) not null,	
rg varchar(9) not null,
);


select * from Funcionario;

select count(*) as cont --NOME DO RESULTADO, DO COUNT
from Funcionario
where Id_func = 0

/*
DELETE FROM Funcionario
WHERE Id_func in (7,20)
*/

create table estoque(
Id_Prod int not null primary key,
Nome varchar(50) NOT NULL,
Tipo varchar(50) not null,
Quantidade int not null,
Fornecedor varchar(100) not null,
Preco varchar(10) not null,
)

INSERT INTO estoque values(1,'Feijão','Camil',100,'Brasil feijões', 10.00);
INSERT INTO estoque values(2,'Arroz','Blue Ville',400,'Blue Ville', 15.00);
INSERT INTO estoque values(3,'Macarrão','Dona Benta',150,'Brasil Macarrão', 20.00);
INSERT INTO estoque values(4,'Refrigerante','Coca Cola',300,'Coca Cola', 4.00);
INSERT INTO estoque values(5,'Miojo','Turma da Mônica',200,'Tio do Ramén', 1.00);
INSERT INTO estoque values(6,'Bolacha','Trakinas',500,'Trakinas', 3.00);

select *
from estoque



create table login_usuario
(
nome_usuario varchar(100) not null,
email_usuario varchar(50) not null,
id_usuario varchar(50)not null primary key,
senha_usuario varchar(50) not null,
--imagem_usuario varbinary(max) not null
)

insert into login_usuario values('Administrador','silvaoliveiradaniel3@gmail.com','sa','28052018');
insert into login_usuario values('Daniel Silva','danisilva.oli@hotmail.com','dsilva','danielonet1@')


select * 
from login_usuario









