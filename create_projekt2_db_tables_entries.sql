USE master;
GO

IF DB_ID(N'projekt2') IS NULL
  CREATE DATABASE projekt2;
GO

USE projekt2;
GO 

IF OBJECT_ID('Mitarbeiter') IS NOT NULL
  DROP TABLE Mitarbeiter;
GO

IF OBJECT_ID('Benutzeraccount') IS NOT NULL
  DROP TABLE Benutzeraccount;
GO

IF OBJECT_ID('Dienstplan') IS NOT NULL
  DROP TABLE Dienstplan;
GO

IF OBJECT_ID('Wochentag') IS NOT NULL
  DROP TABLE Wochentag;
GO

IF OBJECT_ID('Schicht') IS NOT NULL
  DROP TABLE Schicht;
GO

IF OBJECT_ID('EingeteilterMitarbeiter') IS NOT NULL
  DROP TABLE EingeteilterMitarbeiter;
GO

IF OBJECT_ID('DienstplanTag') IS NOT NULL
  DROP TABLE DienstplanTag;
GO

CREATE TABLE Mitarbeiter (
  ID_Mitarbeiter int IDENTITY NOT NULL PRIMARY KEY, 
  Name nvarchar(500),
  Vorname nvarchar(500),
  Geburtsdatum datetime,
  Einstellungsdatum datetime,
  Stellenbezeichnung nvarchar(500),
  Email nvarchar(500)
);

CREATE TABLE Benutzeraccount (
  ID_Account int NOT NULL IDENTITY PRIMARY KEY, 
  Benutzername nvarchar(50),
  Passwort nvarchar(50),
  IstAdmin bit,
  Angestellter int
  CONSTRAINT fk_Angestellter
    FOREIGN KEY (Angestellter)
    REFERENCES Mitarbeiter(ID_Mitarbeiter)
);

CREATE TABLE Dienstplan (
  ID_Dienstplan int NOT NULL IDENTITY PRIMARY KEY, 
  Kallenderwoche int,
  Jahr int
);

CREATE TABLE Wochentag (
  ID_Wochentag int NOT NULL IDENTITY PRIMARY KEY, 
  Bezeichnung nvarchar(50),
);

CREATE TABLE Schicht (
  ID_Schicht int NOT NULL IDENTITY PRIMARY KEY, 
  Bezeichnung nvarchar(50),
);

CREATE TABLE EingeteilterMitarbeiter ( 
  name nvarchar(500),
  ID_Wochentag int,
  ID_Schicht int,
  CONSTRAINT pk_WochentagID PRIMARY KEY (ID_Wochentag, ID_Schicht),
  CONSTRAINT fk_Wochentag
    FOREIGN KEY (ID_Wochentag)
    REFERENCES Wochentag(ID_Wochentag),
  CONSTRAINT fk_TSchicht
    FOREIGN KEY (ID_Schicht)
    REFERENCES Schicht(ID_Schicht)
);

CREATE TABLE DienstplanTag ( 
  ID_Dienstplan int,
  ID_Wochentag int,
  CONSTRAINT pk_DienstplanID PRIMARY KEY (ID_Dienstplan, ID_Wochentag),
  CONSTRAINT fk_Dienstplan
    FOREIGN KEY (ID_Dienstplan)
    REFERENCES Dienstplan(ID_Dienstplan),
  CONSTRAINT fk_WoTag
    FOREIGN KEY (ID_Wochentag)
    REFERENCES Wochentag(ID_Wochentag)
);


INSERT INTO Mitarbeiter(Name, Vorname, Geburtsdatum, Einstellungsdatum, Stellenbezeichnung, Email) VALUES
  ('Stark','Tony','19900117 10:23:45:123',GETDATE(),'Koch','stark@tony.de'),
  ('Rogers','Steve','19900117 10:23:45:123',GETDATE(),'Servicekraft','rogers@steve.de'),
  ('Parker','Peter','19900117 10:23:45:123',GETDATE(),'Servicekraft','parker@peter.de'),
  ('Odinson','Thor','19900117 10:23:45:123',GETDATE(),'Koch','odinson@thor.de')
;

INSERT INTO Benutzeraccount (Benutzername, Passwort, IstAdmin, Angestellter) VALUES
  ('tonystark', 'tony', 1, 1),
  ('steverogers', 'steve', 0, 2),
  ('peterparker', 'peter', 0, 3),
  ('thorodinson', 'thor', 0, 4)
;

INSERT INTO Dienstplan(Kallenderwoche, Jahr) VALUES
  (1, 2021)
;

INSERT INTO Wochentag(Bezeichnung) VALUES
  ('Montag'),
  ('Dienstag'),
  ('Mittwoch'),
  ('Donnerstag'),
  ('Freitag'),
  ('Samstag'),
  ('Sonntag')
;

INSERT INTO Schicht(Bezeichnung) VALUES
  ('Frühschicht'),
  ('Mittagsschicht'),
  ('Spätschicht')
;

INSERT INTO EingeteilterMitarbeiter(name, ID_Wochentag, ID_Schicht) VALUES
  ('Thor Odinson, Steve Rogers', 1,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 1,2),
  ('Tony Stark, Peter Parker', 1,3),
  ('Thor Odinson, Steve Rogers', 2,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 2,2),
  ('Tony Stark, Peter Parker', 2,3),
  ('Thor Odinson, Steve Rogers', 3,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 3,2),
  ('Tony Stark, Peter Parker', 3,3),
  ('Thor Odinson, Steve Rogers', 4,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 4,2),
  ('Tony Stark, Peter Parker', 4,3),
  ('Thor Odinson, Steve Rogers', 5,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 5,2),
  ('Tony Stark, Peter Parker', 5,3),
  ('Thor Odinson, Steve Rogers', 6,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 6,2),
  ('Tony Stark, Peter Parker', 6,3),
  ('Thor Odinson, Steve Rogers', 7,1),
  ('Thor Odinson, Tony Stark, Steve Rogers, Peter Parker', 7,2),
  ('Tony Stark, Peter Parker', 7,3)
;

INSERT INTO DienstplanTag( ID_Dienstplan, ID_Wochentag) VALUES
  (1,1),
  (1,2),
  (1,3),
  (1,4),
  (1,5),
  (1,6),
  (1,7)
;