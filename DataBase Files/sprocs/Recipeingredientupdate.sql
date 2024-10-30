create or alter proc dbo.RecipeIngredientUpdate(
@RecipeIngredientid int,
@recipeid int,
@IngredientId int,
@MeasurmentTypeid int,
@ingredientAmount int,
@ingredientSequence int)

as
begin 
	select @recipeingredientid = isnull(@Recipeingredientid, 0), @MeasurmentTypeid = nullif(@MeasurmentTypeid, 0)

	if @RecipeIngredientid = 0
	begin
		insert RecipeIngredient(RecipeID, IngredientID, MeasurmentTypeID, IngredientAmount, IngredientSequence)
		values (@Recipeid, @ingredientid, @Measurmenttypeid, @ingredientAmount, @ingredientSequence)

		select @RecipeIngredientid = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredient
		set 
		RecipeID = @recipeid,
		Ingredientid = @ingredientid,
		Measurmenttypeid=@MeasurmentTypeid,
		IngredientAmount = @ingredientAmount,
		ingredientsequence = @ingredientSequence
		where RecipeIngredientID  = @RecipeIngredientid
	end
end 
go