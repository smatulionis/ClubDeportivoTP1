delimiter //

create procedure NuevoSocio(in Nom varchar(30),in Ape varchar(40),in Tip varchar(20), in Doc int, out rta int)
 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from socio);
     
     if filas = 0 then
		set filas = 100;
     else
		set filas = (select max(IdSocio) + 1 from socio);
		set existe = (select count(*) from socio where TipoDoc = Tip and Documento = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into socio values(filas,Nom,Ape,Tip,Doc);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end 
     //