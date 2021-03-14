use ThanhToan;

create table phong( 
	MaPhong int primary key,
	TenPhong nvarchar(10)
);

create table khachhang(
	SoHD int primary key,
	TenKH nvarchar(40),
	SoCMND nvarchar(40),
	SoTien nvarchar(20),
	NgayTT date,
	Phong int foreign key(Phong) references phong(MaPhong)
);

insert into khachhang values (1,'abc','555','bsad','2021-03-13',1);
select MAX(maphong) from phong;


insert into phong values(1,'A101');
insert into phong values(2,'A102');
insert into phong values(3,'B103');
insert into phong values(4,'C104');

