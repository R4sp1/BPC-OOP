SELECT COUNT(Id) CountOfSurnames, Surname FROM [Student] 
	GROUP BY Surname
	ORDER BY CountOfSurnames DESC;