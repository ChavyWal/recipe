create or alter proc dbo.IngredientGet(
@All bit = 0,
@IngredientName varchar(20) = '',
@includeblank bit = 0)
as
begin
select i.IngredientName , i.IngredientID
from ingredient i
where IngredientName like '%' + @IngredientName + '%'
union select ' ', 0
where @includeBlank = 1

end
go