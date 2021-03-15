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

sp_changedbowner mylogin

insert into Chucvu values (1,'giang vien')
insert into Chucvu values (2,'Tro giang')
insert into Chucvu values ('3','Nhan vien')
select * from CanBo;
insert into canbo values ('1','le hoang qui','Nhan vien','1000','1000');
select Max(MaCB) from canbo