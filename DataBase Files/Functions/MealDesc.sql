create or alter function dbo.CaloriesPerMeal(@Mealid int)
returns varchar(250)
as
begin
	declare @value varchar(250) = ''

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

select MealDesc = dbo.Caloriespermeal(m.mealid), m.MealName from meal m