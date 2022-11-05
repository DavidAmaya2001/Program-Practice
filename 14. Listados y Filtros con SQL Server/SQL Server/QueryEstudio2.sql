create database libreria;

use libreria;

create table libros
(
id_libro int identity primary key,
nombre varchar(50) not null,
precio_venta int not null,
precio_compra float not null
)

insert into libros values('el lobo',115,95.23);
insert into libros values('caperusa roja',236,189.25);
insert into libros values('programacion en java',123,101.56);
insert into libros values('programando desde cero con C',78,50.36);
insert into libros values('sql server 2000',115,95.23);
insert into libros values('el codigo da vinci',115,95.23);
insert into libros values('aura',115,95.23);
insert into libros values('100 años de soledad',115,95.23);
insert into libros values('la física es divertida',115,95.23);
insert into libros values('calculo integral',115,95.23);
insert into libros values('las 20 lenguas del dragon',115,95.23);
insert into libros values('narnia',115,95.23);
insert into libros values('el señor de los anillos',115,95.23);
insert into libros values('ruperth',115,95.23);
insert into libros values('tutoriales hackro',115,95.23);
insert into libros values('la magia de las matemáticas',115,95.23);

select * from libros

/* Operadores Aritmeticos */

/* Sacar ganancias de cada libro  (precio_venta - precio_compra) */
select precio_venta - precio_compra from libros
select precio_venta - precio_compra from libros where id_libro = 1

/* Presupuesto */
select nombre, precio_venta * 10 from libros
select nombre, precio_venta * 10 from libros where nombre = 'programacion en java'

/* Actualización */
update libros set precio_venta = precio_venta + (precio_venta * 0.1) where id_libro = 1