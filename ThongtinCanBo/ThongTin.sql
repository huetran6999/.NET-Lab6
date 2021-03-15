create database ThongTin;
use ThongTin

create table Chucvu (
	macv int not null primary key,
	tencv nvarchar(20)
)
create table CanBo(
	MaCB int not null primary key,
	TenCB nvarchar(100),
	ChucVuCB int,
	SoGioGiang int,
	Dongia money,
	constraint fk_macv foreign key(ChucVuCB) references chucvu(macv)
	
)
Create Login mylogin with password='mylogin',

CHECK_POLICY = OFF

select * from CanBo
sp_changedbowner mylogin

insert into Chucvu values (1,'Giang vien')
insert into Chucvu values (2,'Tro giang')