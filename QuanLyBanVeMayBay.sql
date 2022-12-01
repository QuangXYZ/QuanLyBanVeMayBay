create database QuanLyBanVeMayBay
use QuanLyBanVeMayBay


create table SANBAY
(
	MASANBAY char(5) not null,
	TENSANBAY varchar(40),
	QUOCGIA varchar(40),
)
create table MAYBAY
(
	MAMAYBAY char(5) not null,
	TENMAYBAY varchar(40),
	LOAI varchar(40),
	SOGHE int,
)
create table CHUYENBAY
(
	MACHUYENBAY char(5) not null,
	SANBAYDI varchar(40),
	SANBAYDEN varchar(40),
	SOLUONGGHE int,
	SOLUONGGHEHANG1 int,
	SOLUONGGHEHANG2 int,
	NGAYBAY smalldatetime,
)


insert into SANBAY(MASANBAY,TENSANBAY,QUOCGIA) values 
('123','SAN BAY HN','VIETNAM')
