create or alter function  dbo.RecipeDesc(@RecipeId int)
returns varchar(250)
as
begin

declare @value varchar (250) = ''

select @Value = concat(
r.recipename, ' ', c.CuisineType, ' has ', count(distinct ri.Ingredientid), ' ingredients and ', count(distinct rd.RecipeDirectionID)
)
from recipe r
join CuisineType c
on r.CuisineTypeID = c.CuisineTypeID
left join RecipeIngredient ri
on r.RecipeID = ri.Recipeid
left join RecipeDirection rd
on r.RecipeID = rd.RecipeID
where r.RecipeID = @RecipeId
group by r.Recipeid,r.RecipeName,ri.RecipeID, c.CuisineType
return @value
end
go

select recipeDesc = dbo.recipedesc(r.recipeid) from recipe r