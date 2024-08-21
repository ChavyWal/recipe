create or alter proc dbo.CookbookDelete(@Cookbookid int)
as
begin
	delete cr 
	from CookBookRecipe cr
	where cr.CookBookID = @Cookbookid

	delete c 
	from CookBook c
	where c.CookBookID = @Cookbookid
end
go

/*
declare @cookbookid int 
select top  1 @cookbookid = c.CookBookID from CookBook c

select * 
	from CookBookRecipe cr
	where cr.CookBookID = @Cookbookid

	select * 
	from CookBook c
	where c.CookBookID = @Cookbookid

exec CookbookDelete @Cookbookid = @cookbookid

select * 
	from CookBookRecipe cr
	where cr.CookBookID = @Cookbookid

	select * 
	from CookBook c
	where c.CookBookID = @Cookbookid
	*/