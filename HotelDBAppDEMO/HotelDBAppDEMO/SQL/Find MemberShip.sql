	SELECT *
	FROM GUEST g
	WHERE exists
	(SELECT b.Guest_No, COUNT(*) sum
	FROM Booking b
	where b.Guest_No = g.Guest_No
	Group BY b.Guest_No
	HAVING COUNT(*)>=5 --COUNT(*) = 3 OR COUNT(*) = 4


	--order by sum
	)