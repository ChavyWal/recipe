-- SM Excellent! See comments, no need to resubmit.
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
Delete cr 
from CookBookRecipe CR 
join CookBook C 
on cr.CookBookID = c.CookBookID
join users u 
on c.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete cr 
from CookBookRecipe cr 
join Recipe r 
on cr.RecipeID =  r.RecipeID
join users u 
on r.UsersID = u.UsersID

Delete c 
from CookBook c 
join users u 
on c.UsersID =  u.UsersID
where u.UserName = 'H. Doritos' 

Delete mcr 
from MealCourseRecipe mcr 
join MealCourse mc 
on mcr.MealCourseID = mc.MealCourseID
join meal m 
on mc.MealID = m.MealID
join users u 
on m.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete mcr 
from MealCourseRecipe mcr 
join recipe r 
on mcr.RecipeID = r.RecipeID
join users u 
on u.UsersID = r.UsersID
where u.UserName = 'H. Doritos' 

Delete mc 
from MealCourse mc 
join meal m 
on mc.MealID = m.MealID
join users u 
on m.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete ri 
from RecipeIngredient ri 
join Recipe r 
on ri.RecipeID = r.RecipeID
join users u 
on r.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete rd 
from RecipeDirection rd 
join recipe r 
on rd.RecipeID = r.RecipeID
join users u 
on r.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete m  
from meal m 
join users u 
on m.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete r 
from Recipe r 
join users u 
on r.UsersID = u.UsersID
where u.UserName = 'H. Doritos' 

Delete u 
from users u 
where u.UserName = 'H. Doritos' 


--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.

insert Recipe (RecipeName, Calories, CuisineTypeID, DateArchived, DateDraft, DatePublished, UsersID)
select RecipeName = concat(r.RecipeName, ' - clone'), r.Calories, r.CuisineTypeID, r.DateArchived, r.DateDraft, r.DatePublished, r.UsersID
from Recipe r  
where r.RecipeName = 'Butter Muffins'

with x as(
	Select r.RecipeID, r.Calories 
	from recipe r 
	where r.RecipeName = 'Butter Muffins - clone'
)
insert RecipeDirection (Direction, RecipeID, StepNumber)
select rd.Direction, x.RecipeID,  rd.StepNumber
from RecipeDirection rd
join recipe r 
on rd.RecipeID = r.RecipeID
join x 
on x.Calories= r.Calories
where r.RecipeName = 'Butter Muffins'

;
with x as(
	Select r.RecipeID, r.Calories
	from recipe r 
	where r.RecipeName = 'Butter Muffins - clone'
)
insert RecipeIngredient (IngredientAmount, IngredientID, IngredientSequence, MeasurmentTypeID, RecipeID)
select ri.IngredientAmount, ri.IngredientID, ri.IngredientSequence, ri.MeasurmentTypeID, x.RecipeID
from RecipeIngredient ri 
join Recipe r 
on ri.RecipeID = r.RecipeID
join x 
on x.Calories = r.Calories
where r.RecipeName = 'Butter Muffins'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.
Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
-- SM The price should be the total recipes for that user * 1.33
with x as(
	select NumofRecipes = count(r.RecipeName)
from recipe r
)
insert CookBook (CookBookprice, CookBookName, UsersID, Active, CookBookDate)
select  x.NumofRecipes *  1.33, concat('Recipes by ', u.FirstName, ' ', u.LastName), u.UsersID, 1, '2024-03-13'
from users u 
cross join x 
where u.UserName = 'F. Taylor'
 

insert CookBookRecipe (CookBookID, RecipeID, RecipeSequence)
select c.CookBookID, r.RecipeID, ROW_NUMBER() over (order by r.RecipeName) 
from users u 
join Recipe r 
on u.UsersID = r.UsersID
left join CookBook c 
on u.UsersID = u.UsersID
where u.UserName = 'F. Taylor'
and c.CookBookName like 'Recipes by Fanny Taylor'

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set Calories =
-- select 
r.calories -
	(case  m.MeasurmentType
		when 'cups' then 2  
		when  'Tbsp' then 0.5 
	end) * ri.IngredientAmount
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join ingredient i 
on i.IngredientID = ri.IngredientID
join MeasurmentType m 
on m.MeasurmentTypeID = ri.MeasurmentTypeID
where i.IngredientName = 'Flour'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
-- SM No need for isnull()s you're only selecting the data that should be returned.
with x as(
	select  AverageDaystillPublished = avg(Datediff(hour,r.DateDraft ,r.DatePublished))
	from recipe r 
)
	select u.FirstName, u.LastName,EmailAddress = concat(substring(u.FirstName,1,1),'.',u.LastName, '@heartyhearth.com') ,
		Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', isnull(DATEDIFF(Hour, r.DateDraft, getdate()),0),
		 ' hours. That is ', DATEDIFF(Hour, r.DateDraft, getdate()) - x.AverageDaystillPublished, 
		 ' hours more than the average ', x.AverageDaystillPublished, ' hours all other recipes took to be published.')
	from recipe r 
	cross join x 
	join users u 
	on r.UsersID = u.UsersID
	where r.CurrentStatus = 'Draft'
	and DATEDIFF(Hour, r.DateDraft, getdate()) > x.AverageDaystillPublished

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select 
	EmailBody = 
		concat('Order cookbooks from HeartyHearth.com! We have ',
		count(c.CookBookName),' books for sale, average price is ', convert(Decimal (5,2), AVG((c.CookBookprice))),'. You can order them all and receive a 25% discount, for a total of ', 
		convert(Decimal (5,2),sum(c.CookBookprice) * 75 / 100),'.
Click <a href = "www.heartyhearth.com/order/',newid(),'">here</a> to order.')
from cookBook c 

