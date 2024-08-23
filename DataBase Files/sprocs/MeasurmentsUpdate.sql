create or alter proc dbo.MeasurmentsUpdate(
@MeasurmentTypeID int ,
@MeasurmentType varchar(25))
as
begin
	select @MeasurmentTypeID = isnull(@MeasurmentTypeID , 0)

	if @MeasurmentTypeID = 0
	begin
		insert MeasurmentType (Measurmenttype)
		values(@MeasurmentType)

		select @MeasurmentTypeID = SCOPE_IDENTITY()

	end
	else
	begin
		update MeasurmentType
		set MeasurmentType = @MeasurmentType
		where MeasurmentTypeID = @MeasurmentTypeID
	end
end