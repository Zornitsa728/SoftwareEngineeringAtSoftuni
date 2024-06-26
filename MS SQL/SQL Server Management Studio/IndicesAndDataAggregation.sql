USE Gringotts
GO

--01.
SELECT COUNT(*) 
  FROM WizzardDeposits

--02.
SELECT MAX(MagicWandSize) 
    AS LongestMagicWand
  FROM WizzardDeposits

--03.
  SELECT DepositGroup, 
         MAX(MagicWandSize)
	  AS LongestMagicWand
    FROM WizzardDeposits
GROUP BY DepositGroup

--04.
  SELECT TOP 2 DepositGroup
    FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

--05.
SELECT DepositGroup,
       SUM(DepositAmount)
	AS TotalSum
  FROM WizzardDeposits
GROUP BY DepositGroup

--06.
SELECT DepositGroup,
       SUM(DepositAmount)
	AS TotalSum
  FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--07.
  SELECT DepositGroup,
         SUM(DepositAmount)
	  AS TotalSum
    FROM WizzardDeposits
   WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
  HAVING SUM(DepositAmount) < 150000
ORDER BY TotalSum DESC

--08.
  SELECT DepositGroup,
         MagicWandCreator,
		 MIN(DepositCharge)
	  AS MinDepositCharge
    FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator,
         DepositGroup

--09.
  SELECT AgeGroup, 
         COUNT(*) AS WizardCount
    FROM 
        (
         SELECT
               CASE
                   WHEN Age >= 0 AND Age <=10 THEN '[0-10]'
                   WHEN Age >= 11 AND Age <=20 THEN '[11-20]'
                   WHEN Age >= 21 AND Age <=30 THEN '[21-30]'
                   WHEN Age >= 31 AND Age <=40 THEN '[31-40]'
                   WHEN Age >= 41 AND Age <=50 THEN '[41-50]'
                   WHEN Age >= 51 AND Age <=60 THEN '[51-60]'
                   WHEN Age >= 60 THEN '[61+]'
				   -- ELSE '[61+]'
                END 
  	  AS AgeGroup
    FROM WizzardDeposits
        )
      AS [AgeGroupSubquery]
GROUP BY AgeGroup

--10.
SELECT FirstLetter
  FROM 
       (
	    SELECT LEFT(FirstName, 1)
		    AS FirstLetter
          FROM WizzardDeposits
         WHERE DepositGroup = 'Troll Chest'
	   ) 
    AS [FirstLetterSubquery]
	GROUP BY FirstLetter
    ORDER BY FirstLetter

--11.

SELECT DepositGroup,
       IsDepositExpired,
       AVG(DepositInterest)
	AS AverageInterest
  FROM WizzardDeposits
 WHERE DepositStartDate > '1985-01-01'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC,
         IsDepositExpired ASC

--12.
    SELECT SUM([Difference])
	    AS [SumDifference]
	  FROM (
	        SELECT [FirstName]
	            AS [Host Wizard],
	               [DepositAmount]
		        AS [Host Wizard Deposit],
	               LEAD([FirstName]) OVER(ORDER BY [Id])
		        AS [Guest Wizard],
		           LEAD([DepositAmount]) OVER(ORDER BY [Id])
		        AS [Guest Wizard Deposit],
		           [DepositAmount] - LEAD([DepositAmount]) OVER(ORDER BY [Id])
		        AS [Difference]
	          FROM WizzardDeposits 
		   )
		AS [CompareDepositsQuery]

GO
USE SoftUni
GO
--13.
  SELECT DepartmentID,
         SUM(Salary)
	  AS TotalSalary
    FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

--14.
    SELECT DepartmentID,
	       MIN(Salary)
		AS MinimunSalary
      FROM Employees
	 WHERE DepartmentID IN (2, 5, 7)
	       AND HireDate > '2000-01-01'
  GROUP BY DepartmentID

--15.
SELECT * INTO RichEmployees
  FROM Employees
 WHERE Salary > 30000

 DELETE
   FROM RichEmployees
  WHERE ManagerID = 42 

  UPDATE RichEmployees
     SET Salary += 5000
   WHERE DepartmentID = 1

   SELECT DepartmentID,
          AVG(Salary)
	   AS AverageSalary
     FROM RichEmployees
 GROUP BY DepartmentID

 --16.
     SELECT DepartmentID,
	        MAX(Salary)
		 AS MaxSalary
	   FROM Employees
   GROUP BY DepartmentID
   HAVING NOT(MAX(Salary) BETWEEN 30000 AND 70000) 

   --17.
   SELECT COUNT(EmployeeID)
       AS Count
     FROM Employees
    WHERE ManagerID IS NULL 

	--18.
	SELECT 
  DISTINCT DepartmentID,
	       Salary
		AS ThirdHighestSalary
	  FROM (
	        SELECT DepartmentID,
	               Salary,
		           DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC)
		        AS SalaryRanking
              FROM Employees
	       ) 
	     AS SalaryRankingSubquery	
	  WHERE SalaryRanking = 3
