USE HotelDB

CREATE VIEW ViewGuest_Default
AS
SELECT CONCAT(g.guestln, ', ', g.guestfn) AS 'Full Name', g.guestgender AS 'Gender', 
FORMAT(g.guestbdate, 'MMM dd, yyyy') AS 'Birth Date', a.acctname AS 'Account Username'
FROM Guests g
INNER JOIN Accounts a
ON g.acctID = a.id

CREATE VIEW ViewRooms_Default
AS
SELECT r.roomname, r.roomtype, r.roomprice, r.roomoccupants, a.acctname, r.roomdesc
FROM Rooms r
INNER JOIN Accounts a
ON r.bookerAcctID = a.id

CREATE VIEW ViewReservations_Default
AS
SELECT r.roomname, r.roomprice, res.resScheduleCheckin, res.resScheduleCheckout, res.resCheckinDate, res.resCheckoutDate,
res.resAdults, res.resChildren, CONCAT(g.guestln, ', ', g.guestfn) AS 'Occupant Full Name'
FROM Reservations res
INNER JOIN Rooms r
ON res.roomID = r.id
INNER JOIN Guests g
ON res.guestID = g.id

CREATE PROCEDURE SP_Room_Update
@rid int, @rname varchar(255), @rtype varchar(255), @rprice decimal(9, 2), @rdesc varchar(255)
AS
UPDATE Rooms
SET roomname = @rname, roomtype = @rtype, roomprice = @rprice, roomdesc = @rdesc
WHERE id = @rid

CREATE PROCEDURE SP_Room_Update_Occupy
@rid int, @count int, @aid int
AS
UPDATE Rooms
SET roomoccupants = @count, bookerAcctID = @aid
WHERE id = @rid

CREATE PROCEDURE SP_Room_Update_Avail
@rid int
AS
UPDATE Rooms
SET roomoccupants = 0, bookerAcctID = null
WHERE id = @rid

CREATE PROCEDURE SP_Room_Delete
@rid int
AS
DELETE Rooms
WHERE id = @rid

CREATE PROCEDURE SP_Reservation_Update_CheckIn
@rid int, @checkindate datetime
AS
UPDATE Reservations
SET resCheckinDate = @checkindate
WHERE id = @rid

CREATE PROCEDURE SP_Reservation_Update_CheckOut
@rid int, @checkoutdate datetime
AS
UPDATE Reservations
SET resCheckoutDate = @checkoutdate
WHERE id = @rid

CREATE PROCEDURE SP_Guest_Update
@gid int, @fn varchar(255), @ln varchar(255), @gender varchar(255), @bdate datetime
AS
UPDATE Guests
SET guestfn = @fn, guestln = @ln, guestbdate = @bdate, guestgender = @gender
WHERE id = @gid

CREATE PROCEDURE SP_Guest_Delete
@gid int
AS
DELETE Guests
WHERE id = @gid

CREATE PROCEDURE SP_Guest_Update_Booking
@gid int, @fn varchar(255), @ln varchar(255), @gender varchar(255), @bdate datetime, @rid int
AS
UPDATE Guests
SET guestfn = @fn, guestln = @ln, guestbdate = @bdate, guestgender = @gender, guestHasReservation = 1, roomID = @rid
WHERE id = @gid

CREATE PROCEDURE SP_Reservation_Create
@indate datetime, @outdate datetime, @adults int, @children int, @aid int, @rid int, @gid int
AS
INSERT INTO Reservations(resScheduleCheckin, resScheduleCheckout, resAdults, resChildren, acctID, roomID, guestID)
VALUES(@indate, @outdate, @adults, @children, @aid, @rid, @gid)
