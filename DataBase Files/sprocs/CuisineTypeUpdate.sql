create or alter proc dbo.CuisinetypeUpdate(
@CuisineTypeid int,
@CuisineType varchar(25)
)
as
begin
	select @CuisineTypeid = isnull(@CuisineTypeid, 0)

	if @CuisineTypeid = 0
	begin
		insert cuisinetype(cuisinetype)
		values(@CuisineType)

		select @CuisineTypeid = SCOPE_IDENTITY()
	end
	else
	begin
		update cuisinetype
		set 
		cuisinetype = @cuisinetype
		where cuisinetypeid = cuisinetypeid
	end
end
go