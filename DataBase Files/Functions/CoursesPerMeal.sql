create or alter function dbo.CoursesPerMeal(@Mealid int)
returns int
as
begin
	declare @value int = 0
	select @value = Count(mc.CourseID)
	from MealCourse mc
	where mc.mealid = @Mealid

	return @value
end
go

--declare @Mealid int
--select top 1 @Mealid = m.mealid from meal m


--select total = dbo.CoursesPerMeal(@Mealid)


