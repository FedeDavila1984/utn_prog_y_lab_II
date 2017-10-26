SELECT *
FROM Provincia

SELECT P.descripcion
FROM Provincia as P
WHERE P.descripcion like '_u%' --P.id = 10

SELECT *
FROM Provincia INNER JOIN Localidad
	ON Provincia.id = Localidad.idProvincia
WHERE Provincia.id = 25

SELECT L.Nombre, P.descripcion, P.id
FROM Provincia P INNER JOIN Localidad L ON P.id = L.idProvincia
WHERE P.id between 10 and 15
ORDER BY P.descripcion DESC, L.Nombre

INSERT INTO  Provincia(descripcion, id)
VALUES ('La Boca', 25)

UPDATE Provincia
SET descripcion = 'LA BOCA'
WHERE id = (SELECT MAX(id) FROM Provincia)

DELETE
FROM Provincia
WHERE id in (25, 26) OR descripcion like 'LA BOCA'