INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Bettie', 'Skyler', 'Hyatt');
DECLARE @PersonId BIGINT;
SET @PersonId = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('501-899-663', @PersonId);
INSERT INTO Address (AddressOf, PersonId) VALUES ('8294 Norris Pike', @PersonId);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('1975-11-23', @PersonId);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Kol', 'Faston', 'Almaz');
DECLARE @PersonId2 BIGINT;
SET @PersonId2 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('501-334-721', @PersonId2);
INSERT INTO Address (AddressOf, PersonId) VALUES ('11 Norris Lake', @PersonId2);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('2001-11-23', @PersonId2);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Marilyne', 'Reese', 'VonRueden');
DECLARE @PersonId3 BIGINT;
SET @PersonId3 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('800-226-721', @PersonId3);
INSERT INTO Address (AddressOf, PersonId) VALUES ('9596 Chris Spur', @PersonId3);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('2007-01-22', @PersonId3);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Jamir', 'Kendall', 'Nitzsche');
DECLARE @PersonId4 BIGINT;
SET @PersonId4 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('340-766-721', @PersonId4);
INSERT INTO Address (AddressOf, PersonId) VALUES ('4323 Dion Haven', @PersonId4);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('1974-05-10', @PersonId4);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Kenyatta', 'Arden', 'Jaskolski');
DECLARE @PersonId5 BIGINT;
SET @PersonId5 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('621-766-721', @PersonId5);
INSERT INTO Address (AddressOf, PersonId) VALUES ('11 Norris Lake', @PersonId5);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('2006-10-17', @PersonId5);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Luna', 'Drew', 'Yundt');
DECLARE @PersonId6 BIGINT;
SET @PersonId6 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('700-766-721', @PersonId6);
INSERT INTO Address (AddressOf, PersonId) VALUES ('39864 Carole Freeway', @PersonId6);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('2001-12-05', @PersonId6);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Peggie', 'Robin', 'Macejkovic');
DECLARE @PersonId7 BIGINT;
SET @PersonId7 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('899-766-721', @PersonId7);
INSERT INTO Address (AddressOf, PersonId) VALUES ('30674 Myles Crest', @PersonId7);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('1984-07-30', @PersonId7);

INSERT INTO Persons (FirstName, MiddleName, LastName) VALUES ('Oswald', 'Marlowe', 'Klein');
DECLARE @PersonId8 BIGINT;
SET @PersonId8 = SCOPE_IDENTITY();
INSERT INTO Phone (PhoneNumber, PersonId) VALUES ('501-199-721', @PersonId8);
INSERT INTO Address (AddressOf, PersonId) VALUES ('0983 Jessika Oval', @PersonId8);
INSERT INTO BirthDate (BirthDate, PersonId) VALUES ('1989-04-09', @PersonId8);