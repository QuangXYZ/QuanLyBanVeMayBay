create database QuanLyBanVeMayBay
use QuanLyBanVeMayBay

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
)
create table CHUYENBAY
(
	MACHUYENBAY char(5) not null primary key,
	MAMAYBAY char(5),
	SANBAYDI char(5),
	SANBAYDEN char(5),
	SOLUONGGHE int,
	SOLUONGGHEHANG1 int,
	SOLUONGGHEHANG2 int,
	NGAYBAY smalldatetime,
)

create table KHACKHANG
(
	MAKHACHHANG char(5) not null primary key,
	TENKHACHHANG varchar(40),
	CMND varchar(20),
	QUOCTICH varchar(40),
	
)
create table HANG
(
	MAHANG char(5) not null primary key,
	TENHANG char(40),
)
create table VE
(
	MAVE char(5) not null primary key,
	MACHUYENBAY char(5),
	MAKHACHANG char(5),
	GIA varchar(20),
	MAHANG char(5),
)

alter table CHUYENBAY add constraint FK_MAMAYBAY foreign key (MAMAYBAY) references MAYBAY(MAMAYBAY)
alter table CHUYENBAY add constraint FK_SANBAYDI foreign key (SANBAYDI) references SANBAY(MASANBAY)
alter table CHUYENBAY add constraint FK_SANBAYDEN foreign key (SANBAYDEN) references SANBAY(MASANBAY)
alter table CHUYENBAY add constraint FK_MACHUYENBAY foreign key (MACHUYENBAY) references CHUYENBAY(MACHUYENBAY)


insert into SANBAY(MASANBAY,TENSANBAY,QUOCGIA) values 
('123','SAN BAY HN','VIETNAM')