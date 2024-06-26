USE SoftUni
GO

--01.
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
              AS
           BEGIN
                SELECT FirstName,
                       LastName
                  FROM Employees
	              WHERE Salary > 35000
             END

EXEC usp_GetEmployeesSalaryAbove35000

--02.
CREATE PROCEDURE [usp_GetEmployeesSalaryAboveNumber] 
            @minSalary DECIMAL(18, 4)
         AS
	  BEGIN
	        SELECT FirstName,
			       LastName
			  FROM Employees
			 WHERE Salary >= @minSalary
		END

	EXEC usp_GetEmployeesSalaryAboveNumber 48100

GO
--03.
CREATE OR ALTER PROCEDURE [usp_GetTownsStartingWith] 
                 @startsWith VARCHAR(50)
			  AS
		   BEGIN
		         SELECT [Name]
				     AS [Town]
				   FROM Towns
				  WHERE [Name] LIKE CONCAT(@startsWith, '%')
		     END

	EXEC [usp_GetTownsStartingWith] 'B'
GO
--04.
CREATE OR ALTER PROCEDURE [usp_GetEmployeesFromTown] 
                 @townName VARCHAR(50)
			  AS
		   BEGIN
		         SELECT [e].[FirstName],
				        [e].[LastName]
				   FROM Employees
				     AS [e]
				   JOIN Addresses
				     AS [a]
					 ON [e].[AddressID] = a.[AddressID] 
				   JOIN Towns
				     AS [t]
					 ON [a].[TownID] = t.[TownID]
				  WHERE [t].[Name] = @townName
		     END

	--EXEC [usp_GetEmployeesFromTown] 'Sofia'
GO	
--05.
     CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
	 RETURNS VARCHAR(10)
	              AS
	           BEGIN
	                DECLARE @salaryLevel VARCHAR(10)
	               
	               	     IF(@salary < 30000) 
	               		SET @salaryLevel = 'Low'
	               	ELSE IF (@salary <= 50000) 
	               		SET @salaryLevel = 'Average'
	               	ELSE IF (@salary > 50000) 
	               		SET @salaryLevel = 'High'
	               
	                 RETURN @salaryLevel
	             END
	 
	 --SELECT Salary,
	 --       dbo.ufn_GetSalaryLevel(Salary)
		-- AS [Salary Level]
	 --  FROM Employees
GO
--06.
    CREATE PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel VARCHAR(10)
	              AS
			   BEGIN
			         SELECT FirstName,
					        LastName
					   FROM Employees
					  WHERE @salaryLevel = dbo.ufn_GetSalaryLevel(Salary)
			     END

	EXEC dbo.usp_EmployeesBySalaryLevel 'High'
GO
	--07.
	CREATE FUNCTION ufn_IsWordComprised 
	                (@setOfLetters VARCHAR(MAX),@word VARCHAR(MAX))
		   RETURNS BIT
		       AS
	           BEGIN
	                DECLARE @wordIndex INT = 1
					WHILE(@wordIndex <= LEN(@word))
					BEGIN
					     DECLARE @currCharacter CHAR = SUBSTRING(@word, @wordIndex, 1);

					     IF CHARINDEX(@currCharacter, @setOfLetters) = 0
	               		 BEGIN
						      RETURN 0;
						 END

					     SET @wordIndex +=1;

			   END

			   RETURN 1;
	                         
	       END

  --SELECT dbo.ufn_IsWordComprised ('oistmiahf', 'Sofia')
  --SELECT dbo.ufn_IsWordComprised ('pppp', 'Guy')

  GO

  USE Bank

  GO

  CREATE PROCEDURE usp_GetHoldersFullName
AS
  SELECT CONCAT_WS(' ', FirstName, LastName)
      AS [Full Name]
    FROM AccountHolders

  GO

  CREATE OR ALTER PROCEDURE usp_GetHoldersWithBalanceHigherThan (@number DECIMAL(19,4))
  AS
    SELECT ah.FirstName,
	       ah.LastName
	  FROM Accounts
	    AS a
	  JOIN AccountHolders
	    AS ah
	    ON a.AccountHolderId = ah.Id
  GROUP BY ah.FirstName, ah.LastName
    HAVING SUM(a.Balance) > @number
  ORDER BY ah.FirstName,
           ah.LastName