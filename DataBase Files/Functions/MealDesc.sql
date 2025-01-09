create or alter function dbo.CaloriesPerMeal(@Mealid int)
returns int
as
begin
	declare @value int = 0
	select @Value = 
	 sum(r.Calories)
	from MealCourse mc
	join MealCourseRecipe mcr
	on mc.MealCourseID = mcr.MealCourseID
	join recipe r
	on mcr.RecipeID = r.RecipeID
	where mc.MealID = @Mealid
	return @value
end
go

--select MealDesc = dbo.Caloriespermeal(m.mealid), m.MealName from meal m