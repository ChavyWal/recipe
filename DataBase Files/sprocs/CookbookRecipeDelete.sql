create or alter proc dbo.CookbookRecipeDelete(@Cookbookid int, @recipeid int)
As
begin
	delete cr
	from CookBookRecipe cr
	where cr.CookBookID = @Cookbookid 
	and cr.RecipeID = @recipeid
	
end
go

--Testing
/*
declare @cookbookid int
declare @recipeid int
select @cookbookid = cr.CookBookID, @recipeid = cr.RecipeID from CookBookRecipe cr

select * from CookBookRecipe cr
	where cr.CookBookID = @Cookbookid 
	and cr.RecipeID = @recipeid

exec CookbookRecipeDelete @Cookbookid  = @cookbookid, @recipeid = @recipeid

select * from CookBookRecipe cr
	where cr.CookBookID = @Cookbookid 
	and cr.RecipeID = @recipeid
	*/