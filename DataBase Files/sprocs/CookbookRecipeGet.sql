Create or alter proc dbo.CookbookRecipeGet(@Cookbookid int)
as
begin
	select r.recipeid, r.RecipeName, cr.CookBookID , cr.RecipeSequence, cr.CookBookRecipeID
	from recipe r 
	join CookBookRecipe cr
	on r.RecipeID = cr.RecipeID
	where cr.CookBookID = @Cookbookid
	order by cr.RecipeSequence
end
go

--declare @cookbookid int
--select top 1 @cookbookid = CookBookid from CookBookRecipe
--exec CookbookRecipeGet @Cookbookid = @cookbookid