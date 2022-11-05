/* Crear base de datos */
create database CursoSQL

/* Crear tabla */
create table Usuario
(
id_usuario int NOT NULL primary key,
nombre varchar(50) NOT NULL,
edad int NOT NULL
)

/* Insertar datos a la tabla */
insert into Usuario values(1,'Miguel',21);
insert into Usuario values(2,'Juan',35);
insert into Usuario values(3,'Marcos',41);
insert into Usuario values(4,'Pedro',12);
insert into Usuario values(5,'José',57);
insert into Usuario values(6,'Pamela',25);


/* Consulta de una tabla */
select * from Usuario
select id_usuario from Usuario
select nombre,edad from Usuario

/*Consulta con Where */
select * from Usuario where nombre = 'Miguel';
select * from Usuario where edad >=30;
select nombre from Usuario where edad<40;
select id_usuario,nombre from Usuario where nombre<>'Pedro';

/*Operadores con Where*/
/* 
= igual que
< menor que
> mayor que
<= menor igual que
>= mayor igual que
<> diferente a
*/

/* Update datos */
update Usuario set nombre = 'Miguel'
update Usuario set nombre = 'Joaquin' where id_usuario = 5

/* Identity */
create table Usuario2(
id_usuario int identity,
nombre varchar(50) NOT NULL
)
insert into Usuario2 values('Barrasca');
insert into Usuario2 values('Pepe');
insert into Usuario2 values('Sech');
insert into Usuario2 values('Potaxio');
insert into Usuario2 values('Tilin');
insert into Usuario2 values('Oxxo');

select * from Usuario2

select IDENT_SEED('Usuario2');
select IDENT_INCR('Usuario2');

create table Usuario3(
id_usuario int identity(10,3),
nombre varchar(50) NOT NULL,
)



/* Eliminar tabla */
drop table Usuario
/* Eliminar base de datos */
drop database CursoSQL