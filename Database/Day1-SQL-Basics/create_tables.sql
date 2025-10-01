use master

create database PracticeSQL

use PracticeSQL

CREATE TABLE Residents(
	ResidentId INT PRIMARY KEY IDENTITY(100,1),
	ResidentName VARCHAR(50) NOT NULL,
	FlatNumber VARCHAR(10) NOT NULL,
	PhoneNumber NUMERIC(10),
	JoinDate DATE DEFAULT GETDATE(),
	CHECK (len(PhoneNumber)=10)
);

CREATE TABLE COMPLAINTS(
	COMPLAINTID INT PRIMARY KEY IDENTITY(500,1),
	RESIDENTID INT NOT NULL,
	DESCRIPTION VARCHAR(200) NOT NULL,
	STATUS VARCHAR(20) NOT NULL,
	RAISEDDATE DATE DEFAULT GETDATE(),
	FOREIGN KEY (RESIDENTID) REFERENCES RESIDENTS(RESIDENTID)
);

INSERT INTO Residents (ResidentName, FlatNumber, PhoneNumber, JoinDate)
VALUES
('Amit Sharma', 'A101', '9876543210', '2023-01-15'),
('Priya Mehta', 'B202', '9123456780', '2022-11-20'),
('Rohit Verma', 'C303', '9988776655', '2024-03-10'),
('Sneha Gupta', 'D404', '9090909090', '2024-06-05'),
('Arjun Patel', 'E505', '9001234567', '2023-09-01');


INSERT INTO Complaints (ResidentID, Description, Status, RaisedDate)
VALUES
(100, 'Water leakage in bathroom', 'Pending', '2024-07-10'),
(101, 'Lift not working', 'Resolved', '2024-08-01'),
(102, 'Noise complaint from neighbors', 'Pending', '2024-09-15'),
(103, 'Street light not working', 'Resolved', '2024-07-22'),
(104, 'Garbage not collected regularly', 'Pending', '2024-08-30'),
(100, 'Parking space occupied by outsiders', 'Pending', '2024-09-10'),
(102, 'Security guard behavior complaint', 'Resolved', '2024-09-25');


--1. Write a query to display the Name and PhoneNumber of all residents.
SELECT RESIDENTNAME,PHONENUMBER FROM Residents;

--2. Get the list of complaints that were raised after 1st July 2024 and are still marked as Pending.
SELECT * FROM COMPLAINTS WHERE RAISEDDATE > '2024-07-01' AND STATUS='PENDING';

--3. Show a list of all complaints along with the resident’s Name and FlatNumber who raised them.
SELECT COMPLAINTID,C.RESIDENTID,R.RESIDENTNAME,R.FLATNUMBER,DESCRIPTION,STATUS,RAISEDDATE 
FROM COMPLAINTS C JOIN Residents R
ON C.RESIDENTID = R.ResidentId;

--4.GROUP BY:
--Find how many complaints each resident has raised.
--Display ResidentName and TotalComplaints.

SELECT R.RESIDENTID, R.RESIDENTNAME,COUNT(C.COMPLAINTID) AS TOTAL_COMPLAINTS 
FROM COMPLAINTS C JOIN Residents R
ON C.RESIDENTID = R.ResidentId
GROUP BY R.ResidentId, R.ResidentName; 

--5. ORDER BY:
--List all complaints sorted by RaisedDate from newest to oldest.

SELECT * FROM COMPLAINTS
ORDER BY RAISEDDATE DESC

--6. Display the names of all residents who have raised more than 1 complaints.
SELECT R.RESIDENTNAME,COUNT(C.COMPLAINTID) AS TOTAL_COMPLAINTS
FROM COMPLAINTS C JOIN Residents R
ON C.RESIDENTID = R.ResidentId
GROUP BY R.ResidentName
HAVING COUNT(C.COMPLAINTID)>1;