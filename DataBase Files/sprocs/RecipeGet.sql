create or alter procedure dbo.RecipeGet(@Recipeid int = 0, @All bit = 0, @Recipename varchar(30) = '')
as 
begin
	select @Recipename = nullif(@recipename, '')
	select r.RecipeID, r.RecipeName, r.Calories, r.CuisineTypeID, r.UsersID, r.DateDraft, r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture 
	from recipe r
	where r.recipeid = @Recipeid
	or @All = 1
	or  r.RecipeName like  '%'+ @Recipename + '%'
	order by r.RecipeName
end
go

/*
exec RecipeGet

exec RecipeGet @Recipename = ''

exec RecipeGet @Recipename = 'cho'

exec RecipeGet @All = 1

declare @Recipeid int
select top 1 @Recipeid = r.RecipeID from recipe r
exec RecipeGet @Recipeid = @Recipeid
*/


