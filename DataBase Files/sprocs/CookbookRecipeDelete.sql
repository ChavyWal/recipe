create or alter proc dbo.CookbookRecipeDelete(@Cookbookrecipeid int)
As
begin
	delete cr
	from CookBookRecipe cr
	where cr.CookBookrecipeid = @Cookbookrecipeid
	
end
go

--Testing
/*
declare @cookbookrecipeid int
select @cookbookrecipeid = cr.CookBookRecipeID from CookBookRecipe cr

select * from CookBookRecipe cr
	where cr.CookBookRecipeID = @CookbookRecipeid

exec CookbookRecipeDelete @Cookbookrecipeid = @CookbookRecipeid

select * from CookBookRecipe cr
	where cr.CookBookRecipeID = @CookbookRecipeid
	*/