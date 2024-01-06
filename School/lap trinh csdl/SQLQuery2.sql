declare @accountnumber int
declare @payment decimal(18,2) 

declare pmt_cursor cursor for
select account_number, payment
from accountpayment

open pmt_cursor 
fetch next from pmt_cursor into @accountnumber, @payment

while @@FETCH_STATUS = 0
begin 
	update accountnumber
	set balance = balance - @payment
	where account_number = @accountnumber

	fetch next from pmt_cursor into @accountnumber, @payment 
end

close pmt_cursor 

DEALLOCATE pmt_cursor 


select * from accountnumber

