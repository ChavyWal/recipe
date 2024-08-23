create or alter proc dbo.RecipeStepsUpdate(
@RecipeDirectionid int,
@recipeid int,
@StepNumber int,
@Direction varchar(150)
)
as
begin
	select @RecipeDirectionid = isnull(@RecipeDirectionid, 0)

	if @RecipeDirectionid = 0
	begin
		insert RecipeDirection ( Recipeid, StepNumber,  Direction)
		values(@recipeid, @StepNumber, @Direction)

		select @RecipeDirectionid = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeDirection
		set 
		recipeid= @recipeid,
		Stepnumber = @Stepnumber,
		Direction = @Direction
		where  recipedirectionid = @RecipeDirectionid
	end
end
go