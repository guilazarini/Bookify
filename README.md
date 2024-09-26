# Bookify

Aplicativo de arquitetura limpa
* Modelos de domínio ricos.
* Padrão CQRS
* Autenticação usando um provedor de identidade externo (Key Cloak)
* Autorização implementando autorização baseada em função, permissão e recurso
* Exemplo de API mínima (Bookify.API.BookingsEndpoints)
* Testes unitários de camadas de domínio e aplicação
* Teste de integração (usando contêineres Docker)
* Teste Funcional
* Teste de Arquitetura (usando NetArchTest)
* Log estruturado com Serilog e Seq
* Cache Distribuído com Redis
* Verificações de integridade na arquitetura limpa (consulte {{baseUrl/health}} para ver o status do banco de dados, redis e serviços keycloak)
* Versionamento de API
  
### Como executar este aplicativo
* Ter Docker instalado e .Net 7+
* Se for a primeira execução, abra Program.cs e remova o comentário "app.SeedData();" para ter alguns dados iniciais para uso. Lembre-se de comentar para evitar o crescimento do banco de dados.
* Existe um arquivo docker-compose com tudo já configurado para rodar (API, Banco de Dados (Postgres), Key cloak, Seq e Redis).

#### Como criar uma migração de banco de dados
* Defina o projeto de inicialização como **Bookify.API**, abra o Package Manager Console e selecione **src/Bookify.Infrastructure**
* Adicionar migração **Migration_Name**
* Para este projeto, usando DEVELOPMENT, aplicará automaticamente (veja **Program.cs**) a migração quando você executar a API
