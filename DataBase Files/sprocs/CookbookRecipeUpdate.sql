create or alter proc dbo.CookbookRecipeUpdate(
@Cookbookrecipeid int,
@CookBookID int,
@RecipeID int ,
@RecipeSequence int )
as
begin
	select @Cookbookrecipeid = isnull(@CookbookRecipeid, 0)

	if @Cookbookrecipeid = 0
	begin
		insert CookBookRecipe( CookBookID, recipeid, Recipesequence)
		values(@CookBookID, @recipeid, @recipesequence)

		select @Cookbookrecipeid = SCOPE_IDENTITY()
	end
	else
	begin
		update CookBookRecipe
		set
		recipeid = @recipeid,
		cookbookid = @CookBookID,
		recipesequence =@RecipeSequence
		where  CookbookRecipeid = @Cookbookrecipeid

	end





end