create table accountnumber (
	account_number int primary key,
	balance int 
)



insert into accountnumber (account_number, balance)
	values (1,100);

insert into accountnumber (account_number, balance)
	values (2,150);

create table accountpayment (
	ID int primary key,
	account_number int,
	payment int,
	FOREIGN key (account_number) REFERENCES accountnumber(account_number)
)



insert into accountpayment (ID,account_number,payment)
	values (1,1,50)

insert into accountpayment (ID,account_number,payment)
	values (2,2,25)

insert into accountpayment (ID,account_number,payment)
	values (3,2,125)

select * from accountnumber

select * from accountpayment