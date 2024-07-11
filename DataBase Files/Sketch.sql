-- SM Excellent! Really nice sketch! See comments, fix and resubmit.
/*
>recipe
    -Recipe 
        RecipeID
        UsersID foreign key
        CuisineID foreign key
        RecipeName varchar(30) not null, not blank, unique
        Calories decimal , not null, not zero
-- SM No need for this column.
-- SM All should be datetime. And don't allow null for draft date.
        DateDraft DateTime not null, constraint no future dates
        DatePublished DateTime null, constraint no future dates
        DateArchived DateTime null, constraint no future dates
        CurrentStatus computed column case when then else end
        RecipePicture computed column Recipe_Entity_Name.jpg persisted
       
    -cuisineType 
        cuisineTypeID
        cuisineType varchar (25) not null , not blank, Unique

    -Ingredient 
        IngredientID
        IngredientName varchar (20) not null, not blank, unique
        IngredientPicture computed column Ingredient_Entity_Name.jpg persisted

    -RecipeIngredient
        RecipeIngredientID
        RecipeID foreign key
        IngredientID foreign Key
        MeasurmentTypeID foreign key
        IngredientAmount Decimal ,not null, not zero
        IngredientSequence int not null not negative
-- SM Sequence must also be unique to recipe.
        constraint unique(RecipeID,IngredientID),
        constraint unique(RecipeID,IngredientSequence)
        
        
    -MeasurmentType 
        MeasurmentTypeID
        MeasurmentType varchar (20)not null, not blank, unique


    -RecipeDirections
        RecipeDirectionID
        RecipeID foreign Key
        StepNumber int not null, not zero
        Direction varchar (60) not null, not blank
        constraint unique(RecipeID, Stepnumber)

>Meal
    -Meal
        MealID
-- SM Should be named as PK in main table.
        UsersID
        MealName varchar (30) not null, not blank , unique
        ActiveOrInactive bit not null
-- SM We only need the date.
        MealDate Date default getdate(),not null, no future date
        MealPicture computed column Meal_Entity_Name.jpg persisted

    -CourseType
        CourseTypeID
        coursetype Varchar (25) not null, not blank, unique (appetiser, maincourse, dessert...)
-- SM Should be unique.
        CourseSequence int not null not zero unique

-- SM The meal has courses and each course in the meal has recipes. A recipe can be in same meal as long as it's in different courses and a recipe can be in same course in different meals.
    -RecipeMealCourse
        RecipeMealCourseID
        MealCourseID foreign Key
        RecipeID foreign key
        main Bit not null 
-- SM This won't make sure that a meal only has once each course.
        constraint unique(MealcourseID, recipe)

-- SM Why would you need this table if you have the previous one? Don't remove this table, you need this one.
-- But think how you can change the other one and not repeat the same thing.
    -MealCourse
        MealCourseID
        MealID foreign key
        CourseID foreign key
        constraint unique(meal,course)

>cookbook
    -CookBook
        CookBookId
        UsersID
        CookBookName varchar (25) not null, not blank, unique
        CookBookprice Decimal not null not negative
        CookBookDate Date not null, default getdate(), no future date 
        ActiveOrInactive bit not null 
        CookBookPicture computed column cookook_Entity_Name.jpg persisted
       
    -CookBookRecipe
        CookBookrecipeID 
        CookBookID foreign key
        RecipeID foreign key
        RecipeSequence int not null not negative
        constraint unique(cookbookid,recipeid)
        constraint unique(cookbookid, reciesequence)

-Users
    UsersID
    firstname varchar (20) not null, not blank
    lastname varchar (25) not null, not blank
    username varchar (25) not null, not blank ,unique

*/