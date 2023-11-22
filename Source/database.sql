-- Tạo database
CREATE DATABASE CuaHangSuaChuaXeMay;

-- Sử dụng database 
USE CuaHangSuaChuaXeMay;


CREATE TABLE NGNHAN (
  MaNguoiNhan INT PRIMARY KEY NOT NULL,
  TenNguoiNhan NVARCHAR(30)
);

CREATE TABLE GIAIPHAP (
  MaGiaiPhap INT PRIMARY KEY NOT NULL,
  TenGiaiPhap NVARCHAR(30)
);


CREATE TABLE KHACHHANG (
  MaKhach INT PRIMARY KEY NOT NULL,
  TenKhach NVARCHAR(30),
  DiaChi NVARCHAR(50),
  DienThoai VARCHAR(20)
);


CREATE TABLE NHANVIEN (
  MaNV INT PRIMARY KEY NOT NULL,
  TenNV NVARCHAR(30),
  NgaySinh DATE,
  MaTrinhDo INT  
);

CREATE TABLE PHUTUNG (
  MaPhuTung INT PRIMARY KEY NOT NULL,
  TenPhuTung NVARCHAR(100),
  SoLuong INT,
  DonGiaNhap FLOAT,
  DonGiaBan FLOAT, 
  MaLoai INT
);

CREATE TABLE YEUCAUSUACHUA (
  MaYeuCau INT PRIMARY KEY NOT NULL,
  MaXe INT,
  MaKhach INT,
  NgaySua DATE,
  MaNguoiNhan INT,
  MaGiaiPhap INT,
  MaNV INT,
  TongTien FLOAT
); 

CREATE TABLE TRINHDO (
  MaTrinhDo INT PRIMARY KEY NOT NULL,
  TenTrinhDo NVARCHAR(50)  
);

CREATE TABLE XEMAY (
  MaXe INT PRIMARY KEY NOT NULL,
  TenXe NVARCHAR(100),
  MaLoai INT,
  SoKhung VARCHAR(20),
  SoMay VARCHAR(20),
  BienSo VARCHAR(20),
  MaMau INT
);

CREATE TABLE SUACHUA_PHUTUNG (
  MaYeuCau INT,
  MaPhuTung INT,
  SoLuong INT,
  ThanhTien FLOAT
);

CREATE TABLE CHITIETHDNHAP (
  MaHDNhap INT ,
  MaPhuTung INT,
  SoLuongNhap INT,
  DonGiaNhap FLOAT,
  ThanhTien FLOAT
);

CREATE TABLE LOAIXE (
  MaLoai INT PRIMARY KEY NOT NULL,
  TenLoai NVARCHAR(100)
);  

CREATE TABLE HOADONNHAP (
  MaHDNhap INT PRIMARY KEY NOT NULL,
  NgayNhap DATE,
  MaNguoiNhan INT,
  TongTien FLOAT
);

-- Thêm các ràng buộc khóa ngoại


-- NGƯỜI NHẬN
INSERT INTO NGNHAN (MaNguoiNhan, TenNguoiNhan)
VALUES 
  (1, N'Nguyễn Văn A'),
  (2, N'Trần Văn B'),
  (3, N'Lê Thị C');

-- GIẢI PHÁP
INSERT INTO GIAIPHAP (MaGiaiPhap, TenGiaiPhap)  
VALUES
  (1, N'Sửa động cơ'), 
  (2, N'Thay dầu'),
  (3, N'Thay lốp');

-- KHÁCH HÀNG
INSERT INTO KHACHHANG (MaKhach, TenKhach, DiaChi, DienThoai)
VALUES
  (1, N'Nguyễn Thị X', N'Hà Nội', '012345678'),
  (2, N'Trần Văn Y', N'TP HCM', '023456789'),
  (3, N'Lê Văn Z', N'Đà Nẵng', '034567890');
  
-- NHÂN VIÊN
INSERT INTO NHANVIEN (MaNV, TenNV, NgaySinh, MaTrinhDo)
VALUES  
  (1, N'Nguyễn Văn D', '2000-01-01', 1),
  (2, N'Trần Thị E', '2001-02-15', 2), 
  (3, N'Lê Thị F', '2002-05-20', 3);
  
-- PHỤ TÙNG  
INSERT INTO PHUTUNG (MaPhuTung, TenPhuTung, SoLuong, DonGiaNhap, DonGiaBan, MaLoai)
VALUES
  (1, N'Động cơ xe máy', 10, 2000000, 2250000, 1),
  (2, N'Dầu nhớt', 20, 50000, 60000, 2),
  (3, N'Lốp xe', 15, 300000, 350000, 3);
  
-- YÊU CẦU SỬA CHỮA
INSERT INTO YEUCAUSUACHUA (MaYeuCau, MaXe, MaKhach, NgaySua, MaNguoiNhan, MaGiaiPhap, MaNV, TongTien)
VALUES
  (1, 1, 1, '2023-01-01', 1, 1, 1, 500000),
  (2, 2, 2, '2023-01-05', 2, 2, 2, 100000),
  (3, 3, 3, '2023-01-10', 3, 3, 3, 150000);

-- TRÌNH ĐỘ
INSERT INTO TRINHDO (MaTrinhDo, TenTrinhDo)  
VALUES
  (1, N'Trung cấp'),
  (2, N'Cao đẳng'),
  (3, N'Đại học');
  
-- XE MÁY
INSERT INTO XEMAY (MaXe, TenXe, MaLoai, SoKhung, SoMay, BienSo, MaMau)
VALUES
  (1, N'Wave Alpha', 1, 'ABC123', 'XYZ456', '29X1-1234', 1),
  (2, N'Honda Airblade', 2, 'BCD234', 'ZXY567', '29X2-2345', 2),
  (3, N'Yamaha Exciter', 3, 'CDE345', 'VWX789', '29X3-3456', 3);  

-- SỬA CHỮA - PHỤ TÙNG
INSERT INTO SUACHUA_PHUTUNG (MaYeuCau, MaPhuTung, SoLuong, ThanhTien)  
VALUES
  (1, 1, 1, 200000),
  (1, 3, 2, 300000),
  (2, 2, 10, 500000);
  
-- CHI TIẾT HÓA ĐƠN NHẬP
INSERT INTO CHITIETHDNHAP (MaHDNhap, MaPhuTung, SoLuongNhap, DonGiaNhap, ThanhTien)
VALUES
  (1, 1, 5, 1500000, 7500000),
  (2, 2, 10, 40000, 400000),
  (3, 3, 8, 250000, 2000000);

-- LOẠI XE
INSERT INTO LOAIXE (MaLoai, TenLoai)
VALUES
  (1, N'Xe số'),
  (2, N'Xe ga'),
  (3, N'Xe côn tay'); 

-- HÓA ĐƠN NHẬP  
INSERT INTO HOADONNHAP (MaHDNhap, NgayNhap, MaNguoiNhan, TongTien)
VALUES
  (1, '2023-01-01', 1, 10000000),
  (2, '2023-01-10', 2, 500000),
  (3, '2023-01-15', 3, 3000000);