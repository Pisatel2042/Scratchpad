create datebase Dummy
CREATE TABLE TimeEvent (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Date datetime ,
    Name NVARCHAR(50),
	Number int
);