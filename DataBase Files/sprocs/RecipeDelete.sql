Create or alter procedure dbo.RecipeDelete(
@recipeid int,
@Message varchar(500) = '' output
)
as
	begin
			declare @return int = 0
			if exists(select * from Recipe r where r.recipeid = @recipeid and (r.CurrentStatus <> 'draft' or DateDiff(DAY, r.DateArchived, CURRENT_TIMESTAMP) <= 30))
			begin
			select @return = 1, @Message = 'Cannot delete recipe where currentstatus does not = draft or if it''s <=  thirty days in archived.'
			goto finished
			end
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
		Finished:
		return @return
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
