 declare @tablename varchar(50) = 'recipe'
 
 select 
 concat('@',c.COLUMN_NAME,' ', c.DATA_TYPE ,' ',
 case when c.CHARACTER_MAXIMUM_LENGTH is null then '' else concat('(', c.CHARACTER_MAXIMUM_LENGTH, ')') end,
 case when c.TABLE_NAME + 'Id' = c.COLUMN_NAME then ' output' else '' end,
 ','
 )
 from INFORMATION_SCHEMA.columns c
 where c.TABLE_NAME = @tablename

  declare @insertList varchar(500) = ''

 select @insertList = @insertList + concat(c.COLUMN_NAME, ', ')
 from INFORMATION_SCHEMA.columns c
 where c.TABLE_NAME = @tablename
 and c.COLUMN_NAME <> c.TABLE_NAME + 'id'

 select @insertList 

 select @insertList  = ''
 select @insertList = @insertList + concat('@',c.COLUMN_NAME, ', ')
 from INFORMATION_SCHEMA.columns c
 where c.TABLE_NAME = @tablename
 and c.COLUMN_NAME <> c.TABLE_NAME + 'id'

 select @insertList 

  select @insertList  = ''
 select  concat(c.Column_name, ' = @',c.COLUMN_NAME, ', ')
 from INFORMATION_SCHEMA.columns c
 where c.TABLE_NAME = @tablename
 and c.COLUMN_NAME <> c.TABLE_NAME + 'id'