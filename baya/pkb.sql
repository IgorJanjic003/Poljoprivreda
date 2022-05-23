create database pkb
use pkb

create table kategorija(
id int identity(1,1) primary key,
naziv nvarchar(40)
)

create table proizvod(
id int identity(1,1) primary key,
naziv nvarchar(40),
id_kategorije int foreign key references kategorija(id)
)

create table saradnik(
id int identity(1,1) primary key,
naziv nvarchar(40),
email nvarchar(40),
telefon nvarchar(15),
adresa nvarchar(30)
)

create table magacin(
id int identity(1,1) primary key,
naziv nvarchar(40)
)

create table promag(
id int identity(1,1) primary key,
id_proizvod int foreign key references proizvod(id),
id_magacin int foreign key references magacin(id),
cena int,
kolicina int
)

create table izvestaj(
id int identity(1,1) primary key,
id_magacin int foreign key references magacin(id),
id_proizvod int foreign key references proizvod(id),
cena int,
kolicina int,
id_saradnik int foreign key references saradnik(id),
datum datetime
)