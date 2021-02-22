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

IF OBJECT_ID('EingeteilteMitarbeiter') IS NOT NULL
  DROP TABLE EingeteilteMitarbeiter;
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
  Jahr nvarchar(50),
  Kallenderwoche nvarchar(50),
  Wochentag nvarchar(50),
  FuerDatum datetime,
  ErstelltDatum datetime
);

CREATE TABLE EingeteilterMitarbeiter ( 
  ID_Mitarbeiter int,
  ID_Dienstplan int,
  CONSTRAINT pk_EingeteilterMitarbeiterID PRIMARY KEY (ID_Mitarbeiter, ID_Dienstplan),
  CONSTRAINT fk_Mitarbeiter
    FOREIGN KEY (ID_Mitarbeiter)
    REFERENCES Mitarbeiter(ID_Mitarbeiter),
  CONSTRAINT fk_Dienstplan
    FOREIGN KEY (ID_Dienstplan)
    REFERENCES Dienstplan(ID_Dienstplan)
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

INSERT INTO Dienstplan(Jahr, Kallenderwoche, Wochentag, FuerDatum, ErstelltDatum) VALUES
  ('2021', '08', 'Montag', '20210222 00:00:00:000',GETDATE()),
  ('2021', '08', 'Dienstag', '20210223 00:00:00:000',GETDATE()),
  ('2021', '08', 'Mittwoch', '20210224 00:00:00:000',GETDATE()),
  ('2021', '08', 'Donnerstag', '20210225 00:00:00:000',GETDATE()),
  ('2021', '08', 'Freitag', '20210226 00:00:00:000',GETDATE()),
  ('2021', '08', 'Samstag', '20210227 00:00:00:000',GETDATE()),
  ('2021', '08', 'Sonntag', '20210227 00:00:00:000',GETDATE())
;

INSERT INTO EingeteilterMitarbeiter(ID_Mitarbeiter, ID_Dienstplan) VALUES
  (1,1),
  (2,1),
  (3,2),
  (4,2),
  (1,3),
  (2,3),
  (3,4),
  (4,4),
  (1,5),
  (2,5),
  (3,6),
  (4,6),
  (1,7),
  (2,7)
;
