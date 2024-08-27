create or alter proc dbo.IngredientGet(
@All bit = 0)
as
begin
select i.IngredientName , i.IngredientID
from ingredient i
end
go