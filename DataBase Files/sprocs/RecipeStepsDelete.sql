create or alter proc dbo.RecipeStepsDelete(@Recipeid int, @StepNumber int)
as
begin

	delete rd
	from recipedirection rd
	where rd.RecipeID = @Recipeid
	and rd.StepNumber = @StepNumber

end
go


--testing
/*
declare @recipeid int
declare @Stepnumber int
select top 1 @recipeid = rd.RecipeID, @stepnumber = rd.StepNumber from RecipeDirection rd

select *
from recipedirection rd
where rd.RecipeID = @Recipeid


exec RecipeStepsDelete @Recipeid = @Recipeid, @Stepnumber = @StepNumber

select *
from recipedirection rd
where rd.RecipeID = @Recipeid

select *
from recipedirection rd
where rd.RecipeID = @Recipeid
and rd.StepNumber = @StepNumber
*/