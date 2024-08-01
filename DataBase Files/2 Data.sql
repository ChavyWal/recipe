    use HeartyHearthDB
    go 

    Delete CookBookRecipe
    Delete CookBook
    Delete MealCourseRecipe
    Delete MealCourse
    Delete Meal 
    DELETE Course
    Delete RecipeIngredient
    DELETE MeasurmentType
    Delete Ingredient
    Delete RecipeDirection
    Delete Recipe
    Delete Users
    Delete CuisineType

    INSERT CuisineType(CuisineType)
            Select 'American'
        union select 'French'
        union select 'English'

    Insert Users(FirstName, LastName, UserName)
            select 'Fanny', 'Taylor', 'F. Taylor'
        union select 'Sherry', 'Finer', 'Sherry F.'
        union select 'Harvy', 'Doritos', 'H. Doritos'
        union select 'Sharon', 'Deck', 'Sharon'

    ;
    with x as (
            select UserName = 'F. Taylor', CuisineType = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 25,DateDraft = '2024/02/02 10:15:26', DatePublished = '2024/02/10 11:15:30', DateArchived = '2024/07-25'
        union SELECT 'Sherry F.', 'French', 'Apple Yogurt Smoothie', 30, '2023/11/04 05:12:45', null, null
        union select 'Sharon', 'English', 'Cheese Bread', 60,'2024/01/29 09:15:15', null, '2024/02/05 13:25:40'
        union select 'H. Doritos', 'American', 'Butter Muffins', 254, '2023/09/13 07:23:23', null, null
        union select 'Sherry F.', 'English', 'Chocolate Smores', 150, '2023/10/25 12:30:55', '2024/01/09 05:43:34', null
        union select 'H. Doritos', 'French', 'Spicy Fries', 240, '2023/12/26 04:22:55', '2024/01/13 05:43:34', '2024/02/05 14:14:14'
        union select 'F. Taylor', 'American', 'Cherry Pops', 130, '2024/02/11 01:23:23', null, null
    )
    Insert Recipe (UsersID, CuisineTypeID, RecipeName, Calories, DateDraft, DatePublished, DateArchived)
        select u.UsersID, c.CuisineTypeID, x.RecipeName, x.Calories, x.DateDraft ,x.DatePublished, x.DateArchived
        from x 
        join Users u 
        on u.UserName = x.UserName
        join CuisineType c 
        on c.CuisineType = x.CuisineType

    ;
    with x as(
            select Recipename = 'Chocolate Chip Cookies', StepNumber = 1, Direction = 'First combine sugar, oil and eggs in a bowl'
        union select 'Chocolate Chip Cookies',  2,  'mix well'
        union select 'Chocolate Chip Cookies',  3,  'add flour, vanilla sugar, baking powder and baking soda'
        union select 'Chocolate Chip Cookies',  4,  'beat for 5 minutes'
        union select 'Chocolate Chip Cookies',  5,  'add chocolate chips'
        union select 'Chocolate Chip Cookies',  6,  'freeze for 1-2 hours'
        union select 'Chocolate Chip Cookies',  7,  'roll into balls and place spread out on a cookie sheet'
        union select 'Chocolate Chip Cookies',  8 , 'bake on 350 for 10 min.'
        union select 'Apple Yogurt Smoothie',  1,  'Peel the apples and dice'
        union select 'Apple Yogurt Smoothie',  2,  'Combine all ingredients in bowl except for apples and ice cubes'
        union select 'Apple Yogurt Smoothie',  3,  'mix until smooth'
        union select 'Apple Yogurt Smoothie',  4,  'add apples and ice cubes'
        union select 'Apple Yogurt Smoothie',  5,  'pour into glasses.'
        union select 'Cheese Bread',  1,  'Slit bread every 3/4 inch'
        union select 'Cheese Bread',  2,  'Combine all ingredients in bowl'
        union select 'Cheese Bread',  3,  'fill slits with cheese mixture'
        union select 'Cheese Bread',  4,  'wrap bread into a foil and bake for 30 minutes.'
        union select 'Butter Muffins',  1,  'Cream butter with sugars'
        union select 'Butter Muffins',  2,  'Add eggs and mix well'
        union select 'Butter Muffins',  3,  'Slowly add rest of ingredients and mix well'
        union select 'Butter Muffins',  4,  'fill muffin pans 3/4 full and bake for 30 minutes.'
        union select 'Chocolate Smores', 1, 'Beat the marshmallows with the sugar'
        union select 'Chocolate Smores', 2, 'cover one cracker with the marshmalow mixture'
        union select 'Chocolate Smores', 3, 'Put the chocolate on top and cover with the second cracker'
        union select 'Chocolate Smores', 4, 'Leave it in the microwave for two minutes.'
        union select 'Spicy Fries', 1, 'Peal the potatoes and cut it in to thin slices'
        union select 'Spicy Fries', 2, 'mix it well with the salt, black pepper and Garlic (crushed)'
        union select 'Spicy Fries', 3, 'put the oven on 350 and leave it till the potatoes are soft.'
        union select 'Cherry Pops', 1, 'put the cherry pie filling into a bowl and mix it well with the sugar and Lemon juice'
        union select 'Cherry Pops', 2, 'pour it into a mold or pan of your choice'
        union select 'Cherry Pops', 3, 'Freeze it for 24 hours.'
    )
    Insert RecipeDirection (RecipeID, StepNumber, Direction)
    select r.RecipeID, x.StepNumber, x.Direction 
    from x 
    join Recipe r 
    on x.Recipename = r.RecipeName

    insert Ingredient (IngredientName)
        select 'Sugar'
    union select 'oil'
    union select 'eggs'
    union select 'Flour'
    union select 'vanilla sugar'
    union select 'baking powder'
    union select 'baking soda'
    union select 'chocolate chips'
    union select 'granny smith apples'
    union select 'vanilla yogurt'
    union select 'orange juice'
    union select 'honey'
    union select 'ice cubes'
    union select 'bread'
    union select 'butter'
    union select 'shredded cheese'
    union select 'garlic (crushed)'
    union select 'black pepper'
    union select 'salt'
    union select 'vanilla pudding'
    union select 'whipped cream cheese'
    union select 'sour cream cheese'
    union select 'Marshmalows'
    union select 'cracker'
    union select 'chocolate'
    union select 'potatoes'
    union select 'cherry pie filling'
    union select 'lemon juice'

Insert MeasurmentType (MeasurmentType)
    select 'Cups'
union select 'tsp'
union select 'tbsp'
union select 'club'
union select 'oz'
union select 'cloves'
union select 'pinch'
union select 'stick'

;
with x as (
    Select Recipe = 'Chocolate Chip Cookies', Ingredient = 'Sugar', MeasurmentType = 'Cups', IngredientAmount = 1, IngredientSequence = 1
union select 'Chocolate Chip Cookies', 'oil', 'Cups', 0.5, 2
union select 'Chocolate Chip Cookies', 'eggs', null, 3, 3
union select 'Chocolate Chip Cookies', 'Flour', 'Cups', 2, 4
union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp ', 1, 5
union select 'Chocolate Chip Cookies', 'baking powder', 'tsp', 2, 6
union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', 0.5, 7
union select 'Chocolate Chip Cookies', 'chocolate chips', 'cups', 3, 8
union SELECT 'Apple Yogurt Smoothie', 'granny smith apples', null, 3, 1
union SELECT 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cups', 2, 2
union SELECT 'Apple Yogurt Smoothie', 'sugar', 'tsp', 2, 3
union SELECT 'Apple Yogurt Smoothie', 'orange juice', 'cups', 0.5, 4
union SELECT 'Apple Yogurt Smoothie', 'honey', 'tbsp', 2, 5
union SELECT 'Apple Yogurt Smoothie', 'ice cubes', null, 6, 6
union select 'Cheese Bread', 'bread', 'club', 1, 1
union select 'Cheese Bread', 'butter', 'oz', 4, 2
union select 'Cheese Bread', 'shredded cheese', 'oz', 8, 3
union select 'Cheese Bread', 'garlic (crushed)', 'cloves', 2, 4
union select 'Cheese Bread', 'black pepper', 'tsp', 0.25, 5
union select 'Cheese Bread', 'salt', 'pinch', 1, 6
union select 'Butter Muffins', 'butter', 'stick', 1, 1 
union select 'Butter Muffins', 'sugar', 'cups', 3, 2
union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 2, 3 
union select 'Butter Muffins', 'eggs', null, 4, 4
union select 'Butter Muffins', 'whipped cream cheese', 'oz', 8, 5 
union select 'Butter Muffins', 'sour cream cheese', 'oz', 8, 6
union select 'Butter Muffins', 'flour', 'cups', 1, 7
union select 'Butter Muffins', 'baking powder', 'tsp', 2, 8
union select 'Chocolate Smores', 'Marshmalows', 'Cups', 3, 1
union select 'Chocolate Smores', 'sugar', 'cups', 0.33, 2
union select 'Chocolate Smores', 'cracker', null, 2, 3
union select 'Chocolate Smores', 'chocolate', 'oz', 3, 4
union select 'Spicy Fries', 'Potatoes', null, 5, 1
union select 'Spicy Fries', 'salt', 'tsp', 1, 2
union select 'Spicy Fries', 'black pepper', 'pinch', 1, 3
union select 'Spicy Fries', 'Garlic (crushed)', 'tbsp', 2, 4   
union select 'Cherry Pops', 'Cherry pie filling', 'oz', 16, 1  
union select 'Cherry Pops', 'Sugar', 'tbsp', 5, 2  
union select 'Cherry Pops', 'Lemon juice', 'cups', 0.5, 3
)
Insert RecipeIngredient (RecipeID, IngredientID, MeasurmentTypeID, IngredientAmount, IngredientSequence)
    select r.RecipeID, i.IngredientID, m.MeasurmentTypeID, x.IngredientAmount, x.IngredientSequence 
    from x 
    join Recipe r 
    on x.Recipe = r.RecipeName
    join Ingredient i 
    on x.Ingredient = i.IngredientName
    left join MeasurmentType m 
    on x.MeasurmentType = m.MeasurmentType

    Insert Course (CourseType, CourseSequence)
        SELECT  'Appetizer', 1
    union select 'Main Course', 2 
    union select 'Dessert', 3 

    ;
    with x as(
        Select UserName = 'F. Taylor', MealName = 'Breakfast bash', Active = 1
        union select 'Sherry F.', 'Dining Dinner', 1
        union select 'H. Doritos', 'The Perfect Lunch', 0
        union select 'H. Doritos', 'Brunch', 1
        )
    Insert Meal (UsersID, MealName, Active)
    select  u.UsersID, x.MealName, x.Active
    from x 
    join Users U 
    on x.UserName = u.UserName

    ;
    With x as(
        Select MealName = 'Breakfast bash', CourseType = 'Appetizer'
        union select 'Breakfast bash', 'Main Course'
        union select 'Dining Dinner', 'Appetizer'
        union select 'Dining Dinner', 'Main Course'
        union select 'Dining Dinner', 'Dessert'
        union select 'The Perfect Lunch', 'Main Course'
        union select 'The Perfect Lunch', 'Dessert'
        union select 'Brunch', 'Main Course'
        union select 'Brunch', 'Appetizer'
    )
    insert MealCourse (MealID, CourseID)
    select m.MealID, c.CourseID
    from x 
    join Meal m 
    on x.MealName = m.MealName
    join Course c 
    on x.CourseType = c.CourseType

    ;
    with x as(    Select MealName = 'Breakfast bash', CourseType = 'Main Course', Recipe = 'Spicy Bread', Main = 1
        union select 'Breakfast bash', 'Main Course', 'Butter Muffins', 0
        --union select 'Breakfast bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
        union select 'Dining Dinner', 'Appetizer', 'Cherry Pops', 1
        union select 'Dining Dinner', 'Main Course', 'spicy Fries', 1
        --union select 'Dining Dinner', 'Dessert', 'Chocolate Smores', 1
        --union select 'The Perfect Lunch', 'Main Course', 'Cheese Bread', 1
        --union select 'The Perfect Lunch', 'Dessert', 'Chocolate Smores', 1
        --union select 'The Perfect Lunch', 'Dessert', 'Apple Yogurt Smoothie', 0
        union select 'Brunch', 'Main Course', 'Butter Muffins', 1 
        --union select 'Brunch', 'Main Course', 'Chocolate Chip Cookies', 0
        union select 'Brunch', 'Appetizer', 'Cherry Pops', 1
    )
    insert MealCourseRecipe (MealCourseID, RecipeID, Main)
    Select mc.MealCourseID, r.RecipeID, x.Main
    from x 
    join Recipe r 
    on x.Recipe = r.RecipeName
    join Meal m 
    on x.MealName = m.MealName
    join Course c 
    on x.CourseType = c.CourseType
    join MealCourse Mc 
    on mc.CourseID = c.CourseID 
    and mc.MealID = m.MealID

    ;
    With x as(
        Select username = 'F. Taylor', CookBookName = 'Treats for two', CookBookPrice = 30, Active = 1
        union select 'H. Doritos', 'Food for You', 39.99, 1
        union select 'Sharon', 'Easy and Pie', 25, 0
        union select 'Sherry F.', 'Fry and Try',34.99, 1
    )
    Insert CookBook(UsersID, CookBookName, CookBookprice, Active)
    select u.UsersID, x.CookBookName, x.CookBookPrice, x.Active
    from x 
    join users u 
    on x.username = u.UserName

    ;
    with x as(
        Select CookBookName = 'Treats for two',RecipeName = 'Spicy Fries',RecipeSequence = 1
        --union select 'Treats for two', 'Apple Yogurt Smoothie', 2
        --union select 'Treats for two', 'Cheese Bread', 3
        union select 'Treats for two', 'Butter Muffins', 4
        union select 'Food for You', 'Cherry pops', 1
        --union select 'Food for You', 'Apple Yogurt Smoothie', 2 
        union select 'Food for You', 'Spicy Fries', 3
        --union select 'Easy and Pie', 'Cheese Bread', 1
        --union select 'Easy and Pie', 'Chocolate Chip Cookies', 2 
        --union select 'Easy and Pie', 'Chocolate Smores', 3 
        union select 'Fry and Try', 'Butter Muffins', 1 
        union select 'Fry and Try', 'Spicy Fries', 2 
        --union select 'Fry and Try', 'Apple Yogurt Smoothie', 3 
    )
    Insert CookBookRecipe (CookBookId, recipeID, RecipeSequence)
    select c.CookBookID, R.RecipeID, x.RecipeSequence 
    from x 
    join cookBook c 
    on x.CookBookName = c.CookBookName
    join Recipe r 
    on x.RecipeName = r.RecipeName 
