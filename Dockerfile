# On part directement de l’image SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0
# On crée un dossier de travail dans le conteneur
WORKDIR /app
# On copie tout le projet local (code source) dans le conteneur
COPY . .
# On compile et publie l’application en mode Release
RUN dotnet publish Devoir-Github_action_avec_csharp.csproj -c Release -o out
# On indique la commande à exécuter quand le conteneur démarre
ENTRYPOINT ["dotnet", "out/MonApi.dll"]