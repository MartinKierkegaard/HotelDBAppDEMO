select *
from dbo.Hotel

SELECT *
from dbo.Room
where Hotel_No = 200

SELECT h.Name, r.Room_No, r.Price, r.Types
FROM dbo.Hotel h
Inner join
dbo.Room r
ON h.Hotel_No = r.Hotel_No
WHERE h.Hotel_No = 200


