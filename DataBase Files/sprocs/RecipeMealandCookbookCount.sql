create or alter proc dbo.RecipeMealandCookbookCount(@Message varchar(500) = '' output)
as
begin
	select  ItemName = 'Recipes', Number = Count(r.RecipeName) from Recipe r 
	union select 'Meals', Count(m.MealName) from meal m 
	union SELECT 'CookBooks', Count(CookBookName) From CookBook c 
	order by ItemName desc
end 
go

exec RecipeMealandCookbookCount