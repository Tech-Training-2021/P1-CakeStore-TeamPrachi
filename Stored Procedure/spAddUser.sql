select * from UserTbl

create procedure addUser
@fullName nvarchar(50),
@dob nvarchar(50),
@contactNo nvarchar(50),
@email nvarchar(50),
@state nvarchar(50),
@city nvarchar(50),
@pincode nvarchar(50),
@fullAddress nvarchar(Max),
@userId nvarchar(50),
@password nvarchar(50)
as
begin
	Insert into UserTbl values(@fullName,@dob,@contactNo,@email,@state,@city,@pincode,@fullAddress,@userId,@password);
end

Delete from UserTbl where userId = 'prachi12';



