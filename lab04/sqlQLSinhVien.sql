Create database QuanLySinhVien
use QuanLySinhVien

Create table Student
(
    StudentID NVARCHAR(20) PRIMARY KEY,
    Fullname NVARCHAR(200),
    AverageScore float,
    FacultyID int
)

Create table Faculty
(
    FacultyID int PRIMARY KEY,
    FacultyName NVARCHAR(200)
)