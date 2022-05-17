Declare @dateofbirth datetime
Declare @currentdatetime datetime
Declare @days varchar(3)
set @dateofbirth='1999-04-24' 
set @currentdatetime =getdate()
select @days = datepart(d,@currentdatetime)-datepart(d,@dateofbirth)
select @days+'days'as Days