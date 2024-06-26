USE SoftUni
GO

--01.
SELECT TOP 5
  EmployeeID,
  JobTitle,
  e.AddressID,
  a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
ORDER BY e.AddressID

--02.
SELECT TOP 50
  FirstName,
  LastName,
  t.[Name] AS Town,
  a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY FirstName, LastName

--03.
SELECT
  EmployeeID,
  FirstName,
  LastName,
  d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID

--04.
SELECT TOP 5
  EmployeeID,
  FirstName,
  Salary,
  d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE Salary > 15000
ORDER BY e.DepartmentID

--05.
SELECT TOP 3
  e.EmployeeID,
  e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
WHERE ep.ProjectID IS NULL
ORDER BY e.EmployeeID

--06.
SELECT
  FirstName,
  LastName,
  e.HireDate,
  d.[Name] AS DeptName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '01-01-1999' 
AND d.[Name] = 'Sales' OR d.[Name] = 'Finance'
ORDER BY e.HireDate

--07.
SELECT TOP 5
  e.EmployeeID,
  e.FirstName,
  p.[Name] AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '2002-08-13' AND p.EndDate IS NULL
ORDER BY e.EmployeeID

--08.*
SELECT
  e.EmployeeID,
  e.FirstName,
  ProjectName =
CASE 
WHEN DATEPART(YEAR, StartDate) > 2004 THEN NULL
ELSE [Name]
END
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24


--09.
SELECT 
  e.EmployeeID,
  e.FirstName,
  e.ManagerID,
  mgr.FirstName AS ManagerName
FROM Employees AS e
LEFT JOIN Employees AS mgr ON e.ManagerID = mgr.EmployeeID
WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID

--10.
SELECT TOP 50 
  e.EmployeeID,
  CONCAT_WS(' ',e.FirstName, e.LastName) AS EmployeeName,
  CONCAT_WS(' ', mgr.FirstName, mgr.LastName) AS ManagerName,
  dep.[Name] as DepartmentName
FROM Employees AS e
LEFT JOIN Employees AS mgr ON e.ManagerID = mgr.EmployeeID
LEFT JOIN Departments AS dep ON e.DepartmentID = dep.DepartmentID
ORDER BY EmployeeID

--11.
SELECT TOP 1
   AVG(Salary) AS MinAverageSalary
FROM Employees
GROUP BY(DepartmentID)
ORDER BY MinAverageSalary

GO 

USE Geography
GO

--12.
   SELECT 
     mc.CountryCode,
     m.MountainRange,
     p.PeakName,
     p.Elevation
     FROM MountainsCountries 
       AS mc
   JOIN Mountains 
       AS m 
       ON mc.MountainId = m.Id
   JOIN Peaks 
       AS p 
       ON mc.MountainId = p.MountainId
    WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
 ORDER BY p.Elevation DESC

 --13.
 SELECT 
     mc.CountryCode,
	 COUNT(m.MountainRange)
     FROM MountainsCountries 
       AS mc
   JOIN Mountains 
       AS m 
       ON mc.MountainId = m.Id
   JOIN Countries
       AS c
	   ON mc.CountryCode = c.CountryCode
WHERE c.CountryName IN ('Bulgaria', 'United States', 'Russia')
GROUP BY mc.CountryCode

--14.
SELECT TOP 5
c.CountryName,
r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers
AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers
AS r
ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

--15.
SELECT ContinentCode,
       CurrencyCode,
	   CurrencyUsage
FROM (
SELECT *,
        DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC)
	AS CurrencyRank
  FROM (
         SELECT 
               ContinentCode,
               CurrencyCode,
          COUNT(*) AS CurrencyUsage
           FROM Countries
       GROUP BY ContinentCode, CurrencyCode
         HAVING COUNT(*) > 1
      )
   AS CurrencyUsageSubquery
   ) 
AS CurrencyRankingSubquery
WHERE CurrencyRank = 1

--16.
   SELECT COUNT (c.CountryCode) 
       AS Count
     FROM Countries 
       AS c
LEFT JOIN MountainsCountries AS mc
       ON c.CountryCode = mc.CountryCode
    WHERE mc.CountryCode IS NULL 

--17.
  SELECT TOP 5 
         CountryName,
         MAX (p.Elevation) 
	  AS HighestPeakElevation,
         MAX (r.Length) 
	  AS LongestRiverLength
    FROM Countries 
      AS c
         LEFT JOIN MountainsCountries
      AS mc 
      ON c.CountryCode = mc.CountryCode
         LEFT JOIN Mountains
      AS m
      ON mc.MountainId = m.Id
         LEFT JOIN Peaks
      AS p
      ON m.Id = p.MountainId
         LEFT JOIN CountriesRivers
      AS cr
      ON c.CountryCode = cr.CountryCode
         LEFT JOIN Rivers
      AS r
      ON cr.RiverId = r.Id
GROUP BY CountryName
ORDER BY HighestPeakElevation DESC,
         LongestRiverLength DESC,
		 CountryName
         