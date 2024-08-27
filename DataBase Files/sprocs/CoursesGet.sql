Create or alter proc CourseGet(@All int = 0)
as
begin
	select c.CourseID, c.CourseType, c.CourseSequence
	from Course c
	order by c.CourseSequence
end
go