--Step 1
INSERT INTO Airlines
VALUES ('Frontier Airlines');

--Step 2
UPDATE Airlines
SET AirlineName = 'Southwest Airlines'
WHERE AirlineName='Southwest';

--Step 3
DELETE FROM Flights
where DepartureDateTime > '2019-08-01' AND
	AirportCodeOfDeparture = 'BOI' AND
	AirportCodeOfArrival = 'SLC'

--Step 4
SELECT a.AirlineName, COUNT(f.FlightID) as 'Number of Flights'
FROM Airlines a
FULL OUTER JOIN Flights f ON a.AirlineID=f.AirlineID
GROUP BY a.AirlineName

--Step 5
SELECT a.AirPortLocation, COUNT(f.FlightID) AS 'Number of Arrivals'
FROM Airports a
JOIN Flights f ON f.AirportCodeOfArrival=a.AirportCode
GROUP BY a.AirPortLocation
ORDER BY a.AirPortLocation

--Step 6
SELECT AirlineName, CONCAT(Manufacturer, ' ', ModelNum) as 'Manufacturer and Model'
FROM Airlines a
JOIN Planes p ON p.AirlineID=a.AirlineID
ORDER BY AirlineName

