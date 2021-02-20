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

IF OBJECT_ID('MitarbeiterSchicht') IS NOT NULL
  DROP TABLE MitarbeiterSchicht;
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
  Jahr int,
  Personalgruppe nvarchar(50)
);

CREATE TABLE Wochentag (
  ID_Wochentag int NOT NULL IDENTITY PRIMARY KEY, 
  Bezeichnung nvarchar(50),
  PersPlan int
  CONSTRAINT fk_PersPlan
    FOREIGN KEY (PersPlan)
    REFERENCES Dienstplan(ID_Dienstplan)
);

CREATE TABLE Schicht (
  ID_Schicht int NOT NULL IDENTITY PRIMARY KEY, 
  Bezeichnung nvarchar(50),
  Tag int
  CONSTRAINT fk_Tag
    FOREIGN KEY (Tag)
    REFERENCES Wochentag(ID_Wochentag)
);

CREATE TABLE MitarbeiterSchicht ( 
  Mitarbeitername nvarchar(50),
  ID_Mitarbeiter int,
  ID_Schicht int,
  CONSTRAINT pk_MitarbeiterID PRIMARY KEY (ID_Mitarbeiter, ID_Schicht),
  CONSTRAINT fk_Mitarbeiter
    FOREIGN KEY (ID_Mitarbeiter)
    REFERENCES Mitarbeiter(ID_Mitarbeiter),
  CONSTRAINT fk_Schicht
    FOREIGN KEY (ID_Schicht)
    REFERENCES Schicht(ID_Schicht)
);

INSERT INTO Mitarbeiter(Name, Vorname, Geburtsdatum, Einstellungsdatum, Stellenbezeichnung, Email, IstVerfügbar) VALUES
  ('Stark','Tony','19900117 10:23:45:123',GETDATE(),'Koch','stark@tony.de', 1),
  ('Rogers','Steve','19900117 10:23:45:123',GETDATE(),'Servicekraft','rogers@steve.de', 1),
  ('Parker','Peter','19900117 10:23:45:123',GETDATE(),'Servicekraft','parker@peter.de', 1),
  ('Odinson','Thor','19900117 10:23:45:123',GETDATE(),'Koch','odinson@thor.de', 1)
;

INSERT INTO Benutzeraccount (Benutzername, Passwort, IstAdmin, Angestellter) VALUES
  ('tonystark', 'tony', 1, 1),
  ('steverogers', 'steve', 0, 2),
  ('peterparker', 'peter', 0, 3),
  ('thorodinson', 'thor', 0, 4)
;

INSERT INTO Dienstplan(Kallenderwoche, Jahr,Personalgruppe) VALUES
  (1, 2021,'Küchenpersonal')
;

INSERT INTO Wochentag(Bezeichnung, PersPlan) VALUES
  ('Montag', 1),
  ('Dienstag', 1),
  ('Mittwoch', 1),
  ('Donnerstag', 1),
  ('Freitag', 1),
  ('Samstag', 1),
  ('Sonntag', 1)
;

INSERT INTO Schicht(Bezeichnung, Tag) VALUES
  ('Frühschicht', 1),
  ('Mittagsschicht', 1),
  ('Spätschicht', 1),
  ('Frühschicht', 2),
  ('Mittagsschicht', 2),
  ('Spätschicht', 2),
  ('Frühschicht', 3),
  ('Mittagsschicht', 3),
  ('Spätschicht', 3),
  ('Frühschicht', 4),
  ('Mittagsschicht', 4),
  ('Spätschicht', 4),
  ('Frühschicht', 5),
  ('Mittagsschicht', 5),
  ('Spätschicht', 5),
  ('Frühschicht', 6),
  ('Mittagsschicht', 6),
  ('Spätschicht', 6),
  ('Frühschicht', 7),
  ('Mittagsschicht', 7),
  ('Spätschicht', 7)
;

INSERT INTO MitarbeiterSchicht (Mitarbeitername, ID_Mitarbeiter, ID_Schicht) VALUES
  ('Thor Odinson', 4,1),
  ('Thor Odinson', 4,2),
  ('Tony Stark', 1,2),
  ('Tony Stark', 1,3),
  ('Thor Odinson', 4,4),
  ('Thor Odinson', 4,5),
  ('Tony Stark', 1,5),
  ('Tony Stark', 1,6),
  ('Thor Odinson', 4,7),
  ('Thor Odinson', 4,8),
  ('Tony Stark', 1,8),
  ('Tony Stark', 1,9),
  ('Thor Odinson', 4,10),
  ('Thor Odinson', 4,11),
  ('Tony Stark', 1,11),
  ('Tony Stark', 1,12),
  ('Thor Odinson', 4,13),
  ('Thor Odinson', 4,14),
  ('Tony Stark', 1,14),
  ('Tony Stark', 1,15),
  ('Thor Odinson', 4,16),
  ('Thor Odinson', 4,17),
  ('Tony Stark', 1,17),
  ('Tony Stark', 1,18),
  ('Thor Odinson', 4,19),
  ('Thor Odinson', 4,20),
  ('Tony Stark', 1,20),
  ('Tony Stark', 1,21)
;