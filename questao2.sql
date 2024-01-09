SELECT 
    e.ReportsTo AS Supervisor,
    COUNT(*) AS NumberOfReports,
    ROUND(AVG(e.Age), 0) AS AverageAge
FROM 
    NOMETABELA e
WHERE 
    e.ReportsTo IS NOT NULL
GROUP BY 
    e.ReportsTo
ORDER BY 
    Supervisor;
