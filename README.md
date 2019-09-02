# MemoTest
Memo webapp


Codigo SQL para creacion de DB:

CREATE TABLE Notes (
    Id int IDENTITY(1,1) PRIMARY KEY,
	IsMarked bit,
    Name varchar(40),
	CreationDate DATETIME,
	EditionDate DATETIME,
    Data varchar(2000),
);