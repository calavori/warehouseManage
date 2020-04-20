create database warehouse;
use warehouse;

CREATE TABLE [Warehouse](
	[id] [int] IDENTITY(1,1) primary key,
	[address] [nvarchar](255) NOT NULL,
	);

CREATE TABLE [Source](
	[id] [int] IDENTITY(1,1) primary key,
	[name] [nvarchar](255) NOT NULL,
	[phone] [nvarchar](11) NOT NULL,
	[address] [nvarchar](255) NOT NULL
	);

create table categories(
	id int identity(1,1) primary key,
	name nvarchar(100) not null
	);

create table product(
	id int identity(1,1) primary key,
	c_id int not null,
	name nvarchar(100) not null,
	foreign key (c_id) references categories(id) on delete cascade on update cascade
	);

create table import(
	id int identity(1,1) primary key,
	w_id int not null,
	s_id int not null,
	date Date not null,
	foreign key (w_id) references warehouse(id) on update cascade on delete cascade,
	foreign key (s_id) references source(id) on update cascade on delete cascade
	);

create table import_detail(
	i_id int not null,
	p_id int not null,
	quanity int not null,
	primary key(p_id, i_id),
	foreign key (p_id) references product(id) on update cascade on delete cascade,
	foreign key (i_id) references import(id) on update cascade on delete cascade
	);

insert into warehouse values ('50 ABC street');
insert into warehouse values ('80 ABC street');
insert into warehouse values ('10 KFC street');
select * from warehouse;

insert into source values ('GearVN', '0938173658', '65 SFC street');
insert into source values ('Phong Vu', '0938173658', '69 KFC street');
select * from source;

insert into categories values ('computer');
insert into categories values ('gaming gear');
insert into categories values ('console');
select * from categories;

insert into product values (1, 'Asus GL503');
insert into product values (1, 'Dell Inspiron 15');
insert into product values (2, 'HyperX Cloud II');
insert into product values (3, 'Sony PS4');
select * from product;

insert into import values (1,2,'2020-4-20');
insert into import values (1,1,'2020-4-20');
insert into import values (2,1,'2020-4-20');
select * from import;


insert into import_detail values (3, 1, 20);
insert into import_detail values (3, 2, 40);
insert into import_detail values (4, 7, 10);
insert into import_detail values (4, 2, 10);
insert into import_detail values (4, 3, 10);
insert into import_detail values (5, 1, 90);
insert into import_detail values (5, 7, 60);
select * from import_detail;






	


