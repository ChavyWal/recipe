create or alter proc dbo.MealGet(@message varchar(500) = '', @All bit =1, @IncludeBlank bit = 1)
as
begin
	select  m.MealName,  u.UserName, m.MealDesc,
	TotalCalories = dbo.CaloriesPerMeal(m.Mealid),
	NumCourses = dbo.CoursesPerMeal(m.mealid), 
	NumRecipes = dbo.RecipesPerMeal(m.mealid)
	from Meal m
	join Users u 
	on m.UsersID = u.UsersID
	
end 
go

--exec MealGet