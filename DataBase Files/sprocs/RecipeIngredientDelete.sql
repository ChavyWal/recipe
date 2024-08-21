create or alter proc dbo.RecipeIngredientDelete(@RecipeIngredientid int)
as
begin
	delete ri
	from RecipeIngredient ri
	where ri.RecipeIngredientID = @RecipeIngredientid
end
go

--select * from recipeingredient

--declare @Recipeingredientid int 
--select top 1 @Recipeingredientid = ri.RecipeIngredientID 
--from  RecipeIngredient ri 

--exec RecipeIngredientDelete @Recipeingredientid = @Recipeingredientid

--select * from recipeingredient