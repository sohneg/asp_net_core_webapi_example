# ASP.NET Core Web API Beispiel

Dieses Projekt ist ein Beispiel für eine einfache ASP.NET Core Web API, die CRUD-Operationen für ein TestModel bereitstellt.

## Voraussetzungen

- [.NET SDK 6.0 oder höher](https://dotnet.microsoft.com/download/dotnet)
- Eine SQL-Datenbank (z.B. SQL Server) oder SQLite

## Projekt klonen

Um das Projekt zu klonen, führe den folgenden Befehl im Terminal oder in der Eingabeaufforderung aus:

```bash
git clone https://github.com/sohneg/asp_net_core_webapi_example.git
cd asp_net_core_webapi_example
```

## Abhängigkeiten installieren

Navigiere in das Projektverzeichnis und stelle sicher, dass alle Abhängigkeiten installiert sind. Du kannst die Abhängigkeiten mit dem folgenden Befehl installieren:

```bash
dotnet restore
```

## Datenbankkonfiguration

1. **Verbindungszeichenfolge konfigurieren**: Öffne die Datei `appsettings.json` und passe die Verbindungszeichenfolge an, um mit deiner SQL-Datenbank zu verbinden.

   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;"
       }
   }
   ```

2. **Migrationen erstellen**: Führe den folgenden Befehl aus, um die anfängliche Migration zu erstellen und die Datenbank zu aktualisieren:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## Anwendung starten

Um die Anwendung lokal auszuführen, verwende den folgenden Befehl:

```bash
dotnet watch run
```

Die API sollte nun unter `https://localhost:5001` oder `http://localhost:5000` verfügbar sein (abhängig von deiner Konfiguration).

## API verwenden

Du kannst die API mit Tools wie [Postman](https://www.postman.com/) oder [cURL](https://curl.se/) testen. Die API unterstützt folgende Endpunkte:

- `GET /TestModel`: Gibt eine Liste aller TestModelle zurück.
- `GET /TestModel/{id}`: Gibt ein bestimmtes TestModel anhand der ID zurück.
- `POST /TestModel`: Erstellt ein neues TestModel.
- `PUT /TestModel/{id}`: Aktualisiert ein bestehendes TestModel anhand der ID.
- `DELETE /TestModel/{id}`: Löscht ein TestModel anhand der ID.

## Swagger-Dokumentation

Die API-Dokumentation ist über Swagger zugänglich. Nach dem Start der Anwendung kannst du die Swagger-UI unter `https://localhost:5001/swagger` aufrufen.

## Lizenz

Dieses Projekt ist lizenziert unter der MIT-Lizenz.
```

