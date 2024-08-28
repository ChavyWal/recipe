create or alter proc dbo.IngredientGet(
@All bit = 0,
@includeblank bit = 0)
as
begin
select i.IngredientName , i.IngredientID
from ingredient i
union select ' ', 0
where @includeBlank = 1

end
go