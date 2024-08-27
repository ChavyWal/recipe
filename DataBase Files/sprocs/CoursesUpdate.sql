create or alter proc dbo.CourseUpdate(
@Courseid int,
@Coursetype varchar(25),
@Coursesequence int)
as
begin
	select @Courseid = isnull(@Courseid, 0)

	if @Courseid = 0
	begin
		insert Course(CourseType, CourseSequence)
		values(@Coursetype, @Coursesequence)

		select @Courseid = SCOPE_IDENTITY()
	end
	else
	begin
		update Course
		set
		CourseType = @CourseType,
		CourseSequence = @CourseSequence
		where  Courseid = @Courseid
	end
end