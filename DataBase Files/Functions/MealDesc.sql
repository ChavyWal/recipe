create or alter function dbo.MealDesc(@Mealid int)
returns varchar(250)
as
begin
declare @value varchar(250) = ''

select @Value = concat(
m.MealName, ' ',
 sum(r.Calories))
from Meal M
join MealCourse mc
on m.MealID = mc.MealID
join MealCourseRecipe mcr
on mc.MealCourseID = mcr.MealCourseID
join recipe r
on mcr.RecipeID = r.RecipeID
where m.MealID = @Mealid
group by m.MealName


return @value
end
go

select MealDesc = dbo.MealDesc(m.mealid), m.MealName from meal m