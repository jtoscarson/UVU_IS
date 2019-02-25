--Step 1 
UPDATE Airlines
SET AirlineName = REPLACE(AirlineName, 'Airlines', '')
WHERE AirlineName LIKE '%Airlines%'

--Step 2
select CONCAT(a.AirlineName,' airlines ', IIF(f.DepartureDateTime <= GETDATE(), 'operated', 'will operate'),
	' flight number ', f.FlightID, ' which ', IIF(f.DepartureDateTime <= GETDATE(), 'departed ', 'departs '),
	ap.AirportLocation, ' (', f.AirportCodeOfDeparture, ') on ', DATENAME(WEEKDAY, f.DepartureDateTime), ', ', 
	DATENAME(MONTH, f.DepartureDateTime), ' ', DATENAME(DAY, f.DepartureDateTime), CASE
		WHEN DATENAME(DAY, f.DepartureDateTime) IN (1, 21, 31) THEN 'st '
		WHEN DATENAME(DAY, f.DepartureDateTime) IN (2, 22) THEN 'nd '
		WHEN DATENAME(DAY, f.DepartureDateTime) IN (3, 23) THEN 'rd '
		WHEN DATENAME(DAY, f.DepartureDateTime) IN (4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 24, 25, 26, 27, 28, 29, 30) THEN 'th '
		END, ' at ', DATEPART(HOUR, f.DepartureDateTime), ':', DATEPART(MINUTE, f.DepartureDateTime), ' and arrived in ',
	dap.AirportLocation, ' (', f.AirportCodeOfArrival, ') on ', DATENAME(WEEKDAY, f.ArrivalDateTime), ', ', 
	DATENAME(MONTH, f.ArrivalDateTime), ' ', DATENAME(DAY, f.ArrivalDateTime), CASE
		WHEN DATENAME(DAY, f.ArrivalDateTime) IN (1, 21, 31) THEN 'st '
		WHEN DATENAME(DAY, f.ArrivalDateTime) IN (2, 22) THEN 'nd '
		WHEN DATENAME(DAY, f.ArrivalDateTime) IN (3, 23) THEN 'rd '
		WHEN DATENAME(DAY, f.ArrivalDateTime) IN (4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 24, 25, 26, 27, 28, 29, 30) THEN 'th '
		END, ' at ', DATEPART(HOUR, f.ArrivalDateTime), ':', DATEPART(MINUTE, f.ArrivalDateTime), '.') as 'The Statement'
from flights f
join Airlines a on a.AirlineID=f.AirlineID
join Airports ap on ap.AirportCode=f.AirportCodeOfDeparture
join Airports dap on dap.AirportCode=f.AirportCodeOfArrival

--step 3
select AirlineName
from Airlines
where AirlineID IN (
	select AirlineID
	from Planes
	where Manufacturer = 'Boeing')