create or alter proc dbo.CuisineTypeDelete(@CuisineTypeid int)
as
begin
	begin try
	begin tran

		

		delete cr 
		from recipe r
		join CookBookRecipe cr
		on r.RecipeID = cr.RecipeID
		where r.CuisineTypeID = @CuisineTypeid

		delete mr 
		from recipe r
		join MealCourseRecipe mr
		on r.RecipeID = mr.RecipeID
		where r.CuisineTypeID = @CuisineTypeid
		
		delete mr 
		from recipe r
		join CookBookRecipe mr
		on r.RecipeID = mr.RecipeID
		where r.CuisineTypeID = @CuisineTypeid

		delete rd 
		from recipe r
		join RecipeDirection rd
		on rd.RecipeID = rd.RecipeID
		where r.CuisineTypeID = @CuisineTypeid

		delete rd 
		from recipe r
		join RecipeIngredient rd
		on rd.RecipeID = rd.RecipeID
		where r.CuisineTypeID = @CuisineTypeid

		delete r
		from recipe r
		where r.CuisineTypeID = @CuisineTypeid

		delete c
		from CuisineType c
		where c.CuisineTypeID = @CuisineTypeid
		
	commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go

--select * from recipe r
--select * from CuisineType
--select * from MealCourseRecipe

--declare @Cuisinetypeid int
--select top 1 @Cuisinetypeid = c.cuisinetypeid from CuisineType c
--exec DeleteCuisineType @CuisineTypeid = @CuisineTypeid

--select * from recipe r
--select * from CuisineType
--select * from MealCourseRecipe