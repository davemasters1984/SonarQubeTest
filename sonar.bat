dotnet sonarscanner begin /k:"SonarQubeTest" /o:"davidmasters" /d:sonar.login="6f4e1bff1019c2c981e30c2c99c7a44efd6a8773" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.scanner.force-deprecated-java-version=true
dotnet build SonarQubeTest.sln
dotnet sonarscanner end /d:sonar.login="6f4e1bff1019c2c981e30c2c99c7a44efd6a8773"


PAUSE
