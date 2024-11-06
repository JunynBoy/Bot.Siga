# Auto.Siga
Essa ferramenta que construí foi estruturada para ser assunto TCC, e foi desenvolvido seguindo todas as boas práticas de programação que conheço, pretendo deixar público para quem quiser utilizar como base para construção de outras ferramentas, assim pode faze-lo

AutoSIGA é uma aplicação que automatiza o processo de coleta de dados da plataforma SIGA (Sistema Integrado de Gestão Acadêmica) e notifica os usuários sobre atualizações relevantes, como notas e frequência. A solução foi criada para rodar localmente, proporcionando notificações proativas via WhatsApp e e-mail, sem a necessidade de consultar manualmente o SIGA.

## Tecnologias Utilizadas
 - Selenium: Automatiza o processo de login no SIGA e coleta de dados acadêmicos.
 - Windows Forms (C#): Interface desktop para gerenciar e visualizar as notificações.
 - WhatsappWebJS: Envia notificações via WhatsApp.
 - Express (Node.js): API para comunicação e envio de mensagens.
 - MySQL: Banco de dados para armazenamento das configurações de usuários e preferências.
 - Entity Framework: Ferramenta ORM (Object-Relational Mapping) para o .NET que facilita a comunicação entre a aplicação e o banco de dados. 


Sistema para automatização do processo de coleta de informações da plataforma SIGA, inicialmente pensado para ser rodado local mesmo

## Imagens

![image](https://github.com/user-attachments/assets/b0032d3e-d8c8-4dcb-bb76-6214e1db0478)

![image](https://github.com/user-attachments/assets/42c50bc3-559c-4174-a510-c2388d4d0bce)

![image](https://github.com/user-attachments/assets/8272368f-d7a7-449b-a80c-e6c13b8ccd0f)

## Pré-Requisitos
- Dotnet 6.0
- MySQL
- API Whatsapp Web Instalada e configurada https://github.com/JunynBoy/whatsapp-web-js-api


