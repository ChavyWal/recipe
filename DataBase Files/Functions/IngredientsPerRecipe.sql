Create or alter function dbo.IngredientPerRecipe(@Recipeid int)
returns int
as
begin
declare @Value int = 0

select @Value = Count(ri.IngredientID)
from RecipeIngredient ri
where ri.RecipeID = @Recipeid

return @Value
end
go


