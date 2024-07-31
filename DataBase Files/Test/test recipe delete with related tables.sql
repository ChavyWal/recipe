declare @recipeid int

select top 1  @recipeid = r.recipeid
from recipe r
join RecipeDirection rd 
on r.RecipeID = rd.recipeid 
join recipeingredient ri 
on r.recipeid = ri.recipeid 
left join mealcourserecipe mr 
on r.recipeid = mr.recipeid  
left join cookbookRecipe cr 
on r.recipeid = cr.recipeid 
where mr.RecipeID is null
and cr.RecipeID is null
and (r.CurrentStatus <> 'draft' or DateDiff(DAY, r.DateArchived, CURRENT_TIMESTAMP) <= 30)
order by r.RecipeID

select 'recipe', r.recipeid, r.recipename from recipe r where r.recipeid = @recipeid
union select 'recipe direction', rd.RecipeDirectionID, rd.Direction from RecipeDirection rd where rd.recipeid = @recipeid
union select 'recipe ingredient',  ri.IngredientID, i.IngredientName from RecipeIngredient ri join ingredient i on i.IngredientID = ri.IngredientID where ri.RecipeID = @recipeid
union select 'mealcourserecipe', mr.MealCourseRecipeID, m.MealName from MealCourseRecipe mr join MealCourse mc on mr.MealCourseID = mc.MealCourseID join meal m on mc.MealID = m.MealID where mr.RecipeID = @recipeid
union select 'cookbookrecipe', cr.CookBookRecipeID, c.CookBookName from CookBookRecipe cr join CookBook c on c.CookBookID = cr.CookBookID where cr.RecipeID = @recipeid

declare @return int , @Message varchar(500)

exec @return = RecipeDelete @recipeid = @recipeid, @Message = @Message output

select @return, @Message

select 'recipe', r.recipeid, r.recipename from recipe r where r.recipeid = @recipeid
union select 'recipe direction', rd.RecipeDirectionID, rd.Direction from RecipeDirection rd where rd.recipeid = @recipeid
union select 'recipe ingredient',  ri.IngredientID, i.IngredientName from RecipeIngredient ri join ingredient i on i.IngredientID = ri.IngredientID where ri.RecipeID = @recipeid
union select 'mealcourserecipe', mr.MealCourseRecipeID, m.MealName from MealCourseRecipe mr join MealCourse mc on mr.MealCourseID = mc.MealCourseID join meal m on mc.MealID = m.MealID where mr.RecipeID = @recipeid
union select 'cookbookrecipe', cr.CookBookRecipeID, c.CookBookName from CookBookRecipe cr join CookBook c on c.CookBookID = cr.CookBookID where cr.RecipeID = @recipeid

