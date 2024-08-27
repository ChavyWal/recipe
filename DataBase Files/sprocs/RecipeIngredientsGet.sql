create or alter proc dbo.RecipeIngredientGet(
@Recipeid int = 0, 
@All bit = 0)
as
begin

	select ri.RecipeIngredientID, i.IngredientID, i.ingredientname,m.MeasurmentTypeID, m.MeasurmentType, ri.IngredientAmount, ri.IngredientSequence, ri.RecipeID
	from ingredient i 
	left join recipeIngredient ri
	on i.Ingredientid = ri.ingredientid
	left join MeasurmentType m 
	on ri.MeasurmentTypeID = m.MeasurmentTypeID
	where ri.recipeid = @recipeid
	or @All = 1
	order by ri.IngredientSequence

end
go

--declare @recipeid int 
--select top 1 @recipeid = r.recipeid from recipe r
--exec RecipeIngredientGet @recipeid = @recipeid

--exec IngredientGet @All = 1
