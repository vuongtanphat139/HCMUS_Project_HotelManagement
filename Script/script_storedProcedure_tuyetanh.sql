--exec usp_getDiscountOfService_svs 'SEV0793150'
--exec usp_AddServiceCoupon 'C9909', N'Học nhào lộn - Club Med Punta Cana', 'SEV0793150', N'Học nhào lộn - Club Med Punta Cana', 6469, 4, 'C9909', 25876, '6/27/2023 12:00:00 AM', 2.48, ''
---- usp_AddServiceCoupon 'C0250',N'gÂU GÂU','SEV0793150','LA A',1241223,23,'EMP00',51253234,null,4 ,'B0000'
--exec usp_AddServiceCoupon 'C9909', N'Học nhào lộn - Club Med Punta Cana', 'SEV0793150', N'Học nhào lộn - Club Med Punta Cana', 6469, 4, 'EMP00', 25876, '6/27/2023 12:00:00 AM', 2.48, 'B0000'
--select * from CUSTOMER_TOUR
--select * from PARTNER_TOUR
--usp_createServiceCoupon_svs(@customer char(5), @name nvarchar(100),@serviceId char(10), @description nvarchar(100), @price int, @amount int, @empid char(5), @total_price int, @usingdate char(30), @discount float, @idbill char(5) ) 
-- —Screen 1: Services for customer

-- 1. search bằng roomid
select * from CUSTOMER_TOUR
use HotelManagement
go

create 
--alter 
proc usp_SearchRoomByID_svs(@roomid char(5)) 
as 
begin transaction
	select bf.ID_BOOKING, br.ID_ROOM, cus.ID_CUSTOMER, cus.NAME, cus.PHONE, bf.ARRIVAL_DATE, bf.DEPARTURE_DATE  from BOOKING_ROOM br join BOOKING_FORM bf on br.ID_BOOKING = bf.ID_BOOKING
		join CUSTOMER cus on bf.CUSTOMER= cus.ID_CUSTOMER 
		where br.ID_ROOM=@roomid
		order by bf.ARRIVAL_DATE 
commit

exec usp_SearchRoomByID_svs '1002';
-- 


go
-- 3. ds các dịch vụ của phòng đó
create 
--alter 
proc usp_getServicesOfRoom_svs(@roomid char(5), @serv nvarchar(100)) 
as 
begin transaction
	select ser.ID_SERVICE, NAME, ser.UNIT, ser.PRICE, ser.STATUS from HOTEL_SERVICE ser join ROOM_SERVICE rser on ser.ID_SERVICE = rser.ID_SERVICE 
	where rser.ID_ROOM=@roomid and ser.NAME like '%' + @serv + '%'
commit

exec usp_getServicesOfRoom_svs '1002', N'';

select * from DISCOUNT_PROMOTION;
select * from DISCOUNT_SERVICE;
select * from HOTEL_SERVICE;
select * from ROOM_SERVICE;
select * from SERVICE_BILL
select * from SERVICE_BILL
--4 . 4. chi tiết service
go

create 
--alter 
proc usp_getDetailOfService_svs(@serviceId char(10)) 
as 
begin transaction
	select ID_SERVICE, Name, DESCRIPTION, PRICE, UNIT, STATUS from HOTEL_SERVICE ser
	where ser.ID_SERVICE=@serviceId
commit


exec usp_getDetailOfService_svs 'SEV0793150'


go

create 
--alter 
proc usp_getDiscountOfService_svs(@serviceId char(10)) 
as 
begin transaction
	select * from DISCOUNT_PROMOTION disc join DISCOUNT_SERVICE disc_ser on disc.ID_DISCOUNT=disc_ser.ID_DISCOUNT
	where disc_ser.ID_SERVICE=@serviceId --and disc.START_TIME < GETDATE() and disc.END_TIME > GETDATE()
commit

go

create 
--alter 
proc usp_getAllServices_svs(@nameServ nvarchar(20)) 
as 
begin transaction
	--set @nameServ = @nameServ + '%';
	select * from HOTEL_SERVICE ser
	where ser.NAME like '%' + @nameServ + '%'
commit

exec usp_getAllServices_svs N'';

--
go
create 
--alter 
proc usp_createServiceCoupon_svs(@customer char(5), @name nvarchar(100),@serviceId char(10), @description nvarchar(100), @price int, @amount int, @empid char(5), @total_price int, @usingdate char(30), @discount float, @idbill char(5) ) 
as 
begin transaction
	declare @idserviceBill char(5);
	set @idbill= '12345';
	set @idserviceBill='12345'
	--set @
	--insert into SERVICE_FORM (ID_SERVICE_FORM, NAME, DESCRIPTION, PRICE, AMOUNT, ID_SERVICE, FORM_CREATOR, CUSTOMER)
	--values(@idserviceBill,@name, @description,@price, @amount, @serviceId, null, @customer);

	--insert into SERVICE_BILL (ID_SERVICE_BILL, TOTAL_PRICE, USED_DATE, DISCOUNT, ID_SERVICE_FORM, ID_BILL, CUSTOMER) 
	--values (@idbill, @total_price, @usingdate, @discount, @idserviceBill, @idbill, @customer)

commit

GO
CREATE
--ALTER
PROC usp_AddServiceCoupon(
	@IDCUS CHAR(5),
	@NAMESERVICE NVARCHAR(100),
	@SERVICEID CHAR(10),
	@DESCRIPT NVARCHAR(100),
	@PRICE INT,
	@AMOUNT INT,
	@EMPID CHAR(5),
	@TOTAL_PRICE INT,
	@USINGDATE DATETIME,
	@DISCOUNT FLOAT,
	@ID_BILL CHAR(5)
)
AS
BEGIN transaction
	DECLARE @IDSERVICE CHAR(10) = DBO.CREATE_IDSERVICE_BF()
	set @EMPID='EMP00'
	INSERT INTO SERVICE_FORM VALUES(@IDSERVICE,@NAMESERVICE,@DESCRIPT,@PRICE,@AMOUNT,@SERVICEID,@EMPID,@IDCUS)
	INSERT INTO SERVICE_BILL VALUES(@IDSERVICE,@TOTAL_PRICE,@USINGDATE,@DISCOUNT,@IDSERVICE,'B0000',@IDCUS)
	--return 1;
COMMIT

select * from SERVICE_FORM
select * from SERVICE_BILL
select * from BOOKING_FORM
select * from HOTEL_SERVICE
select * from bill
select * from BOOKING_ROOM
go
-- usp_createTourForm_svs( @startDate varchar(30), @numPart int, @price int, 
--@travelMethod nvarchar(20), @status nvarchar(30), @idPartnerTour char(10), @id_cus char(10)) 
create 
--alter 
proc usp_getAllDepartureList_svs
as 
begin transaction
	select distinct departure_point from PARTNER_TOUR
commit

go
create 
--alter 
proc usp_getAllDestinationList_svs
as 
begin transaction
	select distinct destination from PARTNER_TOUR
commit

go
exec usp_getAllDepartureList_svs
select * from CUSTOMER_TOUR
go
create 
--alter 
proc usp_searchTour_svs( @depart nvarchar(30),@des nvarchar(30), @leavingDate char(50), @endDate char(50), @errorString char(2))
as 
begin transaction
	declare @departlike nvarchar(30) = '%' + @depart + '%'
	declare @deslike nvarchar(30) =  '%' + @des + '%'
	declare @error int = cast(@errorString as int)
	if (@leavingDate ='null') 
	set @leavingDate = null
	if (@endDate ='null') 
	set @endDate = null
	if (@leavingDate is not null and @endDate is not null) 
	begin
		select t.ID_TOUR,t.NAME,  t.DEPARTURE_POINt, t.DESTINATION, t.OWNER, t.MINIMUM_NUMBER, t.MAXIMUM_NUMBER, t.PRICE, t.TOTAL_DAY, s.START_TIME, s.END_TIME, t.ID_TOUR, p.NAME as TRAVEL_AGENCY
		 from PARTNER_TOUR t join schedule s on t.ID_TOUR= s.ID_TOUR join partner p on t.OWNER = p.ID_PARTNER
		where 
		t.DEPARTURE_POINT like @departlike 
		and t.DESTINATION like @deslike 
		and (@leavingDate >= s.START_TIME -@error and @leavingDate <= s.START_TIME + @error)
		and @endDate <= s.END_TIME + @error and @endDate >= s.END_TIME -@error
		--commit;
	end
		
	else if (@endDate is null and @leavingDate is not null)
	begin
		select t.ID_TOUR,t.NAME,  t.DEPARTURE_POINt, t.DESTINATION, t.OWNER, t.MINIMUM_NUMBER, t.MAXIMUM_NUMBER, t.PRICE, t.TOTAL_DAY, s.START_TIME, s.END_TIME, t.ID_TOUR, p.NAME as TRAVEL_AGENCY
		from PARTNER_TOUR t join schedule s on t.ID_TOUR= s.ID_TOUR join partner p on t.OWNER = p.ID_PARTNER
		where 
		t.DEPARTURE_POINT like @departlike 
		and t.DESTINATION like @deslike 
		and (@leavingDate >= s.START_TIME -@error and @leavingDate <= s.START_TIME + @error)
		--and @endDate <= s.END_TIME + @error and @endDate >= s.END_TIME -@error
	end
		
	 else if ( @leavingDate is null and @endDate is not null)
	begin
		select t.ID_TOUR,t.NAME,  t.DEPARTURE_POINt, t.DESTINATION, t.OWNER, t.MINIMUM_NUMBER, t.MAXIMUM_NUMBER, t.PRICE, t.TOTAL_DAY, s.START_TIME, s.END_TIME, t.ID_TOUR, p.NAME as TRAVEL_AGENCY
		from PARTNER_TOUR t join schedule s on t.ID_TOUR= s.ID_TOUR join partner p on t.OWNER = p.ID_PARTNER
		where 
		t.DEPARTURE_POINT like @departlike 
		and t.DESTINATION like @deslike 
		--and (@leavingDate >= s.START_TIME -@error and @leavingDate <= s.START_TIME + @error)
		and @endDate <= s.END_TIME + @error and @endDate >= s.END_TIME -@error
	end
		
	else if ( @leavingDate is null and @endDate is null)
	begin
		select t.ID_TOUR,t.NAME,  t.DEPARTURE_POINt, t.DESTINATION, t.OWNER, t.MINIMUM_NUMBER, t.MAXIMUM_NUMBER, t.PRICE, t.TOTAL_DAY, s.START_TIME, s.END_TIME, t.ID_TOUR,  p.NAME as TRAVEL_AGENCY
		from PARTNER_TOUR t join schedule s on t.ID_TOUR= s.ID_TOUR join partner p on t.OWNER = p.ID_PARTNER
		where 
		t.DEPARTURE_POINT like @departlike 
		and t.DESTINATION like @deslike 
		--and (@leavingDate >= s.START_TIME -@error and @leavingDate <= s.START_TIME + @error)
		--and @endDate <= s.END_TIME + @error and @endDate >= s.END_TIME -@error
	end

commit
go
go
create 
--alter 
proc usp_getCustomerByPhone_svs(@phone char(11))
as 
begin transaction
	select * from CUSTOMER where PHONE= @phone

commit
go
exec usp_getCustomerByPhone_svs '09285313679'
go
exec usp_createTourForm_svs '5/9/2023 5:47:01 AM', 2, 17683, N'Di bo', N'Đang chờ phản hồi từ đối tác du lịch', 'PT002', 'C0250'
exec usp_createTourForm_svs '5/9/2023 5:47:01 AM', 2, 17683, N'Di bo', N'Đang chờ phản hồi từ đối tác du lịch', 'PT002', 'C0250'
select * from CUSTOMER

go

select * from SERVICE_FORM 
select * from SERVICE_BILL
go
create 
--alter 
proc usp_createTourForm_svs( @startDate varchar(30), @numPart int, @price int, @travelMethod nvarchar(20), @status nvarchar(30), @idPartnerTour char(10), @id_cus char(10)) 
as 
begin transaction
	DECLARE @IDCusTour CHAR(10) = DBO.CREATE_IDCUSTOMERTOUR()
	--set @EMPID='EMP00'
	insert into CUSTOMER_TOUR(ID_CUSTOMER_TOUR, START_DATE, NUMBER_PARTICIPATION, PRICE, TRAVEL_METHOD, STATUS, ID_TOUR_ORIGIN, CUSTOMER)
	values (@IDCusTour, @startDate, @numPart, @price, @travelMethod, @status, @idPartnerTour, @id_cus);
commit

exec usp_createTourForm_svs '2023-5-26', 4, 1234, N'Xe lua', N'Tu choi', 'PT002','C0250'

go
create 
--alter 
proc usp_getServiceFormsByPhone_svs( @phone char(11)) 
as 
begin transaction
	select ID_SERVICE_FORM, sf.NAME, PRICE, AMOUNT , c.PHONE
	from SERVICE_FORM sf join CUSTOMER c on sf.CUSTOMER = c.ID_CUSTOMER
	where c.PHONE = @phone
commit
go
create 
--alter 
proc usp__svs( ) 
as 
begin transaction
	
commit
go
create 
--alter 
proc usp__svs( ) 
as 
begin transaction
	
commit
go
create 
--alter 
proc usp__svs( ) 
as 
begin transaction
	
commit

exec usp_createTourForm_svs '2023-5-26', 4, 1234, N'Xe lua', N'Tu choi', 'PT002','C0250'

select * from CUSTOMER
go
CREATE
-- ALTER
FUNCTION CREATE_IDSERVICE()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @ID CHAR(10)
	IF(NOT EXISTS (SELECT *
				   FROM HOTEL_SERVICE))
	BEGIN
		SET @ID = 'SEV0000001'
		RETURN @ID
	END
	ELSE
	BEGIN
		SELECT @ID = CAST(CAST(MIN(RIGHT(ID_SERVICE,7)) AS INT) + 1 AS CHAR(10))
		FROM HOTEL_SERVICE
		WHERE (RIGHT(ID_SERVICE,7) + 1) NOT IN (SELECT RIGHT(ID_SERVICE,7) FROM HOTEL_SERVICE)
	END

	DECLARE @TEMP INT = CAST(@ID AS INT)
	DECLARE @COUNT INT = 0

	WHILE(@TEMP >0)
	BEGIN
		SET @TEMP = @TEMP/10
		SET @COUNT = @COUNT + 1
	end
    
	DECLARE @CNT int =0
	WHILE(@CNT <> (7-@COUNT))
	BEGIN
		SET @ID = '0' + @ID
		SET @CNT = @CNT + 1
	END
	SET @ID = 'SEV' + @ID
	RETURN @ID
END
GO

CREATE
-- ALTER
FUNCTION CREATE_IDCUSTOMERTOUR()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @ID CHAR(10)
	IF(NOT EXISTS (SELECT *
				   FROM CUSTOMER_TOUR))
	BEGIN
		SET @ID = 'CST0000001'
		RETURN @ID
	END
	ELSE
	BEGIN
		SELECT @ID = CAST(CAST(MIN(RIGHT(ID_CUSTOMER_TOUR,7)) AS INT) + 1 AS CHAR(10))
		FROM CUSTOMER_TOUR
		WHERE (RIGHT(ID_CUSTOMER_TOUR,7) + 1) NOT IN (SELECT RIGHT(ID_CUSTOMER_TOUR,7) FROM CUSTOMER_TOUR)
	END

	DECLARE @TEMP INT = CAST(@ID AS INT)
	DECLARE @COUNT INT = 0

	WHILE(@TEMP >0)
	BEGIN
		SET @TEMP = @TEMP/10
		SET @COUNT = @COUNT + 1
	end
    
	DECLARE @CNT int =0
	WHILE(@CNT <> (7-@COUNT))
	BEGIN
		SET @ID = '0' + @ID
		SET @CNT = @CNT + 1
	END
	SET @ID = 'CST' + @ID
	RETURN @ID
END

