create or alter proc dbo.CoursesDelete(@Courseid int)
as
begin
		begin try
			begin tran

				delete mcr
				from Course c
				join Mealcourse mc
				on c.CourseID = mc.CourseID
				join MealCourseRecipe mcr 
				on mc.MealCourseID = mcr.MealCourseID
				where c.CourseID = @Courseid

				delete mc
				from Course c
				join Mealcourse mc
				on c.CourseID = mc.CourseID
				where c.CourseID = @Courseid

				delete c
				from Course c
				where c.CourseID = @Courseid

			commit
		end try
		begin catch
		rollback;
		throw
		end catch
end 
go
			--Testing
				/*
				select * from Course c
				join Mealcourse mc
				on c.CourseID = mc.CourseID
				join MealCourseRecipe mcr 
				on mc.MealCourseID = mcr.MealCourseID

				declare @id int
				select top 1 @id = c.CourseID from Course c
				exec CoursesDelete @Courseid = @id

				select * from Course c
				join Mealcourse mc
				on c.CourseID = mc.CourseID
				join MealCourseRecipe mcr 
				on mc.MealCourseID = mcr.MealCourseID
				*/