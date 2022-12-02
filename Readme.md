# Agile Produktlinienarchitektur mit der Clean Architecture - Codebeispiele zur Artikelserie

## Zur Artikelserie

* Windows Developer 09/22
* Windows Developer 10/22


Am Beispiel der Root Entity Fahrzeug wird das Clean Architecture Pattern veranschaulicht. Die Strukturierung des Moduls Fahrzeug ist
architektonisch ausdrucksstark abgebildet. Für das Mapping wird die Two-Way Mapping Strategie eingesetzt.

## Mappings mit AutoMapper

Library: [AutoMapper](https://github.com/AutoMapper/AutoMapper)

### Simples Mapping zwischen Domäne und der Infrastrukturkomponente Web

Die Two-Way Mapping Strategie kann auf Basis einer einfachen Konfiguration realisiert werden, wenn die Klasseneigenschaften den gleichen Namen haben.
Dies ist der Fall bei der FahrzeugEntity und der FahrzeugResource.

```csharp
public class FahrzeugEntity
    {
        public string Fahrgestellnummer { get; set; }
        public string Fahrzeugmodell { get; set; }
        public double Kilometerstand { get; set; }
    }
```

```csharp
public class FahrzeugResource
    {
        public string Fahrgestellnummer { get; set; }
        public string Fahrzeugmodell { get; set; }
        public double Kilometerstand { get; set; }
    }
```

Ein Mapper ganz in diesem Szenario durch eine einfach Konfiguration erstellt werden.

```csharp
public class FahrzeugController
    {
        private readonly FetchFahrzeug fetchFahrzeug;

        private static readonly MapperConfiguration Config = new(cfg => cfg.CreateMap<FahrzeugEntity, FahrzeugResource>());
        private Mapper mapper;

        public FahrzeugController()
        {
            fetchFahrzeug = new FahrzeugService();
            mapper = new Mapper(Config);
        }

        public FahrzeugResource GetFahrzeug(string id)
        {
            var fahrzeug = fetchFahrzeug.FetchFahrzeug(id);
            return mapper.Map<FahrzeugResource>(fahrzeug);
        }

    }
```

### Erweiteres Mapping zwischen Domäne und der Infrastrukturkomponente ServiceClient

Besteht keine Namensgleichheit, kann durch ein sogenanntes Profile, das Mapping angepasst werden. Auch Möglichkeiten für Defaults, etc. sind möglich. Ein einfach Konfiguration für die Objekte FahrzeugEntity und VehicleDto wird im folgenden gezeigt.

```csharp
public class VehicleDto
    {
        public string Vin { get; set; }
        public string ModelType { get; set; }
        public double Mileage { get; set; }
    }
```

Hierfür muss ein Profile von AutoMapper erstellt werden.

```csharp
using AutoMapper;

//...

public class FahrzeugDtoMappingProfile : Profile
    {
        public FahrzeugDtoMappingProfile()
        {
            CreateMap<FahrzeugEntity, VehicleDto>().ReverseMap();
            CreateMap<FahrzeugEntity, VehicleDto>()
                .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Fahrgestellnummer))
                .ForMember(dest => dest.ModelType, opt => opt.MapFrom(s => s.Fahrzeugmodell))
                .ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.Kilometerstand));

        }
    }
```

## Architekturtests mit ArchUnitNET

Ergänzend zur Root Entity Fahrzeug werden das Fahrzeugangebot und die Fahrzeugbewertung eingeführt. Für die daraus
resultierenden fachlichen Modulen, befinden sich [Fitness Functions](https://github.com/MatthiasEschhold/clean-architecture-csharp-demo/tree/main/Test/CleanArchitecture/FitnessFunctions) 
in Form von Strukturtests als Unit Tests mit Hilfe der Bibliothek [ArchUnitNET](https://github.com/TNG/ArchUnitNET). 
Die drei Beispiele werden in der folgenden Tabelle detaillierter beschrieben.

|Unit Test|Beschreibung|
|---------|------------|
|[CleanArchitectureAllRingsCheck](https://github.com/MatthiasEschhold/clean-architecture-csharp-demo/blob/main/Test/CleanArchitecture/FitnessFunctions/CleanArchitectureAllRingsCheck.cs)|Die Prüfung der Beziehungsregeln für alle fachlichen Module erfolgen in einem Unit Test.|
|[CleanArchitectureDetailRingCheck](https://github.com/MatthiasEschhold/clean-architecture-csharp-demo/blob/main/Test/CleanArchitecture/FitnessFunctions/CleanArchitectureDetailRingCheck.cs)|Jeder Ring wird separat als eigener Unit Test geprüft.|
|[CleanArchitectureRootEntityModularizationCheck](https://github.com/MatthiasEschhold/clean-architecture-csharp-demo/blob/main/Test/CleanArchitecture/FitnessFunctions/CleanArchitectureRootEntityModularizationCheck.cs)|Dieser Test prüft die Einhaltung der fachlichen Modularisierung. Dies ist ergänzend zu den anderen Tests, da in diesen nur die Beziehungsregeln anhand der Klassen-Stereotypen geprüft werden, ohne fachliche Modulgrenzen zu berücksichtigen.|

Hinweis: Zur Verdeutlichung sind bewusst Beziehungsverletzungen zwischen Klassen-Stereotypen und den fachlichen Modulen implementiert
