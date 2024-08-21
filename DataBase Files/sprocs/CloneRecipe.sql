create or alter proc dbo.CloneRecipe(@RecipeId int)
as
begin
declare @Newrecipeid int
begin try
	begin tran
		insert Recipe (RecipeName, Calories, CuisineTypeID, DateArchived, DateDraft, DatePublished, UsersID)
		select RecipeName = concat(r.RecipeName, ' - clone'), r.Calories, r.CuisineTypeID, r.DateArchived, r.DateDraft, r.DatePublished, r.UsersID
		from Recipe r  
		where r.RecipeId = @RecipeId
		
		set @Newrecipeid = SCOPE_IDENTITY()
		;
		with x as(
			Select r.RecipeID, r.Calories 
			from recipe r 
			where r.RecipeId = @Newrecipeid
		)
		insert RecipeDirection (Direction, RecipeID, StepNumber)
		select rd.Direction, x.RecipeID,  rd.StepNumber
		from RecipeDirection rd
		join recipe r 
		on rd.RecipeID = r.RecipeID
		join x 
		on x.Calories= r.Calories
		where r.RecipeId = @RecipeId
		
		;
		with x as(
			Select r.RecipeID, r.Calories
			from recipe r 
			where r.Recipeid = @Newrecipeid
		)
		insert RecipeIngredient (IngredientAmount, IngredientID, IngredientSequence, MeasurmentTypeID, RecipeID)
		select ri.IngredientAmount, ri.IngredientID, ri.IngredientSequence, ri.MeasurmentTypeID, x.RecipeID
		from RecipeIngredient ri 
		join Recipe r 
		on ri.RecipeID = r.RecipeID
		join x 
		on x.Calories = r.Calories
		where r.Recipeid = @RecipeId
	;
commit
end try
begin catch
	rollback;
	throw
end catch
end
go

--exec CloneRecipe @Recipeid = 255
--select * from recipe r join RecipeDirection rd on r.RecipeID = rd.RecipeID








