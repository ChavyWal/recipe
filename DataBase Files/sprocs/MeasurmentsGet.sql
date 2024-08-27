Create or alter proc dbo.MeasurmentTypeGet(@All bit = 0)
as
begin
	select m.MeasurmentTypeID, m.MeasurmentType
	from MeasurmentType m
end
go