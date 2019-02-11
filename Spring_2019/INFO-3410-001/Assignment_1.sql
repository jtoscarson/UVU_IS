Create Table AirLines (
  AL_EIN VARCHAR(10) NOT NULL PRIMARY KEY,
  ALName VARCHAR(100),
  ALAddress VARCHAR(100),
  ALState CHAR(2),
  ALZip INT
)

Create Table Airline_PhoneLookup (
  AL_EIN VARCHAR(10) FORGEIGN KEY REFERENCES dbo.Airlines(AL_EIN),
  ALPhoneNumb INT,
  ALPhoneType VARCHAR(15)
)

Create Table Flights (
  FlightID VARCHAR(4) NOT NULL PRIMARY KEY,
  OriginAirPortID VARCHAR(4) FORGEIGN KEY REFERENCES dbo.Airports(AirPortID),
  DestinationAirPortID VARCHAR(4) FORGEIGN KEY REFERENCES dbo.Airports(AirPortID),
  AL_EIN VARCHAR(10) FORGEIGN KEY REFERENCES dbo.Airlines(AL_EIN),
  TailNumb VARCHAR(6) FORGEIGN KEY REFERENCES dbo.AirPlane(TailNumb),
  DepartDate DATETIME,
  ArriveDate DATETIME,
  FlightStatusID INT FORGEIGN KEY REFERENCES dbo.Flight_StatusLookup(FlightStatusID)
)

Create Table Flight_StatusLookup (
  FlightStatusID INT NOT NULL INDENTITY(1,1) PRIMARY KEY,
  FlightStatus VARCHAR(50)
)

Create Table AirPlane (
  TailNumb VARCHAR(6) NOT NULL PRIMARY KEY,
  AL_EIN VARCHAR(10) FORGEIGN KEY REFERENCES dbo.Airlines(AL_EIN)
)

Create Table AirPlane_ModelLookup (
  TailNumb VARCHAR(6) FORGEIGN KEY REFERENCES dbo.AirPlane(TailNumb),
  AirCraftModel VARCHAR(150)
)

Create Table Airports (
  AirPortID VARCHAR(4) NOT NULL PRIMARY KEY,
  APName VARCHAR(50),
  APAddress VARCHAR(100),
  APState CHAR(2),
  APZip INT
)

Create Table Airport_PhoneLookup (
  AirportID VARCHAR(4) FORGEIGN KEY REFERENCES dbo.Airports(AirPortID),
  AP_PhoneNumb INT,
  AP_PhoneType VARCHAR(15)
)

