Create database WCFservice;
go

use WCFservice;
go

create table Users (
    Id int NOT NULL PRIMARY KEY,
    Name  varchar(255) NOT NULL,
    Phone int,
	Email  varchar(255) NOT NULL,
    Age int
);

go


create procedure sp_GetUsers
as
begin
	select
	Id,
	Name,
	Phone,
	Email,
	Age
	from Users
end

go


create procedure sp_AddUsers
	@Name  varchar(255) ,
	@Phone int,
	@Email  varchar(255),
	@Age int
	as
	begin
	insert into Users (Name,Phone,Email,Age) values (@Name,@Phone,@Email,@Age);
	select  Id,Name,Phone,Email,Age 	from Users;
	end 
Go
