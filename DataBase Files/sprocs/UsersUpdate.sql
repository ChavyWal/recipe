create or alter proc dbo.UsersUpdate(
@usersid int output,
@Firstname varchar(20),
@LastName varchar(25),
@username varchar(25))
as
begin
declare @return int = 0
	select @Usersid = isnull(@usersid, 0)

	if @usersid = 0
	begin
		insert users(Firstname, LastName,username)
		values(@firstname, @lastName, @username)

		select @usersid = SCOPE_IDENTITY()
	end
	else
	begin
		update users
		set 
		firstname = @firstname,
		lastname = @lastname,
		username = @username
		where usersid = @usersid
	end

	return @return
end
go

