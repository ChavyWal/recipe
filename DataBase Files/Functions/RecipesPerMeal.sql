Create or alter function dbo.RecipesPerMeal(@Mealid int)
returns int
as
begin

declare @value int = 0
select @Value =  Count(r.RecipeID)
from Recipe r 
join MealCourseRecipe mcr
on r.RecipeID = mcr.RecipeID
join MealCourse mc
on mcr.MealCourseID = mc.MealCourseID
where mc.MealID = @Mealid

return @value
end
go

