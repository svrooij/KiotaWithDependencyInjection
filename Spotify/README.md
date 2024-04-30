# Spotify client for .NET

This is a generated client from the [Spotify API](https://developer.spotify.com/documentation/web-api/reference/) using [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview?wt.mc_id=SEC-MVP-5004985_).

This project has nothing changed from the generated code (except this README.md), it can be any client you generate using Kiota.

## Usage

```csharp
IAuthenticationProvider authProvider = ...;
var client = new SpotifyClient(new HttpClientRequestAdapter(authProvider));
```

## Install / Update Kiota

```PowerShell
dotnet tool install --global Microsoft.OpenApi.Kiota
```

```PowerShell
dotnet tool update --global Microsoft.OpenApi.Kiota
```

## Generate Client

```PowerShell
kiota generate -l CSharp -c SpotifyClient -n Spotify -d https://api.apis.guru/v2/specs/spotify.com/1.0.0/openapi.json -o ./ --deserializer Microsoft.Kiota.Serialization.Json.JsonParseNodeFactory --serializer Microsoft.Kiota.Serialization.Json.JsonSerializationWriterFactory
```

