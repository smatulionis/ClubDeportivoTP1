drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

create table roles(
RolUsuario int,
NombreRol varchar(30),
constraint primary key(RolUsuario)
);

insert into roles values
(1,'Administrador'),
(2,'Empleado');

create table usuario(
IdUsuario int auto_increment,
NombreUsuario varchar (20),
Contrasenia varchar (15),
RolUsuario int,
Activo boolean default true,
constraint pk_usuario primary key (IdUsuario),
constraint fk_usuario foreign key(RolUsuario) references roles(RolUsuario)
);

insert into usuario(NombreUsuario,Contrasenia,RolUsuario) values
('Juan20','123456',1), ('Pepe10','1234',2);

create table socio(
IdSocio int,
Nombre varchar(30),
Apellido varchar(40),
TipoDoc varchar(20),
Documento int,
constraint pk_socio primary key(IdSocio)
);

