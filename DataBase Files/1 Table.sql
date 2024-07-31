-- SM Excellent work! See comments for minor improvements, no need to resubmit.
use HeartyHearthDB
go 

Drop Table if exists CookBookRecipe
Drop Table if exists CookBook
Drop Table if exists MealCourseRecipe
Drop Table if EXISTS MealCourse
Drop Table If exists Meal
Drop Table If exists Course
Drop Table if exists RecipeIngredient
Drop Table if exists RecipeDirection
Drop Table if exists Recipe
Drop table if exists Ingredient
Drop table if exists MeasurmentType 
Drop Table if exists CuisineType				
Drop Table iF exists users

Create Table dbo.CuisineType(
    CuisineTypeID int not null identity primary KEY,
    CuisineType varchar (25) not null constraint ck_Cuisine_Type_Cannot_be_blank check(CuisineType <> '')
        constraint u_Cuisine_Type unique
)
go

create table dbo.Users(
	UsersID int not null identity primary key,
	FirstName varchar (20) not null constraint ck_Users_First_Name_cannot_be_blank check(FirstName <> ''),
	LastName varchar (25) not null constraint ck_Users_Last_Name_cannot_be_blank check(LastName <> ''),
	UserName varchar (25) not null constraint ck_Users_User_Name_cannot_be_blank check(userName <> '')
		constraint u_users_user_name unique
)
go

Create table dbo.Recipe(
	RecipeID int not null identity primary key,
	UsersID int not null constraint f_Recipe_User Foreign Key References users(UsersID),
	CuisineTypeID int not null Constraint f_Recipe_CuisineType foreign key references CuisineType(CuisineTypeID),
	RecipeName Varchar (30) not null constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
		Constraint u_Recipe_RecipeName unique,
	Calories Int not null constraint ck_Calories_cannot_be_zero_or_negative check(calories > 0 ),
	DateDraft DateTime not null Default getdate()
        constraint ck_Recipe_Date_Draft_cannot_be_future_Date check(DateDraft <= getdate()),
	DatePublished DateTime null constraint ck_Recipe_Date_Published_cannot_be_future_Date check(DatePublished < = getdate()),
	DateArchived DateTime null constraint ck_Recipe_Date_Archived_cannot_be_future_Date check(DateArchived < = getdate()),
	CurrentStatus as 
		case 
			when datedraft <= DatePublished and DateArchived is null then 'Published'
			when (DateDraft <= datePublished and datepublished <= datearchived) or (datedraft <= datearchived and datepublished is null) then 'Archived'
			else 'Draft'
		END persisted,
	RecipePicture As CONCAT('Recipe','_',replace(RecipeName,' ','_'),'.JPG') persisted,
	constraint ck_Recipe_Datedraft_is_less_then_Date_published_and_datearchived check(datedraft <= Datepublished and datedraft <= DateArchived),
	constraint ck_Datepublished_should_be_less_then_Datearchived check(Datepublished < = Datearchived)
)
go 

create table dbo.RecipeDirection(
	RecipeDirectionID int not null identity primary key,
	RecipeID int not null constraint f_RecipeDirecition_Recipe Foreign key references Recipe(RecipeID),
	StepNumber int not null constraint ck_StepNumber_cannot_be_zero check(StepNumber > 0),
	Direction VARCHAR (150) not null constraint ck_Direction_cannot_be_blank check(Direction <> ''),
	Constraint u_RecipeId_StepNumber unique(RecipeID, StepNumber)
)
go 

Create table Dbo.Ingredient(
	IngredientID int not null identity primary key,
	IngredientName varchar (20) not null constraint ck_INgredient_name_cannot_be_blank check(IngredientName <> '') 
        constraint u_Ingredient_name unique,
	IngredientPicture as CONCAT('Ingredient','_',replace(INgredientName,' ','_'),'.JPG') persisted
)
go

create table dbo.MeasurmentType(
    MeasurmentTypeID int not null identity primary key,
    MeasurmentType varchar (25) not null constraint ck_Measurment_Type_Cannot_be_blank check(MeasurmentType <> '')
        constraint u_Measurment_Type unique
)
GO

create table dbo.RecipeIngredient(
	RecipeIngredientID int not null identity primary Key,
	RecipeID int not null constraint f_RecipeIngredient_Recipe Foreign key references Recipe(RecipeID),
	IngredientID int not null constraint f_RecipeIngredient_Ingredient Foreign key References Ingredient(IngredientID),
	MeasurmentTypeID int null constraint f_recipeIngredient_MeassurmentType foreign key references MeasurmentType(MeasurmentTypeID),
	IngredientAmount Decimal (4,2) not null constraint ck_IngredientAmount_cannot_be_zero_or_negative check(IngredientAmount > 0),
	IngredientSequence int not null constraint ck_Ingredient_sequence_cannot_be_zero check(IngredientSequence > 0),
	constraint u_RecipeIngredient_Recipe_Ingredient unique(RecipeID,IngredientID),
	constraint u_RecipeIngredient_Recipe_IngredientSequence unique(RecipeID, IngredientSequence)
)
go

Create table dbo.Course(
	CourseID int not null identity primary key,
	CourseType varchar (25) not null constraint ck_Course_Type_Cannot_be_blank  check(CourseType <> '')
		constraint u_Course_Type unique,
	CourseSequence Int not null constraint u_Coursesequence_cannot_duplicate unique
		constraint ck_Course_Sequence_Cannot_be_zero check(Coursesequence > 0)
)
go

Create table Dbo.Meal(
	MealID int not null identity primary key,
	UsersID int not null constraint f_Meal_users foreign key REFERENCES Users(UsersID),
	MealName Varchar (30) not null constraint ck_Meal_MealName_Cannot_be_blank check(MealName <> '')
		constraint u_Meal_mealname UNIQUE,
	Active bit not null Default 1,
	MealDate Date not null default getdate() 
		constraint ck_MealDate_cannot_be_a_future_Date check(MealDate <= getdate()),
	MealPicture As CONCAT('Meal','_',replace(MealName,' ','_'),'.JPG') persisted
)
go 

Create Table Dbo.MealCourse(
	MealCourseID int not null Identity PRIMARY key,
	MealID int not null constraint f_MealCourse_Meal Foreign key REFERENCES Meal(MealID),
	CourseID int not null constraint f_MealCourse_course Foreign key REFERENCES Course(courseID),
	constraint u_Meal_Coursetpe unique(Mealid, Courseid)
)
go 

create Table dbo.MealCourseRecipe(
	MealCourseRecipeID int not null IDENTITY primary key,
	MealCourseID int not null constraint f_MealCourseRecipe_MealCourse foreign key REFERENCES MealCourse(MealCourseID),
	RecipeID int not null constraint f_MealCourseRecipe_Recipe foreign key REFERENCES Recipe(RecipeID),
	Main bit not null,
	constraint u_MealCourseID_Recipe unique(MealCourseID, RecipeID)
)
go 

Create table dbo.CookBook(
	CookBookID int not null identity primary key,
	UsersID int not null Constraint f_CookBook_Users foreign key REFERENCES users(UsersID),
	CookBookName Varchar (30) not null constraint ck_CookBookName_Cannot_be_blank check(CookBookName <> '')
		constraint u_CookBookName_Must_Be_unique UNIQUE,
	CookBookprice Decimal (6,2) not null constraint ck_CookBookPrice_Cannot_be_negative check(CookBookPrice > 0),
	CookBookDate Date not null default Getdate() 
		constraint ck_CookBook_Date_cannot_be_future_Date check(CookBookDate <= getdate()),
	Active BIt not null default 1,
	CookBookPicture As CONCAT('CookkBook','_',replace(CookBookName,' ','_'),'.JPG') persisted
)
go

Create table dbo.CookBookRecipe(
	CookBookRecipeID int not null identity primary key,
	CookBookID int not null constraint f_CookBookRecipe_CookBook FOREIGN key REFERENCES CookBook(CookBookID),
	RecipeID int not null constraint f_CookBookRecipe_recipe Foreign key REFERENCES recipe(recipeID),
	RecipeSequence int not null constraint ck_RecipeSequence_Cannot_be_negative  check(RecipeSequence > 0),
	constraint u_CookBookRecipe_CookBookID_RecipeId unique(CookBookID, RecipeID),
	Constraint u_CookBookRecipe_CookBookId_RecipeSequence unique(CookBookID, RecipeSequence)
)
go 
