create or alter proc dbo.StepsGet(@Recipeid int)
as
begin

Select  rd.RecipeDirectionID, rd.direction, rd.stepnumber 
from RecipeDirection rd
join Recipe r 
on rd.recipeid = r.recipeid
where rd.recipeid = @recipeid
order by rd.StepNumber

end
go

declare @recipeid int 
select top 1 @recipeid = r.recipeid from recipe r
exec StepsGet @recipeid = @recipeid