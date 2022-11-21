DECLARE @i INT = 1;
DECLARE @j INT = 1;
DECLARE @d INT = 1;
DECLARE @c INT = 1;

SET IDENTITY_INSERT Peliculas ON;
INSERT INTO Peliculas(Id,Titulo,FechaDeEstreno,Duracion,FechaDesplazamiento)
VALUES(1,'Avatar 2','2022-12-15',190,'2023-2-15');
SET IDENTITY_INSERT Peliculas OFF;

SET IDENTITY_INSERT Funciones ON;
INSERT INTO Funciones(Id,DiaHorario,PeliculaId)
VALUES(1,'2022-12-15 16:30:00',1);
INSERT INTO Funciones(Id,DiaHorario,PeliculaId)
VALUES(2,'2022-12-15 20:30:00',1);
SET IDENTITY_INSERT Funciones OFF;

--inserción de asientos

SET IDENTITY_INSERT Asientos ON;
WHILE @i < 6
BEGIN
	WHILE @j < 6
	BEGIN
		INSERT INTO dbo.Asientos(Id,EstaLibre,Fila,NumeroDeAsiento)
		VALUES(@c,1,@i, @j);
   SET @j = @j + 1;
   SET @c = @c + 1;
   END;
SET @j = 1;
SET @i = @i + 1;
END;

SET @i = 1;
SET @j = 1;

WHILE @i < 6
BEGIN
	WHILE @j < 6
	BEGIN
		INSERT INTO dbo.Asientos(Id,EstaLibre,Fila,NumeroDeAsiento)
		VALUES(@c,1,@i, @j);
   SET @j = @j + 1;
   SET @c = @c + 1;
   END;
SET @j = 1;
SET @i = @i + 1;
END;

SET @i = 1;
SET @j = 1;

SET IDENTITY_INSERT Asientos OFF;

SET IDENTITY_INSERT AsientosXFuncion ON;

SET @c = 1;

WHILE @i < 6
BEGIN
	WHILE @j < 6
	BEGIN
		INSERT INTO dbo.AsientosXFuncion(Id,FuncionId,AsientoId)
		VALUES(@c,1,@c);
   SET @j = @j + 1;
   SET @c = @c + 1;
   END;
SET @j = 1;
SET @i = @i + 1;
END;

SET @d = 1;
SET @c = 26
SET @i = 1;
SET @j = 1;

WHILE @i < 6
BEGIN
	WHILE @j < 6
	BEGIN
		INSERT INTO dbo.AsientosXFuncion(Id,FuncionId,AsientoId)
		VALUES(@c,2,@d);
   SET @j = @j + 1;
   SET @c = @c + 1;
   SET @d = @d + 1;
   END;
SET @j = 1;
SET @i = @i + 1;
END;
SET IDENTITY_INSERT AsientosXFuncion OFF;