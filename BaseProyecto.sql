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

create table cliente(
IdCliente int auto_increment primary key,
Nombre varchar(30) not null,
Apellido varchar(40) not null,
TipoDoc varchar(20) not null,
Documento int not null,
AptoFisico boolean not null,
UNIQUE (TipoDoc, Documento)
);

create table socio(
IdCliente int primary key,
foreign key (IdCliente) references Cliente(IdCliente) on delete cascade
);

create table noSocio(
IdCliente int primary key,
foreign key (IdCliente) references Cliente(IdCliente) on delete cascade
);

delimiter //  
create procedure IngresoLogin(in Usuario varchar(20),in Pass varchar(15))

begin

  select NombreRol
	from usuario u inner join roles r on u.RolUsuario = r.RolUsuario
		where NombreUsuario = Usuario and Contrasenia = Pass
			and Activo = 1;

end 
//

delimiter //

create procedure NuevoCliente(
    in Nom varchar(30),
    in Ape varchar(40),
    in Tip varchar(20),
    in Doc int,
    in ApFis boolean,
    in esSocio boolean,
    out rta int
)
begin
    declare existe int default 0;
    declare idCliente int default 0;

    set existe = (select count(*) from cliente where TipoDoc = Tip and Documento = Doc);

    if existe = 0 then
        insert into cliente (Nombre, Apellido, TipoDoc, Documento, AptoFisico) 
        values (Nom, Ape, Tip, Doc, ApFis);

        set idCliente = LAST_INSERT_ID();

        if esSocio then
            insert into socio (IdCliente) 
            values (idCliente);
        else
            insert into noSocio (IdCliente) 
            values (idCliente);
        end if;

        set rta = idCliente;
    else
        set rta = -1;
    end if;
end
//

