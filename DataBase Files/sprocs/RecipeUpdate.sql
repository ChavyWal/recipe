create or alter proc dbo.RecipeUpdate(
@RecipeID int  output,
@UsersID int ,
@CuisineTypeID int ,
@RecipeName varchar (30),
@Calories int ,
@DateDraft datetime ,
@DatePublished datetime ,
@DateArchived datetime 
)
as
begin
select @RecipeID = isnull(@recipeid, 0), @DateDraft = isnull(@DateDraft, CURRENT_TIMESTAMP), @DateArchived = nullif(@DateArchived, '')

if @RecipeID = 0
	begin

	insert Recipe(UsersID, CuisineTypeID, RecipeName, Calories, DateDraft, DatePublished, DateArchived)
	values (@UsersID, @CuisineTypeID, @RecipeName, @Calories, @DateDraft, @DatePublished, @DateArchived)

	select @Recipeid = SCOPE_IDENTITY()
	end
else
	begin
	update recipe
	set
		UsersID = @UsersID, 
		CuisineTypeID = @CuisineTypeID, 
		RecipeName = @RecipeName, 
		Calories = @Calories, 
		DateDraft = @DateDraft, 
		DatePublished = @DatePublished, 
		DateArchived = @DateArchived
	where Recipeid = @RecipeID
	end
end
go
