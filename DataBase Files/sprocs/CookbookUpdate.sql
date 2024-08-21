create or alter proc dbo.CookbookUpdate(
@CookbookId int,
@usersid int,
@CookbookName varchar(30),
@CookbookPrice int,
@Active bit = 1
)
as
begin
select @CookbookId = ISNULL(@Cookbookid, 0)

if @CookbookId = 0
	begin
		insert CookBook(CookBookName, CookBookDate, CookBookprice, Active, UsersID)
		values (@CookbookName, convert(varchar(10), getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'), @CookbookPrice,@Active, @usersid)

		select @CookbookId = SCOPE_IDENTITY()
	end
else
	begin
		update CookBook 
		set
		UsersID = @UsersID,
		CookBookName = @CookbookName,
		CookbookPrice =@CookbookPrice,
		ACtive = @Active
		where CookBookID = @CookbookId
	end
end
go