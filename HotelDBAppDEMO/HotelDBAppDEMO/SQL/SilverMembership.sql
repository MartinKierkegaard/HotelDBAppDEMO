
SELECT b.Guest_No, COUNT(*) sum
	FROM Booking b
	Group BY b.Guest_No
	HAVING COUNT(*) = 3 OR COUNT(*) = 4

--Update to Bronze membership
UPDATE Guest 
SET GuestRating = 2
where exists
(
SELECT b.Guest_No, COUNT(*) sum
	FROM Booking b
	where b.Guest_No = Guest.Guest_No
	Group BY b.Guest_No
	--HAVING COUNT(*)>=5 --
	HAVING COUNT(*) = 3 OR COUNT(*) = 4
)
