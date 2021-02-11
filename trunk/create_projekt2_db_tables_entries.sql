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

CREATE TABLE Mitarbeiter (
  ID_Mitarbeiter int IDENTITY NOT NULL PRIMARY KEY, 
  Name nvarchar(500),
  Vorname nvarchar(500),
  Geburtsdatum datetime,
  Einstellungsdatum datetime,
  Stellenbezeichnung nvarchar(500),
  Email nvarchar(500),
  IstVerfügbar bit,
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
  Personalgruppe nvarchar(50),
  IstAdmin bit,
  employee int
  CONSTRAINT fk_employee
  FOREIGN KEY (employee)
  REFERENCES Mitarbeiter(ID_Mitarbeiter)
);

INSERT INTO Mitarbeiter(Name, Vorname, Geburtsdatum, Einstellungsdatum, Stellenbezeichnung, Email, IstVerfügbar) VALUES
  ('Stark','Tony','19900117 10:23:45:123',GETDATE(),'Koch','stark@tony.de', 1),
  ('Rogers','Steve','19900117 10:23:45:123',GETDATE(),'Servicekraft','rogers@steve.de', 1),
  ('Parker','Peter','19900117 10:23:45:123',GETDATE(),'Servicekraft','parker@peter.de', 1),
  ('Thor','Odinson','19900117 10:23:45:123',GETDATE(),'Koch','odinson@thor.de', 1);

INSERT INTO Benutzeraccount (Benutzername, Passwort, IstAdmin, Angestellter) VALUES
  ('tonystark', 'tony', 1, 1),
  ('steverogers', 'steve', 0, 2),
  ('peterparker', 'peter', 0, 3),
  ('thorodinson', 'thor', 0, 4)
;
