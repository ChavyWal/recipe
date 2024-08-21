create or alter proc dbo.DeleteUsersandRecords(@usersid int)
as
begin
	begin try
		begin tran 
			Delete cr 
			from CookBookRecipe CR 
			join CookBook C 
			on cr.CookBookID = c.CookBookID
			join users u 
			on c.UsersID = u.UsersID
			where u.UsersID = @usersid
			
			Delete cr 
			from CookBookRecipe cr 
			join Recipe r 
			on cr.RecipeID =  r.RecipeID
			join users u 
			on r.UsersID = u.UsersID
			where u.UsersID = @usersid
			
			Delete c 
			from CookBook c 
			join users u 
			on c.UsersID =  u.UsersID
			where u.UsersID = @usersid
			
			Delete mcr 
			from MealCourseRecipe mcr 
			join MealCourse mc 
			on mcr.MealCourseID = mc.MealCourseID
			join meal m 
			on mc.MealID = m.MealID
			join users u 
			on m.UsersID = u.UsersID
			where u.UsersID = @usersid
			
			Delete mcr 
			from MealCourseRecipe mcr 
			join recipe r 
			on mcr.RecipeID = r.RecipeID
			join users u 
			on u.UsersID = r.UsersID
			where u.UsersID = @usersid 
			
			Delete mc 
			from MealCourse mc 
			join meal m 
			on mc.MealID = m.MealID
			join users u 
			on m.UsersID = u.UsersID
			where u.UsersID = @usersid
			
			Delete ri 
			from RecipeIngredient ri 
			join Recipe r 
			on ri.RecipeID = r.RecipeID
			join users u 
			on r.UsersID = u.UsersID
			where u.UsersID = @usersid 
			
			Delete rd 
			from RecipeDirection rd 
			join recipe r 
			on rd.RecipeID = r.RecipeID
			join users u 
			on r.UsersID = u.UsersID
			where u.UsersID = @usersid
			
			Delete m  
			from meal m 
			join users u 
			on m.UsersID = u.UsersID
			where u.UsersID = @usersid 
			
			Delete r 
			from Recipe r 
			join users u 
			on r.UsersID = u.UsersID
			where u.UsersID = @usersid
			
			Delete u 
			from users u 
			where u.UsersID = @usersid 
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	
end 
go


--select u.UserName, r.RecipeName, c.CookBookName, m.MealName from users u 
--left  join recipe r 
--on r.UsersID = u.UsersID
--left join CookBook c 
--on c.UsersID = u.UsersID
--left join Meal m 
--on m.UsersID = u.UsersID
--order by u.UserName


--declare @usersid int
--select top 1 @usersid = u.usersid from users u
--exec DeleteUsersandRecords @usersid = @usersid


--select u.UserName, r.RecipeName, c.CookBookName, m.MealName from users u 
--left  join recipe r 
--on r.UsersID = u.UsersID
--left join CookBook c 
--on c.UsersID = u.UsersID
--left join Meal m 
--on m.UsersID = u.UsersID
--order by u.UserName