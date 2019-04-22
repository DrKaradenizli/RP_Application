# RP_Application

Programm vergleicht zwei Listen, eine mit Models und eine mit Cars.

Models Objekte enthalten die Informationen wieviel Verbrauch ein bestimmtes Model eines Autos hat.

Die andere Liste "cars" beinhaltet alle gegebenen Autos.

Die Methode RequestCarId hat jeweils die Variante mit einem Parameter und die überladene Methode mit einem Parameter count.


## RequestCarId(string searchString)

Sucht in den beiden Listen nach den Autos, deren Marke den searchString-parameter entsprechen. Diese werden in einer Liste zurückgegeben, in der die IDs der gefundenen Autos 
enthalten sind.

## RequestCarId(int count, string searchString)

Sucht in den beiden Listen nach den Autos, deren Marke den searchString-parameter entsprechen. Diese werden in einer Liste zurückgegeben, in der die IDs der gefundenen Autos 
enthalten sind. Es werden jedoch nur soviele IDs zurückgegeben wie gefunden werden. Sollte es weniger Resultate bzw. gefundene Autos geben, als der Count war, dann wird dies mit ausgegeben.


Zum Ausführen in der Datei program1.cs laufen lassen. Mit Visual Studio [Crtl]+[F5] drücken.
