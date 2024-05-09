create database dbForm;
use dbForm;

create table funcionarios(
	id int not null auto_increment primary key,
	nome varchar(100) not null,
	email varchar(100) not null,
	cpf varchar(11) not null,
	endereco varchar(200) not null
);