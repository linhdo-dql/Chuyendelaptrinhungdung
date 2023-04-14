use master
go
create database BHCC
go
use BHCC
go
create table NhanVien (
	idNhanVien nvarchar(10) Not Null constraint pk_NV_MNV primary key,
	tenNV nvarchar(100),
	gioiTinh nvarchar(5) check (GioiTinh in(N'Nam',N'Nữ',N'Khác')),
	diaChi nvarchar(100),
	sdtNV nvarchar(15),
	namSinh datetime
)
go
create table KhachHang(
	idKH nvarchar(10) constraint pk_K_MK primary key,
	tuoiKH int,
	tenKH nvarchar(100),
	diaChiKH nvarchar(100),
	sdtKH nvarchar(15)
)
go
create table LoaiCay(
	idLoaiCay nvarchar(10) constraint pk_LC_MLC primary key,
	tenLoaiCay nvarchar(100),
	moTa nvarchar(100)
)
go
create table CayCanh(
	idCayCanh nvarchar(10) constraint pk_CC_MCC primary key,
	tenCay nvarchar(100),
	idLoaiCay nvarchar(10) constraint fk_CC_MLC foreign key references LoaiCay(idLoaiCay),
	soLuong int,
	gia float,
	tuoi int,
	mausac nvarchar(200),
	anh nvarchar(200),
	moTa nvarchar(200),
)
go
create table ChiTietHoaDon(
	idCTHD nvarchar(10) constraint pk_CTHD primary key ,
	idCayCanh nvarchar(10) constraint fk_CTHD_CC foreign key references CayCanh(idCayCanh),
	idHoaDon nvarchar(10) constraint fk_CTHD_HD foreign key references HoaDon(idHoaDon),
	soLuong int,
	donGia float,
	giamGia float,
	thanhTien float
)
go
create table HoaDon(
	idHoaDon nvarchar(10) 
	constraint pk_HD primary key(idHoaDon),
	idNhanVien nvarchar(10) constraint fk_HD_MaNV foreign key references NhanVien(idNhanVien),
	ngayLap datetime,
	idKH nvarchar(10) constraint fk_HD_MK foreign key references KhachHang(idKH),
	tongTien float,
)
go
create table TaiKhoan(

	idNhanVien nvarchar(10) constraint fk_TK_NV foreign key references NhanVien(idNhanVien),
	matKhau nvarchar(100),
	constraint pk_TK primary key(idNhanVien)
)
go