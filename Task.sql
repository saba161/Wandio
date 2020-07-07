SELECT * FROM LeftTable
SELECT * FROM RightTable

--CREATE TABLE LeftTable (
--    ID int IDENTITY(1,1) PRIMARY KEY,
--    FirstName nvarchar(MAX) NOT NULL,
--	LastName nvarchar(MAX) NOT NULL,
--);

--CREATE TABLE RightTable (
--    ID int IDENTITY(1,1) PRIMARY KEY,
--	IsActive bit,
--	LeftTableID int FOREIGN KEY REFERENCES LeftTable(ID)
--);


SELECT l.ID, l.FirstName, l.LastName, r.IsActive, r.University FROM LeftTable l
LEFT JOIN RightTable r on (l.ID = r.LeftTableID and r.IsActive = 1)
