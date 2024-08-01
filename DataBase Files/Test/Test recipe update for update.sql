
declare 
@Recipeid int,
@UsersID int ,
@CuisineTypeID int ,
@RecipeName varchar (30),
@Calories int ,
@DateDraft datetime ,
@DatePublished datetime ,
@DateArchived datetime 

select top 1
		@Recipeid = r.RecipeID,
		@UsersID = r.UsersID, 
		@CuisineTypeID = r.CuisineTypeID, 
		@RecipeName = r.RecipeName, 
		@Calories = r.Calories, 
		@DateDraft = r.DateDraft, 
		@DatePublished = r.DatePublished, 
		@DateArchived = r.DateArchived
from Recipe r

select @RecipeName = REVERSE(@RecipeName)

exec RecipeUpdate
	@RecipeID = @Recipeid output,
	@UsersID = @usersid,
	@CuisineTypeID = @cuisineTypeid,
	@RecipeName = @RecipeName,
	@Calories = @Calories,
	@DateDraft = @DateDraft,
	@DatePublished = @DatePublished,
	@DateArchived = @DateArchived

	select @RecipeID

	select * from Recipe where Recipeid = @Recipeid

	--delete Recipe where RecipeID = @Recipeid
