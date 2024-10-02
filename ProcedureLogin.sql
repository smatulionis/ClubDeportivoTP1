
delimiter //  
create procedure IngresoLogin(in Usuario varchar(20),in Pass varchar(15))

begin

  select NombreRol
	from usuario u inner join roles r on u.RolUsuario = r.RolUsuario
		where NombreUsuario = Usuario and Contrasenia = Pass
			and Activo = 1;

end 
//

