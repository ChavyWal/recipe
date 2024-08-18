create or alter Procedure dbo.UsersGet(@usersid int = 0, @All bit = 0, @Username varchar(25) = '')
as
begin
	select @username = nullif(@username, '')
	select u.UsersID, u.FirstName, u.LastName, u.UserName
	from users u 
	where u.UsersID = @usersid
	or @All = 1
	or u.UserName like '%' + @Username + '%'
	union select 0, '', '', ''
	order by UsersID
end
go

/*
exec UsersGet

exec UsersGet @Username = ''

exec UsersGet @username = 'c'

exec UsersGet @All = 1

declare @Usersid int
select top 1 @Usersid = u.UsersID from Users u
exec UsersGet @Usersid = @Usersid
*/