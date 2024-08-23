create or alter proc dbo.RecipeStepsDelete(@RecipeDirectionid int)
as
begin

	delete rd
	from recipedirection rd
	where rd.RecipeDirectionID = @RecipeDirectionid

end
go


--testing
/*
declare @recipedirectionid int
select top 1 @recipedirectionid = rd.recipedirectionid from RecipeDirection rd

select *
from recipedirection rd
where rd.recipedirectionid = @recipedirectionid


exec RecipeStepsDelete @RecipeDirectionid = @recipedirectionid

select *
from recipedirection rd
where rd.Recipedirectionid = @RecipeDirectionid

*/