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
Nombre varchar(30),
Apellido varchar(40),
TipoDoc varchar(20),
Documento int,
AptoFisico boolean,
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

create table actividad(
IdActividad int auto_increment primary key,
NombreActividad varchar(40),
Monto float
);

create table cuota(
IdCuota int auto_increment primary key,
IdCliente int,
Monto float,
Fecha date,
FormaPago varchar(40)
);

insert into actividad(NombreActividad,Monto) values
('Yoga',10000), ('Musculación',5000), ('Pilates',15000), ('Calistenia',15000), ('Danza',20000);

create table inscripcion(
IdInscripcion int auto_increment key,
IdCliente int,
IdActividad int,
Pagado bool,
constraint fk_inscripcion_cliente foreign key (IdCliente) references cliente(IdCliente),
constraint fk_inscripcion_actividad foreign key (IdActividad) references actividad(IdActividad)
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

delimiter //

create procedure InscribirCliente(
    in Cli int,
    in Act int,
    in Pag bool,
    out rta int
)
begin
    declare clienteExiste int;

    set clienteExiste = (select count(*) from cliente where IdCliente = Cli);

    if clienteExiste = 0 then
        set rta = -1;
    else
            insert into inscripcion (IdCliente, IdActividad, Pagado)
            values (Cli, Act, Pag);

            set rta = LAST_INSERT_ID();
    end if;
end
//

delimiter //

create procedure AbonarCuota(
    in Cli int,
    in Monto float,
    in Fecha date,
    in FPago varchar(40)
)
begin
		insert into cuota (IdCliente, Monto, Fecha, FormaPago)
		values (Cli, Monto, Fecha, FPago);

		update inscripcion
        set Pagado = true
        where IdCliente = Cli and Pagado = false;
end 
//

delimiter //

create procedure ObtenerTipoCliente(
    in Cli int,
    out rta int
)
begin
    declare socioCount int;
    declare noSocioCount int;

    set socioCount = (select count(*) from socio where IdCliente = Cli);
    set noSocioCount = (select count(*) from noSocio where IdCliente = Cli);

    if socioCount > 0 then
        set rta = 1;
    elseif noSocioCount > 0 then
        set rta = 2;
    else
        set rta = -1;
    end if;
end
//

