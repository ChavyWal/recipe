Create or alter proc CoursesGet
as
begin
	select c.CourseID, c.CourseType, c.CourseSequence
	from Course c
	order by c.CourseSequence
end
go