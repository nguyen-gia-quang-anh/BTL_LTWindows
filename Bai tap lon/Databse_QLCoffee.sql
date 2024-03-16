create database QLCoffee
create table QLNV
(
    MNV char(10) not null,
	TNV nvarchar(30) not null,
	SDT varchar(10) not null,
	constraint check_phone_lenght check(len(SDT) = 10),
	Ngaysinh date,
	Diachi nvarchar(300) not null,
	Gioitinh nchar(5) not null,
	Chucvu char(2) default 'nv',
	username char(20),
	pass char(10) default '123456',
	primary key (MNV),
)

alter table QLNV alter column username char(20)

create table QLSP
(
    MAP char(10) not null,
	TenP nchar(30) not null,
	Gia int, 
	Loai nchar(20) not null,
	SLBan int default 0,
	Primary key (MAP),
)


create table HOADON
(
    MHD char(10) not null,
	NgayLapHD date,
	MNV char(10) not null,
	TongTien float,
	primary key(MHD),
	foreign key (MNV) references QLNV(MNV),
)


create table CHITIETHOADON
(
    MHD char(10) not null,
	MAP char(10) not null,
	SL int,
	Gia float,
	ThanhTien float,
	primary key (MHD,MAP),
	foreign key (MHD) references HOADON(MHD),
	foreign key (MAP) references QLSP(MAP),
	check(SL >= 0),
)



insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV01',N'Nguyễn Thị Hồng','0987654321', '05/15/1999',N'HN',N'Nữ','NV01')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV02',N'Trần Văn An','0903456789', '09/20/2005',N'BN',N'Nam','NV02')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV03',N'Lê Thị Thu Hà','0978123456', '03/10/2001',N'HN',N'Nữ','NV03')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV04',N'Phạm Minh Tuấn','0912345678', '05/20/1997',N'NA',N'Nam','NV04')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV05',N'Hoàng Thị Mai Anh','0965432109', '06/15/2002',N'HN',N'Nữ','NV05')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV06',N'Đặng Văn Đức','0934567890', '05/15/2003',N'NA',N'Nam','NV06')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV07',N'Lê Văn Đức','0941234567', '07/10/2004',N'HD',N'Nam','NV07')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV08',N'Đoàn Hà Giang','0908765432', '02/08/2004',N'NB',N'Nữ','NV08')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV09',N'Vũ Thị Lan Anh','0987654321', '08/15/1998',N'TH',N'Nữ','NV09')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username)
values ('NV010',N'Hoàng Minh Hải','0987654321', '05/29/2000',N'TH',N'Nam','NV010')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, Chucvu, username, pass)
values ('QL001',N'Do Minh Quan','0369171690', '12/29/2004',N'HN',N'Nam','ad', 'group19QLCF', '88888888')
insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, Chucvu, username, pass)
values ('QL002',N'Đỗ Minh Quân','0369171690', '12/29/2004',N'Hà Nội',N'Nam','ad', 'Hasssta', '88888888')

-- delete from QLNV where MNV = 'QL001'

select * from QLNV

insert into QLSP values ('SP01',N'Cappuccino', 30000, N'Đồ uống',0)
insert into QLSP values ('SP02',N'Cafe Mocha', 50000, N'Đồ uống',0)
insert into QLSP values ('SP03',N'Bánh bông lan',40000, N'Đồ ăn',0)
insert into QLSP values ('SP04',N'Trà chanh dã tay', 40000, N'Đồ uống',0)
insert into QLSP values ('SP05',N'Bạc xỉu', 15000, N'Đồ uống',0)
insert into QLSP values ('SP06',N'Trã sữa matcha', 35000, N'Đồ uống',0)
insert into QLSP values ('SP07',N'Mocktail Cinderella', 150000, N'Đồ uống',0)
insert into QLSP values ('SP08',N'Mocktail Virgin Pinacolada', 120000, N'Đồ uống',0)
insert into QLSP values ('SP09',N'Cocktail Margarita', 80000, N'Đồ uống',0)
insert into QLSP values ('SP10',N'Cocktail Espresso Martini', 250000, N'Đồ uống',0)
insert into QLSP values ('SP11',N'Bánh sừng bò hạnh nhân', 53000, N'Đồ ăn',0)
insert into QLSP values ('SP12',N'Bánh mỳ cuộn nho khô',50000, N'Đồ ăn',0)
insert into QLSP values ('SP13',N'Bánh mỳ chuối',50000, N'Đồ ăn',0)
insert into QLSP values ('SP14',N'Bánh ngàn lớp phô mai kem',45000, N'Đồ ăn',0)
insert into QLSP values ('SP15',N'Bánh kếp với si rô cây phong',48000, N'Đồ ăn',0)

select * from QLSP







