-- SM Excellent work! 100%
use heartyhearthDB
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select  ItemName = 'Recipe', Count = Count(r.RecipeName) from Recipe r 
union select 'Meal', Count(m.MealName) from meal m 
union SELECT 'CookBook', Count(CookBookName) From CookBook c 

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
;
with x as (
    select ingredientamount = Count(ri.IngredientID), recipeid = ri.RecipeID
    from RecipeIngredient ri
    group by RecipeID
)
Select RecipeName = case when r.CurrentStatus = 'Archived' then  concat('<span style="color:gray">',r.recipename, '</span>') else r.RecipeName end,
 r.CurrentStatus, DatePublished = isnull(convert(varchar, r.DatePublished, 101), ''), DateArchived = isnull(convert(varchar, r.DateArchived, 101), ''), u.Username, r.Calories, x.IngredientAmount
from recipe r 
join x 
on r.RecipeID = x.RecipeID
join users u 
on r.UsersID = u.UsersID
where r.CurrentStatus in ( 'Archived', 'Published')
order by r.CurrentStatus Desc

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/

-- a
select r.RecipeName, TotalIngredients = count (Distinct ri.IngredientID), TotalSteps = count(Distinct rd.StepNumber), r.Calories, r.RecipePicture
from recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Recipedirection rd 
on rd.RecipeID = ri.RecipeID
Where r.RecipeName = 'chocolate Chip Cookies'
Group by r.RecipeName, r.Calories, r.RecipePicture

-- b
select ListOfIngredients = concat(RI.IngredientAmount,' ',m.MeasurmentType,' ',i.IngredientName)
from recipe r 
join RecipeIngredient Ri 
on r.RecipeID = ri.RecipeID
join ingredient I 
on ri.IngredientID = i.IngredientID
left join MeasurmentType m 
on ri.MeasurmentTypeID = m.MeasurmentTypeID
Where r.RecipeName = 'chocolate Chip Cookies'
order by ri.IngredientSequence

-- c
select rd.Direction
from recipe r
join RecipeDirection  rd 
on r.RecipeID = rd.RecipeID
Where r.RecipeName = 'chocolate Chip Cookies'
order by rd.StepNumber

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/

select m.MealName, u.UserName, totalcalories = sum(r.Calories), TotalCoursetypes = count(distinct mc.CourseID), TotalRecipes = count( distinct r.RecipeID)
from Meal m
join mealcourse mc
on m.MealID = mc.MealID
join MealCourseRecipe mcr
on mc.MealCourseID = mcr.MealCourseID
join recipe r 
on mcr.RecipeID = r.RecipeID
join users u 
on m.UsersID = u.UsersID
group by m.MealName, u.Username
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/

-- a
select m.MealName, m.MealDate, u.UserName
from meal m
join users u 
on m.UsersID = u.UsersID
where m.MealName = 'Breakfast bash'

;
-- SM Tip: You're missing "Main dish"

-- b
with x as(
    select MealRecipeList = 
    case c.CourseType
    when 'Main Course' then 
    case mcr.main 
    when 0 then concat(c.CourseType,': ','Side dish - ', r.RecipeName)
    when 1 then concat('<b>',c.CourseType,': ', 'dish - ', r.RecipeName, '</b>')
    end
    else concat(c.CourseType, ': ', r.RecipeName)
    end, Mc.mealid
    From MealCourse Mc 
    join MealCourseRecipe mcr 
    on mc.MealCourseID = mcr.MealCourseID
    join Course C 
    on mc.CourseID = c.CourseID
    join Recipe r 
    on mcr.RecipeID = r.RecipeID
)
select  x.MealRecipeList
from meal m 
join x 
on x.MealID = m.MealID
where m.MealName = 'Breakfast bash'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/

select c.CookBookName, u.UserName,TotalRecipes = count(CookBookRecipeID)
from CookBook c 
join CookBookRecipe cr 
on c.CookBookID = cr.CookBookID
join users u 
on c.UsersID = u.UsersID
where c.Active = 1
group by c.CookBookName, u.UserName
order by c.CookBookName

;
/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
-- a
select c.cookbookname, u.UserName, c.CookBookDate, c.CookBookprice, totalRecipes = count(cr.RecipeID)
from cookbook c 
join users u 
on c.UsersID = u.UsersID
join CookBookRecipe cr 
on c.CookBookID = cr.CookBookID
where c.CookBookname = 'Food for you'
group by c.cookbookname, u.UserName, c.CookBookDate, c.CookBookprice

--b
select r.RecipeName, ct.CuisineType, AmountOfIngredient = count(Distinct ri.IngredientID),AmountofSteps = count(Distinct rd.StepNumber) 
from CookBook c
join CookBookRecipe cr 
on c.CookBookID = cr.CookBookID
join Recipe r 
on cr.RecipeID = r.RecipeID
join CuisineType Ct 
on r.CuisineTypeID = ct.CuisineTypeID
join RecipeDirection rd 
on r.RecipeID = rd.RecipeID
join RecipeIngredient ri
on rd.RecipeID = ri.RecipeID
where c.CookBookName = 'Food for You'
Group by r.RecipeName, ct.CuisineType, cr.RecipeSequence
order by cr.RecipeSequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
select distinct RecipeName = concat(upper(Substring (reverse(r.RecipeName), 1, 1)),lower(substring(reverse(r.RecipeName),2,100))),
RecipePicture = concat('Recipe_',Replace(concat(upper(Substring (reverse(r.RecipeName), 1, 1)),lower(substring(reverse(r.RecipeName),2,100))),' ','_'),'.jpg')
from recipe r 
join MealCourseRecipe mcr 
on r.RecipeID = mcr.RecipeID
join RecipeDirection rd 
on r.RecipeID = rd.RecipeID

;
with x as(
select stepnumber = count(rd.StepNumber), rd.Recipeid
from RecipeDirection rd 
Group by rd.RecipeID
)
select SpoofStepList = rd.Direction 
from x 
join recipedirection rd 
on x.RecipeID = rd.RecipeID
where x.stepnumber = rd.StepNumber

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
-- a
Select r.CurrentStatus, u.UserName, RecipesPerStatus =  count(r.RecipeName)
from users u 
left join Recipe r 
on u.UsersID = r.UsersID
Group by r.CurrentStatus, u.Username

-- b
Select u.UserName, RecipesCreated = Count(r.RecipeName),DaysTillPublished = isnull(Avg(DateDiff(DAY, r.DateDraft, r.DatePublished)), 0)
from Recipe r 
left Join users u 
on r.UsersID = u.UsersID 
Group by u.UserName

-- c
Select u.UserName, TotalMeals = count(m.MealName) ,TotalActivemeal =   Sum(case when m.Active = 0 then 0 else 1 end), Totalinactivemeal = Sum(case when m.Active = 0 then 1 else 0 end)
from users u 
left Join Meal m 
on u.UsersID = m.UsersID
Group by u.UserName

-- d
Select u.UserName,TotalCookBooks = Count(c.CookBookName), TotalActiveCookbook =   Sum(case when c.Active = 0 then 0 else 1 end), TotalInactiveCookbook = Sum(case when c.Active = 0 then 1 else 0 end)
from Users u 
left join CookBook c 
on u.UsersID = c.UsersID
Group by u.UserName

-- e
select r.RecipeName, DaysTillArchived = Datediff(Day, r.DateDraft, r.DateArchived)
from Recipe r 
where r.CurrentStatus = 'Archived'
and r.DatePublished is null
/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
-- a
select ItemName = 'Recipes', Total = Count(Distinct r.RecipeName)
    from Users u 
    join Recipe r 
    on u.UsersID = r.UsersID
    where u.UserName = 'F. Taylor'
    Group by u.UserName
union select 'Meals',  count(Distinct m.MealName)
    From Meal m
    join users u 
    on u.UsersID = m.UsersID
    where u.UserName = 'F. Taylor'
    Group by u.UserName
union select 'CookBooks',  count(Distinct C.CookBookName)
    From CookBook c  
    join Users u
    on u.UsersID = c.UsersID
    where u.UserName = 'F. Taylor'
    Group by u.UserName

-- b
Select r.RecipeName, r.CurrentStatus,totalHoursTillCurrentStatus = 
    case 
    when r.DateArchived is not null and r.DatePublished is not null then Datediff(HOUR, r.DatePublished, r.DateArchived) 
    when r.DateArchived is not null and r.DatePublished is null then DATEDIFF(hour, r.DateDraft, r.DateArchived)
    else DATEDIFF(Hour,r.DateDraft, r.DatePublished)
    end 
from users u 
join Recipe r 
on u.UsersID = r.UsersID
where u.UserName = 'Sharon'
and r.CurrentStatus <> 'Draft'


