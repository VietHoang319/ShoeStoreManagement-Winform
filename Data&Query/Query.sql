Create database ShoeStore

On primary(
Name = ShoeStore_data,
FileName = 'E:\Project\ShoeStore\ShoeStore_dat.mdf',
Size = 10MB,
MaxSize = 50MB,
FileGrowth = 2MB)

Log on(
Name = ShoeStore_log,
FileName = 'E:\Project\ShoeStore\ShoeStore_lg.ldf',		
Size = 5MB,
MaxSize = 20MB,
FileGrowth = 1MB);

Use ShoeStore

--Supplire(ID, Name, Address, Number phone, Website)
Create table Supplier(
IDSupp int not null primary key identity(1, 1),
NameSupp nvarchar(30) not null,
AddressSupp nvarchar(100),
NumpSupp char(11),
WebSupp varchar(50));

--Type Of Goods(ID, Name)
Create table TOGs(
IDTOGs int not null primary key identity(1, 1),
NameTOGs nvarchar(30) not null);

--Product(ID, Name, Size, Price, Entry price, The number of product, Picture, Note)
Create table Product(
IDProduct varchar(20) not null primary key,
NameProduct nvarchar(100) not null,
IDSupp int not null,
IDTOGs int not null,
Size int,
Price float not null,
EntryPrice float,
TNOP int default 0,
Picture nvarchar(200),
Note nvarchar(200),
Foreign key (IDSupp) references Supplier(IDSupp),
Foreign key (IDTOGs) references TOGs(IDTOGs));

--Employee(ID, Name, Address, Sex, CMTND, Picturem Number phone, Email, Usename, Password, Position)
Create table Employee(
IDEmployee int not null primary key identity(1, 1),
NameEmployee nvarchar(30) not null,
AddressEmployee nvarchar(100),
Sex nvarchar(4),
CMTND char(12) not null,
Picture nvarchar(200),
NumpEmployee char(11),
Usename varchar(30),
Pass varchar(30),
Position nvarchar(30));

--OrderEntry(ID, Date entry, The total amount, Note)
Create table OrderEntry(
IDOE nvarchar(30) not null primary key,
IDEmployee int not null,
DateEntry datetime,	
TotalAmount float,
Note nvarchar(200),
Foreign key (IDEmployee) references Employee(IDEmployee));

-- EntryLineItem(Entry number, Into money)
Create table EntryLineItem(
IDOE nvarchar(30),
IDProduct varchar(20),
EntryNumber int,
IntoMoney float,
Primary key (IDOE, IDProduct),
Foreign key (IDOE) references OrderEntry(IDOE),
Foreign key (IDProduct) references Product(IDProduct));

--Customer(ID, Name, Address, Number phone, CMTND, Note)
Create table Customer(
IDCus int not null primary key identity(1, 1),
NameCus nvarchar(30) not null,
AddressCus nvarchar(100),
NumpCus char(11),
CMTND char(12),
Note nvarchar(200));

--Order(ID, Date order, TotalAmount)
Create table Orders(
IDOrder nvarchar(30) not null primary key,
IDCus int,
IDEmployee int,
DateOrder datetime,
TotalAmount float,
Foreign key (IDCus) references Customer(IDCus),
Foreign key (IDEmployee) references Employee(IDEmployee));

--InfoOrder(Order number, Sale, Into money)
Create table InfoOrder(
IDOrder nvarchar(30),
IDProduct varchar(20),
OrderNumber int,
Sale float,
IntoMoney float,
Primary key (IDOrder, IDProduct),
Foreign key (IDOrder) references Orders(IDOrder),
Foreign key (IDProduct) references Product(IDProduct));

-- Bảng ảo Lần nhập cuối
Create view v_LastUpdate(IDProduct, LastDay)
As
Select IDProduct, Max(DateEntry)
From EntryLineItem, OrderEntry
Where EntryLineItem.IDOE = OrderEntry.IDOE
Group by IDProduct;

-- Bảng ảo thông tin Sản phẩm
Create view v_Info_Product(IDProduct, NameProduct, Supplier, TOGs, Size, TNOP, Price, EntryPrice, LastDay, Picture, Note)
As
Select Product.IDProduct, NameProduct, NameSupp, NameTOGs, Size, TNOP, Price, EntryPrice, LastDay, Picture, Note
From Product, Supplier, TOGs, v_LastUpdate
Where Product.IDProduct = v_LastUpdate.IDProduct and Product.IDSupp = Supplier.IDSupp and Product.IDTOGs = TOGs.IDTOGs;

-- Hàm tìm kiếm sản phẩm
Create function f_SearchProduct(@ID varchar(10))
Returns table
As
Return select * from v_Info_Product where IDProduct = @ID;

-- Trigger Cập nhật Ghi chú Sản phẩm
Create trigger t_Update_Note_Product
On Product
For update as
if ((Select TNOP from Product where IDProduct = (Select IDProduct from deleted)) = 0)
Begin
Update Product
Set Note = N'Sản phầm này đã hết hàng' 
Where IDProduct = (Select IDProduct from deleted)
End
if ((Select TNOP from Product where IDProduct = (Select IDProduct from deleted)) > 0)
Begin
Update Product
Set Note = N'Sản phầm này có sẵn' 
Where IDProduct = (Select IDProduct from deleted)
End;

-- Trigger cập nhật Ghi chú của khách hàng
Create trigger t_Update_Note_Customer
On Orders
For Insert as
if (((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) >= 5) and ((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) < 10))
Begin
Update Customer
Set Note = N'Thành viên Đồng'
Where IDCus = (Select IDCus from inserted)
End
if (((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) >= 10) and ((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) < 20))
Begin
Update Customer
Set Note = N'Thành viên Bạc'
Where IDCus = (Select IDCus from inserted)
END
if (((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) >= 20) and ((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) < 50))
Begin
Update Customer
Set Note = N'Thành viên Vàng'
Where IDCus = (Select IDCus from inserted)
END
if (((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) >= 50) and ((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) < 100))
Begin
Update Customer
Set Note = N'Thành viên Bạch Kim'
Where IDCus = (Select IDCus from inserted)
END
if ((Select SUM(OrderNumber) from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder and IDCus = (Select IDCus from inserted) group by IDCus) >= 100)
Begin
Update Customer
Set Note = N'Thành viên Kim Cương'
Where IDCus = (Select IDCus from inserted)
END;

Create view v_test(IDOrder, TotalON)
as
select DIstinct IDOrder, SUM(OrderNumber) from InfoOrder group by IDOrder;

Create view v_test1(IDO, IDCus, IDEmployee, DateOrder, TotalON, TotalAmount)
as
select Orders.IDOrder, IDCus, IDEmployee, DateOrder,TotalON, TotalAmount from v_test, Orders where v_test.IDOrder = Orders.IDOrder;

-- Tạo bảng ảo thông tin báo cáo theo thời gian
Create view v_R_InfoMonthly(DateOrder, TotalOrder, TotalMoney, TotalON)
As
Select Convert(date, DateOrder), Count(IDO), Sum(TotalAmount), SUM(TotalON) from v_test1 group by Convert(date, DateOrder);

-- Tạo hàm thông tin báo cáo theo tháng
Create function f_R_InfoMonthly(@mm char(2), @yyyy char(4))
Returns table
As
Return select * from v_R_InfoMonthly where cast(DATEPART(mm, Convert(date, DateOrder))as char(2)) = @mm and 
cast(DATEPART(YYYY, Convert(date, DateOrder))as char(4)) = @yyyy;

-- Tạo hàm ảo thống kê tổng đơn hàng và tổng số tiền kiếm đc trong tháng
Create function f_R_TotalMonthly(@mm char(2), @yyyy char(4))
Returns @Bien table(TotalOrder int , TotalMoney int )
As begin insert into @Bien
select SUM(TotalOrder), SUM(TotalMoney) from v_R_InfoMonthly where cast(DATEPART(mm, Convert(date, DateOrder))as char(2)) = @mm and 
cast(DATEPART(YYYY, Convert(date, DateOrder))as char(4)) = @yyyy
Return
End;

-- Tạo hàm thông tin sản phẩm có nhiều đơn hàng nhất
Create function f_R_PMO(@mm char(2), @yyyy char(4))
Returns @Bien table(IDP varchar(20), TotalOrder_P int)
As
Begin
Insert into @Bien
Select distinct left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1), Count(InfoOrder.IDOrder) from InfoOrder, Orders
where InfoOrder.IDOrder = Orders.IDOrder and MONTH(DateOrder) = @mm and YEAR(DateOrder) = @yyyy
Group by left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1)
having Count(InfoOrder.IDOrder) = (select max(M.c) From (Select Count(IDOrder) as c from InfoOrder 
Group by left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1)) as M)
Return
End;

-- Tạo hàm thông tin sản phẩm có doanh thu cao nhất
Create function f_R_PMM(@mm char(2), @yyyy char(4))
Returns @Bien table(IDP varchar(20), TotalMoney_P int)
As
Begin
Insert into @Bien
Select distinct left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1), Sum(TotalAmount) from InfoOrder, Orders
where InfoOrder.IDOrder = Orders.IDOrder and MONTH(DateOrder) = @mm and YEAR(DateOrder) = @yyyy
Group by left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1)
having SUM(TotalAmount) = (select max(M.t) From (Select SUM(TotalAmount) as t from Orders, InfoOrder where Orders.IDOrder = InfoOrder.IDOrder
Group by left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1)) as M)
Return
End;

-- Tạo hàm thông tin sản phẩm có số lượng bán ra nhiều nhất
Create function f_R_PMON(@mm char(2), @yyyy char(4))
Returns @Bien table(IDP varchar(20), TotalON_P int)
As
Begin
Insert into @Bien
Select distinct left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1), SUM(OrderNumber) from InfoOrder, Orders
where InfoOrder.IDOrder = Orders.IDOrder and MONTH(DateOrder) = @mm and YEAR(DateOrder) = @yyyy
Group by left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1)
having SUM(OrderNumber) = (select max(M.onp) From (Select SUM(OrderNumber) as onp from InfoOrder 
Group by left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1)) as M)
Return
End;

-- Tạo hàm ảo thông tin báo cáo theo năm
Create function f_R_TotalAnnual(@yyyy char(4))
Returns @Bien table(TotalOrder int , TotalMoney float, TotalON int)
As begin insert into @Bien
select SUM(TotalOrder), SUM(TotalMoney), SUM(TotalON) from v_R_InfoMonthly where cast(DATEPART(YYYY, Convert(date, DateOrder))as char(4)) = @yyyy
Return
End;

Create view v_R_Interest(DateEntry, TotalAmount)
As	
Select Convert(date, DateEntry), SUM(TotalAmount) from OrderEntry group by Convert(date, DateEntry);

-- Tạo hàm ảo báo cáo số tiền nhập
Create function f_R_TotalMoneyEntry(@yyyy char(4))
Returns @Bien table(TotalMoneyEntry float)
As begin insert into @Bien
select SUM(TotalAmount) from v_R_Interest where cast(DATEPART(YYYY, Convert(date, DateEntry))as char(4)) = @yyyy
Return
End;

select N'Tháng' + cast(DATEPART(MM, Convert(date, DateOrder))as char(2)), SUM(TotalOrder), SUM(TotalMoney), SUM(TotalON) 
from v_R_InfoMonthly where cast(DATEPART(YYYY, Convert(date, DateOrder))as char(4)) = '2020'
Group by cast(DATEPART(MM, Convert(date, DateOrder))as char(2))
