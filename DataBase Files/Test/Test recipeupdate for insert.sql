declare @usersid int, @cuisineTypeid int, @Recipeid int

select top 1 @usersid = usersid from users u 
select top 1 @cuisineTypeid =  cuisinetypeid from cuisinetype c 

exec RecipeUpdate
	@RecipeID = @Recipeid output,
	@UsersID = @usersid,
	@CuisineTypeID = @cuisineTypeid,
	@RecipeName = 'test',
	@Calories = 157,
	@DateDraft = '2020-09-09',
	@DatePublished = null,
	@DateArchived = null

	select @RecipeID

	select * from Recipe where Recipeid = @Recipeid

	delete Recipe where RecipeID = @Recipeid

	--delete recipe where recipename = 'Test'


	


