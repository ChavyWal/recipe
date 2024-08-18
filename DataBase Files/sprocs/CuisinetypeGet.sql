create or alter procedure dbo.CuisineTypeGet(@CuisineTypeId int = 0, @All bit = 0, @CuisineType varchar(25) = '')
as
begin
	select @CuisineType = nullif( @CuisineType, '')
	select c.CuisineTypeID, c.CuisineType
	from CuisineType c
	where c.CuisineTypeID = @CuisineTypeid
	or @All = 1
	or c.CuisineType like '%' +  @CuisineType + '%'
	union select 0, ''
	order by CuisineTypeID
end
go

/*
exec CuisineTypeGet

exec CuisineTypeGet @CuisineType = ''

exec CuisineTypeGet @CuisineType = 'c'

exec CuisineTypeGet @All = 1

declare @CuisineTypeid int
select top 1 @CuisineTypeid = c.CuisineTypeID from CuisineType c
exec CuisineTypeGet @CuisineTypeid = @CuisineTypeid
*/