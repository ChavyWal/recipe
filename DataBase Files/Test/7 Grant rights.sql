use heartyhearthdb 
go

--select concat('grant execute on ' , r.ROUTINE_NAME,' to approle')
--from INFORMATION_SCHEMA.ROUTINES r
--where r.ROUTINE_NAME not like '%gener%'
--and r.ROUTINE_NAME not like 'colna'

grant execute on CoursesUpdate to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on UsersDelete to approle
grant execute on CourseTypeDelete to approle
grant execute on CuisineTypeDelete to approle
grant execute on MeasurmentTypeDelete to approle
grant execute on CourseDelete to approle
grant execute on CourseUpdate to approle
grant execute on CourseGet to approle
grant execute on MeasurmentTypeGet to approle
grant execute on RecipeIngredientGet to approle
grant execute on MeasurmentTypeUpdate to approle
grant execute on dboRecipeUpdate to approle
grant execute on RecipeUpdate to approle
grant execute on MealDesc to approle
grant execute on RecipeDesc to approle
grant execute on RecipeGet to approle
grant execute on CuisineTypeGet to approle
grant execute on UsersGet to approle
grant execute on RecipeDelete to approle
grant execute on CaloriesPerMeal to approle
grant execute on RecipeMealandCookbookCount to approle
grant execute on CookbookGet to approle
grant execute on MealGet to approle
grant execute on IngredientGet to approle
grant execute on StepsGet to approle
grant execute on CoursesPerMeal to approle
grant execute on RecipesPerMeal to approle
grant execute on IngredientPerRecipe to approle
grant execute on CookbookRecipeGet to approle
grant execute on CoursesGet to approle
grant execute on MeasurmentsGet to approle
grant execute on AutoCreateCookook to approle
grant execute on AutoCreateCookbook to approle
grant execute on CloneRecipe to approle
grant execute on DeleteUsersandRelatedTables to approle
grant execute on DeleteUsersandRecords to approle
grant execute on DeleteCuisineType to approle
grant execute on IngredientDelete to approle
grant execute on MeasurmentsDelete to approle
grant execute on RecipeIngredientDelete to approle
grant execute on CoursesDelete to approle
grant execute on CookbookRecipeDelete to approle
grant execute on RecipeStepsDelete to approle
grant execute on CookbookDelete to approle
grant execute on CookbookUpdate to approle
grant execute on RecipeStepsUpdate to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on IngredientUpdate to approle
grant execute on UsersUpdate to approle
grant execute on CuisinetypeUpdate to approle
grant execute on MeasurmentsUpdate to approle