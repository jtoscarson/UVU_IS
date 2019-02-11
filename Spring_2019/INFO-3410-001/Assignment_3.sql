-- Step 1
select Concat(p.Modelnum, ' ', p.Manufacturer) As Plane,
	count(f.flightID) AS 'Total Flights By Plane'
from planes p
join flights f on p.PlaneID=f.PlaneId
group by Concat(p.Modelnum, ' ', p.Manufacturer)

-- Step 2
--The purpose of the script is to update all of the planes' numseat, by defining all of the models and then listing what the seat numbers should be. And using a CASE to test all of the models.
update planes
set NumSeats = CASE 
		WHEN ModelNum = '787 Dreamliner' THEN '505'
		WHEN ModelNum = '737-900' THEN '261'
		WHEN ModelNum = 'RJ-45' THEN '51'
		WHEN ModelNum = '747-400' THEN '317'
		WHEN ModelNum = 'A300' THEN '194'
		WHEN ModelNum = 'A330' THEN '258'
		WHEN ModelNum = '727-200' THEN '137'
	END
WHERE ModelNum IN ('787 Dreamliner', '737-900', 'RJ-45', '747-400', 'A300', 'A330', '727-200')

--Step 3
select CONCAT(a.AirportLocation, ' ', '(', f.AirportCodeofarrival, ')') as 'Airport Location', count(f.AirportCodeofarrival) as 'Total Flights'
from Flights f
join Airports a on f.AirportCodeOfArrival=a.AirportCode
group by a.AirportLocation, f.AirportCodeofarrival
having count(f.AirportCodeofarrival) > 30
order by 2 desc

--step 4
select f.FlightID, f.AirportCodeOfDeparture, f.AirportCodeOfArrival, f.DepartureDateTime, f.ArrivalDateTime, 
	floor(p.NumSeats * .6) as '60% Full', floor(p.NumSeats * .75) as '75% Full', floor(p.NumSeats * .95) as '95% Full'
from flights f
join planes p on f.PlaneID=p.PlaneID

--step 5
select f.AirportCodeOfDeparture, f.AirportCodeOfArrival, f.DepartureDateTime, f.ArrivalDateTime, a.AirlineName, 
	CONCAT(p.Manufacturer, ' ', p.ModelNum) as 'Make and Model of Plane'
from flights f
join Airlines a on f.AirlineID=a.AirlineID
join Planes p on f.PlaneID=p.PlaneID
where (f.DepartureDateTime >= '20180301' AND f.DepartureDateTime <= '20180331') OR 
	(f.ArrivalDateTime >= '20180301' AND f.ArrivalDateTime <= '20180331') OR 
	(f.DepartureDateTime >= '20190301' AND f.DepartureDateTime <= '20190331') OR 
	(f.ArrivalDateTime >= '20190301' AND f.ArrivalDateTime <= '20190331')
ORDER by f.DepartureDateTime DESC
