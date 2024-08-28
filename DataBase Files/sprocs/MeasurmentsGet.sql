Create or alter proc dbo.MeasurmentTypeGet(@All bit = 0, @includeBlank bit = 0)
as
begin
	select m.MeasurmentTypeID, m.MeasurmentType
	from MeasurmentType m
	union select 0, ' '
	where @includeBlank = 1
end
go