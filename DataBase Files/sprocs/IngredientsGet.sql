create or alter proc dbo.IngredientGet(
@Recipeid int )
as
begin

	select  i.ingredientname, m.MeasurmentType, ri.IngredientAmount, ri.IngredientSequence
	from ingredient i 
	join recipeIngredient ri
	on i.Ingredientid = ri.ingredientid
	join MeasurmentType m 
	on ri.MeasurmentTypeID = m.MeasurmentTypeID
	where ri.recipeid = @recipeid
	order by ri.IngredientSequence

end
go

--declare @recipeid int 
--select top 1 @recipeid = r.recipeid from recipe r
--exec IngredientGet @recipeid = @recipeid
