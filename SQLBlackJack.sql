CREATE DATABASE Client
GO
USE Client
GO
CREATE TABLE CLIENT(
	ID INT NOT NULL,
	IP CHAR(15) NOT NULL,
	NUMOFCARD INT,	
	SUMCARD INT,
	CONSTRAINT PK_KH PRIMARY KEY(ID)
)

create table account
(
	accnt varchar(50),
	passwd varchar(50)
)

insert into account values ('acc1', '1')
insert into account values ('acc2', '2')
insert into account values ('acc3', '3')
insert into account values ('acc4', '4')
insert into account values ('acc5', '5')

select * from account

drop table client