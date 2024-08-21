create or alter proc dbo.IngredientDelete(@Ingredientid int)
as
begin
	begin try
		begin tran

			delete ri
			from ingredient i 
			join RecipeIngredient ri
			on ri.IngredientID = i.IngredientID
			where i.IngredientID = @Ingredientid

			delete i
			from Ingredient i
			where i.IngredientID = @Ingredientid

		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go

--select * from Ingredient
--select * from recipeingredient

--declare @ingredientid int 
--select top 1 @ingredientid = i.IngredientID from Ingredient i
--exec IngredientDelete @ingredientid = @ingredientid

--select * from Ingredient
--select * from recipeingredient