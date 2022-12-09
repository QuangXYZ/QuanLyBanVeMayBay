create database QuanLyBanVeMayBay
use QuanLyBanVeMayBay


create table USERS (
	TENUSER char(10) not null primary key,
	MATKHAU char(10),
	ISADMIN int
)
insert into USERS(TENUSER,MATKHAU,ISADMIN) values 
('Admin','123456',1)

create table SANBAY
(
	MASANBAY char(5) not null primary key,
	TENSANBAY varchar(40),
	QUOCGIA varchar(40),
)

create table MAYBAY
(
	MAMAYBAY char(5) not null primary key,
	TENMAYBAY varchar(40),
	LOAI varchar(40),
	SOGHE int,
	THUONGGIA int,
	PHOTHONG int,
)

create table CHUYENBAY
(
	MACHUYENBAY char(5) not null primary key,
	MAMAYBAY char(5),
	SANBAYDI char(5),
	SANBAYDEN char(5),
	SOLUONGBANHANG1 int,
	SOLUONGBANHANG2 int,
	NGAYBAY smalldatetime,
)

create table VE
(
	MAVE char(5) not null primary key,
	MACHUYENBAY char(5),
	MAKHACHANG char(5),
	TENKHACHHANG varchar(40),
	CMND varchar(20),
	QUOCTICH varchar(40),
	GIA varchar(20),
	HANGVE char(5),
)

create table NHANVIEN
(
	MANHANVIEN char(5) not null primary key,
	TENNHANVIEN varchar(40),
	MAMAYBAY char(5),
	CMND varchar(20),
	SDT char(15),
	DIACHI char(40),
	
)





insert into SANBAY(MASANBAY,TENSANBAY,QUOCGIA) values 
('SB001','SAN BAY HN','VIETNAM')

insert into SANBAY(MASANBAY,TENSANBAY,QUOCGIA) values 
('SB002','SAN BAY SG','VIETNAM')

insert into SANBAY(MASANBAY,TENSANBAY,QUOCGIA) values 
('SB003','SAN BAY DN','VIETNAM')



insert into NHANVIEN(MANHANVIEN,TENNHANVIEN,MAMAYBAY,CMND,SDT,DIACHI) values 
('NV001','Nguyen Thanh Quang','MB001','123456789','0987654321','273 An Duong Vuong')




insert into MAYBAY(MAMAYBAY,TENMAYBAY,LOAI,SOGHE,THUONGGIA,PHOTHONG) values 
('MB001','MAYBAY 123','Boing',200,50,150)
insert into MAYBAY(MAMAYBAY,TENMAYBAY,LOAI,SOGHE,THUONGGIA,PHOTHONG) values 
('MB002','MAYBAY 123','Boing',200,100,100)
insert into MAYBAY(MAMAYBAY,TENMAYBAY,LOAI,SOGHE,THUONGGIA,PHOTHONG) values 
('MB003','MAYBAY 123','Boing',300,150,150)
insert into MAYBAY(MAMAYBAY,TENMAYBAY,LOAI,SOGHE,THUONGGIA,PHOTHONG) values 
('MB004','MAYBAY 123','Boing',100,50,50)
insert into MAYBAY(MAMAYBAY,TENMAYBAY,LOAI,SOGHE,THUONGGIA,PHOTHONG) values 
('MB005','MAYBAY 123','Boing',200,50,150)





insert into CHUYENBAY(MACHUYENBAY,MAMAYBAY,SANBAYDI,SANBAYDEN,SOLUONGBANHANG1,SOLUONGBANHANG2,NGAYBAY) values 
('CB001','MB002','SB002','SB001',10,10,'2022-11-12 00:00:00')
insert into CHUYENBAY(MACHUYENBAY,MAMAYBAY,SANBAYDI,SANBAYDEN,SOLUONGBANHANG1,SOLUONGBANHANG2,NGAYBAY) values 
('CB002','MB003','SB004','SB002',10,10,'2022-11-12 00:00:00')
insert into CHUYENBAY(MACHUYENBAY,MAMAYBAY,SANBAYDI,SANBAYDEN,SOLUONGBANHANG1,SOLUONGBANHANG2,NGAYBAY) values 
('CB009','MB001','SB001','SB002',10,10,'2022-11-12 00:00:00')
insert into CHUYENBAY(MACHUYENBAY,MAMAYBAY,SANBAYDI,SANBAYDEN,SOLUONGBANHANG1,SOLUONGBANHANG2,NGAYBAY) values 
('CB004','MB001','SB001','SB002',1,1,'2022-11-12 00:00:00')