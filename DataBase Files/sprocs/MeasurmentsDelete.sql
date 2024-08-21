create or alter proc dbo.MeasurmentsDelete(@MeasurmentTypeid int)
as
begin
	begin try
		begin tran

			delete ri
			from MeasurmentType m 
			join RecipeIngredient ri
			on ri.MeasurmentTypeID = m.MeasurmentTypeID
			where m.MeasurmentTypeID = @MeasurmentTypeid

			delete m
			from MeasurmentType m 
			where m.MeasurmentTypeID = @MeasurmentTypeid

		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go

--select * from MeasurmentType m

--declare @id int
--select top 1 @id = m.MeasurmentTypeID from MeasurmentType m
--exec MeasurmentsDelete @MeasurmentTypeid = @id

--select * from MeasurmentType m