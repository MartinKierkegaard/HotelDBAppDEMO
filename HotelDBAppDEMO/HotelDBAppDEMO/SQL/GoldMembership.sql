USE HotelAppDemo
SELECT b.Guest_No, COUNT(*) sum
	FROM Booking b
	Group BY b.Guest_No
	HAVING COUNT(*)>=5

--Update to Gold membership
UPDATE Guest 
SET GuestRating = 1
where exists
(
SELECT b.Guest_No, COUNT(*) sum
	FROM Booking b
	where b.Guest_No = Guest.Guest_No
	Group BY b.Guest_No
	HAVING COUNT(*)>=5 
)
