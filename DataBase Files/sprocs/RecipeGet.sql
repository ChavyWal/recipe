create or alter procedure dbo.RecipeGet(@Recipeid int = 0, @All bit = 0, @Recipename varchar(30) = '', @IncludeBlank bit = 0)
as 
begin
	select @Recipename = nullif(@recipename, '')
	select r.RecipeID ,r.RecipeName,ConcatCurrentStatus = concat('Current Status: ',r.CurrentStatus), r.CurrentStatus,u.UsersID, c.CuisineTypeID, u.UserName ,r.Calories, NumIngredients = dbo.IngredientPerRecipe(r.recipeid), c.CuisineType, r.DateDraft, r.DatePublished, r.DateArchived,  r.RecipePicture 
	from recipe r
	join users u 
	on r.UsersID = u.UsersID
	join CuisineType c
	on c.CuisineTypeID = r.CuisineTypeID
	where r.recipeid = @Recipeid
	or @All = 1
	or  r.RecipeName like  '%'+ @Recipename + '%'
	union select  0,'', '','',0, 0, '' ,0,0, '', '', '', '',  '' 
	where @includeBlank = 1
	order by r.currentstatus desc,r.RecipeName,r.recipeid 
end
go


--exec RecipeGet

--exec RecipeGet @Recipename = ''

--exec RecipeGet @Recipename = 'cho'

--exec RecipeGet @All = 1, @IncludeBlank = 1

--declare @Recipeid int
--select top 1 @Recipeid = r.RecipeID from recipe r
--exec RecipeGet @Recipeid = @Recipeid



