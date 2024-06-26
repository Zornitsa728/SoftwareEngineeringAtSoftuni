USE [SoftUni]

GO

-- 01.
SELECT FirstName, 
       LastName
  FROM Employees
 WHERE FirstName LIKE 'Sa%'

 --02.
 SELECT FirstName, 
       LastName
  FROM Employees
 WHERE LastName LIKE '%ei%'

 --03.
 SELECT FirstName
  FROM Employees
  WHERE DepartmentID IN (3, 10)
  AND (Year(HireDate) >= 1995 AND Year(HireDate) <= 2005)

  --04. 
  SELECT FirstName, 
       LastName
  FROM Employees
 WHERE JobTitle NOT LIKE '%engineer%'

 --05.
 SELECT [Name]
   FROM Towns
  WHERE LEN([Name]) IN (5, 6) 
  ORDER BY Name

  --06.
  SELECT TownID,
         [Name]
   FROM Towns
  WHERE [Name] LIKE 'M%'
  OR [Name] LIKE 'K%'
  OR [Name] LIKE 'B%'
  OR [Name] LIKE 'E%'
  ORDER BY Name

  --07.
  SELECT TownID,
         [Name]
   FROM Towns
  WHERE [Name] NOT LIKE 'R%'
  AND [Name] NOT LIKE 'B%'
  AND [Name] NOT LIKE 'D%'
  ORDER BY Name

  --08.
  CREATE VIEW V_EmployeesHiredAfter2000 AS
       SELECT FirstName, 
              LastName
         FROM Employees
	    WHERE YEAR(HireDate) > 2000

 SELECT * FROM V_EmployeesHiredAfter2000\

 --09.
SELECT FirstName,
       LastName
  FROM Employees
 WHERE  LEN(LastName) IN (5)

 --10.
 SELECT 
        EmployeeID,
		FirstName,
		LastName,
		Salary,
DENSE_RANK() OVER ( 
PARTITION BY Salary
ORDER BY EmployeeID) AS Rank 
   FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC

--11.

  SELECT *
    FROM (
         SELECT 
               EmployeeID,
         	   FirstName,
         	   LastName,
         	   Salary,
         DENSE_RANK() OVER ( PARTITION BY Salary ORDER BY EmployeeID) 
		    AS Rank 
               FROM Employees
              WHERE Salary BETWEEN 10000 AND 50000
        )
      AS RankingSubquery
   WHERE Rank = 2
ORDER BY Salary DESC

GO
USE Geography

GO

--12.
SELECT CountryName, IsoCode 
  FROM Countries
 WHERE LOWER(CountryName) LIKE '%a%a%a%'
 ORDER BY IsoCode

 --13.
  SELECT PeakName, RiverName,
         LOWER(CONCAT(LEFT(Peaks.PeakName, LEN(Peaks.PeakName) - 1), Rivers.RiverName)) 
      AS Mix
    FROM Peaks, Rivers
   WHERE RIGHT(PeakName, 1) = LEFT(RiverName,1)
ORDER BY Mix

GO
USE Diablo

GO
--14.
SELECT TOP(50) Name,
  FORMAT(Start, 'yyyy-MM-dd') AS Start
  FROM Games
  WHERE YEAR(Start)>= 2011 AND YEAR(IsFinished) <= 2012
  ORDER BY Start,
  Name

  --15.
  SELECT Username, 
         SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email)) AS [Email Provider]
    FROM Users
ORDER BY [Email Provider],
         Username

--16.
SELECT Username, IpAddress
  FROM Users
 WHERE IpAddress LIKE '___.1%.%.___'
 ORDER BY Username

 --17.
 SELECT [Name], 
        CASE
		    WHEN DATEPART(HOUR, [Start]) BETWEEN 0 AND 11 THEN 'Morning'
			WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
			ELSE 'Evening' 
		END AS [Part of the Day],
        CASE
		    WHEN [Duration] <= 3 THEN 'Extra Short'
			WHEN [Duration] <= 6 THEN 'Short'
			WHEN [Duration] > 6 THEN 'Long'
			ELSE 'Extra Long'
        END AS [Duration]
   FROM [Games] AS [g]
 ORDER BY [g].[Name],
          [Duration],
		  [Part of the Day]

GO
USE Orders
GO

--18.
SELECT [ProductName], [OrderDate],
       DATEADD(DAY, 3, [OrderDate]) AS [Pay Due],
	   DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due]
  FROM [Orders]