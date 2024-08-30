# Criando Migracao
> dotnet ef migrations add InitialCreate
   To undo
   > dotnet ef migrations remove --force


# Atualizar banco de dados
> dotnet ef database update

# Rollback
> dotnet ef migrations list
> dotnet ef database update InicialCreate


#Obs: Remover referencias das tabelas que não existem mais do arquivos "ApplicationDbContextModelSnapshot.cs"