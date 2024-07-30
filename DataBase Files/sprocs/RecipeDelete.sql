Create or alter procedure dbo.RecipeDelete(@recipeid int)
as
begin
begin try
begin tran
delete recipedirection where recipeid = @recipeid
delete RecipeIngredient where recipeid = @recipeid
delete recipe where recipeid = @recipeid 
commit
end try
begin catch
rollback;
throw
end catch
end
go

--without related records
/*
declare @recipeid int

select top 1  @recipeid = r.recipeid
from recipe r
left join RecipeDirection rd 
on r.RecipeID = rd.recipeid 
left join recipeingredient ri 
on r.recipeid = ri.recipeid 
left join mealcourserecipe mr 
on r.recipeid = mr.recipeid  
left join cookbookRecipe cr 
on r.recipeid = cr.recipeid 
where rd.recipedirectionid is null 
and ri.recipeingredientid is null 
and mr.mealcourserecipeid is null 
and cr.cookbookrecipeid is null

select * from recipe r where r.recipeid = @recipeid

exec RecipeDelete @recipeid = @recipeid

select * from recipe r where r.recipeid = @recipeid
*/

--with related tables
/*
declare @recipeid int

select top 1  @recipeid = r.recipeid
from recipe r
join RecipeDirection rd 
on r.RecipeID = rd.recipeid 
join recipeingredient ri 
on r.recipeid = ri.recipeid 
join mealcourserecipe mr 
on r.recipeid = mr.recipeid  
join cookbookRecipe cr 
on r.recipeid = cr.recipeid 
order by r.RecipeID

select * from recipe r where r.recipeid = @recipeid

exec RecipeDelete @recipeid = @recipeid

select * from recipe r where r.recipeid = @recipeid

*/
