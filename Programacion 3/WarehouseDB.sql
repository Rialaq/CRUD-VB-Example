Create database warehouse;
use warehouse;

create table items(
	codigo int primary key identity(1,1),
	descripcion varchar(255) not null,
	precio int not null,
	familia varchar(255) not null,
	fecha_vencimiento varchar(255) not null
);

create table clientes(
	codigo int primary key identity(1,1),
	nombre_completo varchar(255) not null,
	cedula varchar(15)	not null,
	fecha_nacimiento varchar(255) not null,
	puntos int not null
);

create table suplidores(
	codigo int primary key identity(1,1),
	nombre varchar(255) not null,
);

create table usuarios(
	codigo int primary key identity(1,1),
	usuario varchar(255) not null,
	pass varchar(255) not null,
	nivel varchar(255)
);

create table empleados(
	codigo int primary key identity(1,1),
	nombre_completo varchar(255) not null,
	cedula varchar(255) not null,
	fecha_nacimiento varchar(255) not null,
	cargo varchar(255) not null,
	sueldo int not null
);

create table ofertas(
	codigo int primary key identity(1,1),
	descripcion varchar(255) not null,
	precio_especial varchar(255) not null
);

drop table clientes
drop table empleados

insert into items(descripcion, precio, familia, fecha_vencimiento) values ('Queso Amarillo', 5000, 'Embutidos', '28/10/2019')
insert into clientes(nombre_completo, cedula, fecha_nacimiento, puntos) values ()
insert into usuarios values ('admin', '12345', 'Desarrollador')
