# TodoApi

API REST construite avec ASP.NET Core 10 et Entity Framework Core InMemory.

## Prérequis
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Docker](https://www.docker.com/products/docker-desktop/) (optionnel)

## Exécuter l'application localement

### Sans Docker
```bash
git clone https://github.com/Abiatou/TodoApi.git
cd TodoApi
dotnet run --launch-profile http
```
Ouvrez : http://localhost:5253/scalar/v1

### Avec Docker
```bash
docker build -t todoapi .
docker run -d -p 8080:8080 todoapi
```
Ouvrez : http://localhost:8080/scalar/v1

## Endpoints
| Méthode | URL | Description |
|---------|-----|-------------|
| GET | /api/todoitems | Lister tous les todos |
| GET | /api/todoitems/{id} | Obtenir un todo |
| POST | /api/todoitems | Créer un todo |
| PUT | /api/todoitems/{id} | Modifier un todo |
| DELETE | /api/todoitems/{id} | Supprimer un todo |