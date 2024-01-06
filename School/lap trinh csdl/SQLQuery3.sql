create table question(
	questionId  INT IDENTITY(1,1) PRIMARY KEY,
	qNo int default 0,
	question varchar(255),
	option1 varchar(100),
	option2 varchar(100),
	option3 varchar(100),
	option4 varchar(100),
	answer varchar(100),
	qset int
)

drop table question

select * from question

insert into question(qNo, question, option1, option2, option3, option4, answer, qset)
                    values ((SELECT count(*) + 1 FROM question WHERE qset = 1),'fasdf','1','2','3','4','a',1)
