create or alter proc AutoCreateCookbook(@usersid int, @NewCookbookid int = 0 output)
as
begin
	begin try
	begin tran
			;
			with x as(
				select NumofRecipes = count(r.RecipeName)
			from recipe r
			)
			insert CookBook (CookBookprice, CookBookName, UsersID, Active, CookBookDate)
			select  x.NumofRecipes * 1.33, concat('Recipes by ', u.FirstName, ' ', u.LastName), u.UsersID, 1, getutcdate() at time zone 'UTC' at time zone 'Eastern Standard Time'
			from users u 
			cross join x 
			where u.UsersID = @usersid
			 
			 set @NewCookbookid = SCOPE_IDENTITY()
				
			insert CookBookRecipe (CookBookID, RecipeID, RecipeSequence)
			select c.CookBookID , r.RecipeID, ROW_NUMBER() over (order by cr.recipeSequence)
			from users u 
			join Recipe r 
			on u.UsersID = r.UsersID
			left join CookBook c 
			on u.UsersID = u.UsersID
			left join CookBookRecipe cr
			on c.CookBookID = cr.CookBookID
			where u.UsersID = @usersid
			and c.CookBookID = @NewCookbookid
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
select * from recipe
declare @usersid int 
declare @NewCookbookid int
select top 1 @usersid = r.usersid from Recipe r
exec @NewCookbookid = AutoCreateCookbook @usersid = 224
select @NewCookbookid, c.CookBookID, c.CookBookName, r.RecipeName , cr.RecipeSequence
from CookBook c
left join CookBookRecipe cr
on c.CookBookID = cr.CookBookID
left join Recipe r
on cr.RecipeID = r.RecipeID


delete cr from CookBookRecipe cr join CookBook c on c.CookBookID = cr.CookBookID where c.CookBookName like 'Recipes by%' 
delete c from CookBook  c where c.CookBookName like 'Recipes by%'

select c.CookBookName, r.RecipeName , cr.RecipeSequence
from CookBook c
join CookBookRecipe cr
on c.CookBookID = cr.CookBookID
join Recipe r
on cr.RecipeID = r.RecipeID
*/


