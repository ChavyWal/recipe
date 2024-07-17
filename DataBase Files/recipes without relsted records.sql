insert recipe(recipename, CuisineTypeID, DateDraft, DatePublished, DateArchived, Calories, UsersID)
select 'Peanut Chews',(select c.CuisineTypeID from CuisineType c where c.CuisineType = 'American') , 
    '2024-07-17', null, null, 150, (select u.UsersID from users u where u.UserName = 'F. Taylor')
union select 'Potato Chips',(select c.CuisineTypeID from CuisineType c where c.CuisineType = 'French') ,
     '2023-07-17', '2023-09-09', null, 120, (select u.UsersID from users u where u.UserName = 'H. Doritos')




