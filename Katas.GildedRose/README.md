## Katas.GildedRose

Test with coverage:

```
dotnet test --collect:"XPlat Code Coverage"
```


Get the guid, for the test run, and run this to generate the report

```
reportgenerator -reports:"Katas.GildedRose.Tests\TestResults\9bc743c7-3e4d-4919-9efe-04827fa7ff3b\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```