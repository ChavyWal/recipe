create or alter proc dbo.IngredientUpdate(
@ingredientid int,
@ingredientname varchar(20))
as
begin
	select @ingredientid = isnull(@ingredientid, 0)

	if @ingredientid = 0
	begin
		insert Ingredient(ingredientname)
		values(@ingredientname)

		select @ingredientid = SCOPE_IDENTITY()
	end
	else
	begin
		update Ingredient
		set IngredientName = @ingredientname
		where IngredientID=@ingredientid
	end
end
go