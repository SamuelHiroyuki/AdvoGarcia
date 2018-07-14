use master
go
drop database dbAdvoGarcia

create database dbAdvoGarcia;
go
use dbAdvoGarcia;

go
create table tbAdvogado(
	ID_Advogado int primary key identity(1,1),
	Nome_Adv varchar(50) not null,
	End_Adv varchar(50) not null,
	Email_Adv varchar(50) not null,
	Foto_Adv varchar(100) not null,
	User_Adv varchar(20) not null,
	Pass_Adv varchar(20) not null,
	CPF_Adv varchar(14) not null,
	Tel_Adv varchar(15) not null,
	QtdCasos int not null,
	PrecoHR int not null,
	Ani_Adv varchar(250) not null,
	Area varchar(50) not null,
	LastLog_Adv datetime,
);

go
create table tbCaso(
	ID_Caso int primary key identity(1,1),
	Status_Caso varchar(10) not null,
	Descricao_Caso varchar(256) not null,
	ID_Advogado int foreign key references tbAdvogado(ID_Advogado)
);

go

create table tbCliente(
	ID_Cli int primary key identity(1,1),
	Nome_Cli varchar(50) not null,
	End_Cli varchar(50) not null,
	Email_Cli varchar(100) not null,
	Foto_Cli varchar(100) not null,
	User_Cli varchar(50) not null,
	Pass_Cli varchar(50) not null,
	CPF_Cli varchar(14) not null,
	Tel_Cli varchar(15) not null,
	FormaPaga varchar(20) not null,
	ID_Caso int foreign key references tbCaso(ID_Caso)
);

go

insert into tbCaso(Descricao_Caso, Status_Caso)
values('Um pão', 'Andamento')
go
insert into tbCaso(Descricao_Caso, Status_Caso, ID_Advogado)
values('Caso 2', 'Andamento', 1)
go

insert into tbAdvogado(Nome_Adv, End_Adv, Email_Adv, Foto_Adv, User_Adv, Pass_Adv, CPF_Adv, 
Tel_Adv, QtdCasos, PrecoHR, Ani_Adv, Area, LastLog_Adv)
values('1', 'Rua1', 'email1@email.email', 'C:1', 'Teste', '123', '12332112312', '12543211234', 12, 2, '1940-10-09', 'Mediação', '1940-10-09')
go
insert into tbAdvogado(Nome_Adv, End_Adv, Email_Adv, Foto_Adv, User_Adv, Pass_Adv, CPF_Adv, 
Tel_Adv, QtdCasos, PrecoHR, Ani_Adv, Area)
values('2', 'Rua2', 'email2@email.email', 'C:2', 'Teste2', '123', '12332112312', '12543211234', 12, 2, '2012-11-19', 'Direito Civil')
go

insert into tbCliente(Nome_Cli, End_Cli, Email_Cli, Foto_Cli, User_Cli, Pass_Cli, CPF_Cli, Tel_Cli,
 FormaPaga, ID_Caso)
values('Cliente C2', 'PraçaC2', 'emailC2', 'c:2', 'cli', '123', '12345678901', '11543211234', 
'cheque', (select ID_Caso from tbCaso where Descricao_Caso = 'Caso 2'))


select * from tbAdvogado;
select * from tbCaso;
select * from tbCliente;

select ID_Caso, Descricao_Caso from tbCaso

select ID_Caso from tbAdvogado where User_Adv = 'Teste' COLLATE SQL_Latin1_General_CP1_CS_AS and Pass_Adv = '123' COLLATE SQL_Latin1_General_CP1_CS_AS 

select ID_Advogado from tbAdvogado where Nome_Adv = 'Teste'

select * from tbCliente where ID_Caso = 1


update tbAdvogado set Anot = 'Teste do Teste em Teste' where ID_Advogado = 1