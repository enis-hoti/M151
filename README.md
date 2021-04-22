# Mein Projekt – Autovermietung

# Ziele des Projektes
Es soll eine Applikation erstellt werden, welche Daten über ein Backend und Datenbank darstellt und bearbeiten lässt. Die Applikation muss mit mind. 2 verschiedenen Personengruppen bedient werden können: z.B. Administrator und Benutzer. Zudem sind folgende Punkte zu erfüllen: 
  • Datenbank mit mind. 2 verschiedenen Benutzern erstellt und lauffähig 
  • Datenbank enthält mind. 2 Tabellen / Collections 
  • Alle Datenbankabfragen werden mittels Transaktionen gemacht – Ausnahmen sind explizit zu deklarieren (z.B. bei NoSQL) 
  • Applikation muss ein Login implementieren – inkl. Sessionmanagement 
  • Mind. 1 austauschbare Schnittstelle (z.B. REST, GraphQL usw.) 
  • Beispiel-Daten sind vorhanden oder werden direkt per Migration beim Start eingefügt

# Um was geht es?
Auf meiner Applikation wird es um eine Autovermietung gehen. Es sollen drei Autos zur Auswahl stehen, welche für den gewünschten Zeitraum zur Vermietung bereitstehen.

# Personengruppen:
Die Applikation gehört einer Privatperson, welcher die Autovermietung auch selbst programmiert hat. Also gibt es genau einen Administrator und jeweils die Kunden, welche in der Datenbank gespeichert werden.

# Nutzbarkeit:
  -	Auf der Applikation sollen drei Autos zur Verfügung stehen und jeweils die wichtigsten Informationen zu den Fahrzeugen.
    -> Als Nutzer möchte ich ein Auto wählen, um das Auto zu mieten.
  - Nachdem man das Auto gewählt hat, wird man im ersten Schritt aufgefordert, seine Informationen anzugeben.
    -> Als Nutzer will ich meine persönlichen Informationen angeben, um mich als Kunde zu speichern.
  -	Nachdem die Prüfung der Formate erfolgt ist, wird man in einem weiteren Schritt aufgefordert die Annahme und Abgabe des Fahrzeuges anzugeben.
    -> Als Nutzer will ich eine Annahme und Abgabe meines gewählten Fahrzeuges angeben, um die Mietung des Autos abschliessen zu können
  -	Auch eine Versicherung wird bereitgestellt, welche man auswählen kann.
    -> Als Nutzer bestehe ich auf eine Versicherung, um mich abzusichern bei einem Unfall.
  -	Zunächst gibt es eine Bestätigung, dass der Vorgang erfolgreich abgeschlossen ist.
    -> Als Nutzer will ich eine Bestätigung sehen, um den Vorgang abzuschliessen.

# Technologien:
  •	C# auf Visual Studio
  •	MySQL als Datenbank


