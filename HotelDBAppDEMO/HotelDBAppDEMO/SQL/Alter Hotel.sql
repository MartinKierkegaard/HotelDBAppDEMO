Alter table Hotel
ADD HotelUrl VARCHAR(50);

SELECT *
FROM Hotel
WHERE Name Like '%LegoLand%';


UPDATE HOTEL
SET HotelUrl = 'http://www.hotellegoland.dk/'
Where Name Like '%LegoLand%';

SELECT *
FROM Hotel
WHERE Name Like '%LegoLand%';
