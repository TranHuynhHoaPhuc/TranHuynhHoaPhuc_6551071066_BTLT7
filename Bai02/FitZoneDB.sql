IF DB_ID(N'FitZoneDB') IS NULL
BEGIN
    CREATE DATABASE FitZoneDB;
END
GO

USE FitZoneDB;
GO

IF OBJECT_ID(N'dbo.HoiVien', N'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.HoiVien;
END
GO

CREATE TABLE dbo.HoiVien
(
    MaHV INT IDENTITY(1,1) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh BIT NOT NULL,
    NgaySinh DATE NOT NULL,
    SDT VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    HangThanhVien NVARCHAR(20) NOT NULL,
    NgayDangKy DATETIME NOT NULL
        CONSTRAINT DF_HoiVien_NgayDangKy DEFAULT GETDATE(),
    TrangThai BIT NOT NULL
        CONSTRAINT DF_HoiVien_TrangThai DEFAULT 1,

    CONSTRAINT PK_HoiVien PRIMARY KEY (MaHV),

    CONSTRAINT CK_HoiVien_GioiTinh
        CHECK (GioiTinh IN (0, 1)),

    CONSTRAINT CK_HoiVien_NgaySinh
        CHECK (NgaySinh <= CAST(GETDATE() AS DATE)),

    CONSTRAINT CK_HoiVien_SDT
        CHECK
        (
            SDT IS NULL
            OR
            (
                LEN(SDT) BETWEEN 9 AND 11
                AND SDT NOT LIKE '%[^0-9]%'
            )
        ),

    CONSTRAINT CK_HoiVien_Email
        CHECK
        (
            Email IS NULL
            OR Email LIKE '%@%'
        ),

    CONSTRAINT CK_HoiVien_HangThanhVien
        CHECK
        (
            HangThanhVien IN
            (
                N'Basic',
                N'VIP',
                N'Premium'
            )
        ),

    CONSTRAINT CK_HoiVien_TrangThai
        CHECK (TrangThai IN (0, 1))
);
GO

INSERT INTO dbo.HoiVien
(
    HoTen,
    GioiTinh,
    NgaySinh,
    SDT,
    Email,
    HangThanhVien,
    TrangThai
)
VALUES
(
    N'Nguyễn Văn An',
    1,
    '2000-05-10',
    '0912345678',
    'an@gmail.com',
    N'Basic',
    1
),
(
    N'Trần Thị Bình',
    0,
    '1999-08-15',
    '0987654321',
    'binh@gmail.com',
    N'VIP',
    1
),
(
    N'Lê Văn Cường',
    1,
    '2002-02-20',
    '0901234567',
    'cuong@gmail.com',
    N'Premium',
    1
),
(
    N'Phạm Thị Dung',
    0,
    '2001-11-12',
    '0934567890',
    'dung@gmail.com',
    N'Basic',
    0
);
GO

SELECT *
FROM dbo.HoiVien;