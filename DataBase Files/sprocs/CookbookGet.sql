create or alter proc dbo.CookbookGet( @Cookbookid int = 0, @All bit = 0, @message varchar(500) = '')
as
begin
	select  c.CookBookID, c.CookBookName, u.usersid, u.UserName, NumRecipes = Count(cr.RecipeID),c.CookBookprice, c.CookBookDate, c.Active
	from CookBook c
	join users u 
	on u.UsersID = c.UsersID
	left join CookBookRecipe cr
	on cr.CookBookID = c.CookBookID
	where c.CookBookID = @Cookbookid
	or @All = 1
	group by c.CookBookID, c.CookBookName, u.usersid, u.UserName, c.CookBookprice, c.CookBookDate, c.Active
end
go

--exec CookbookGet @All = 1
--exec CookBookGet @CookbookId = 105

