Create or alter proc dbo.MeasurmentsGet
as
begin
	select m.MeasurmentTypeID, m.MeasurmentType
	from MeasurmentType m
end
go