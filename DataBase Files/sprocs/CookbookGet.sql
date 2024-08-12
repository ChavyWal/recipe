create or alter proc dbo.CookbookGet( @Cookbookid int = 0, @All bit = 0, @message varchar(500) = '')
as
begin
	select c.CookBookID, c.CookBookName, c.CookBookprice, c.CookBookDate, c.Active, u.UserName
	from CookBook c
	join users u 
	on u.UsersID = c.UsersID
	where c.CookBookID = @Cookbookid
	or @All = 1
end
go

--exec CookbookGet