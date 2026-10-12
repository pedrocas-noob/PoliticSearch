# PoliticSearch

Aplicação web para tirar dúvidas sobre política de forma rápida e direta: o usuário digita um número correspondente a um tema (ideologia, eixo político, etc.) e recebe uma explicação completa sobre o assunto.

Projeto pessoal de estudo, construído do zero para aprender C#, ASP.NET Core e desenvolvimento web (HTML, CSS e JavaScript).

## Como funciona

1. A tela inicial mostra um campo de texto.
2. O usuário digita o número do tema que quer entender (ex: `1` para Socialismo) e aperta Enter.
3. O back-end em C# recebe o número, busca a explicação correspondente e devolve o texto.
4. A tela de resposta aparece com uma transição suave, mostrando o texto em parágrafos que vão surgindo conforme o usuário rola a página.
5. É possível copiar o texto (botão **Copiar**) ou voltar à tela inicial (botão **Sair**).

Não há integração com nenhuma IA externa — as respostas são pré-definidas e mantidas diretamente no código do back-end.

## Temas disponíveis atualmente

1. Socialismo
2. Liberalismo
3. Comunismo
4. Anarquismo

## Tecnologias usadas

- **Back-end:** C# com ASP.NET Core (Minimal API)
- **Front-end:** HTML, CSS e JavaScript puro (sem frameworks)
- **Animações:** [GSAP](https://gsap.com/) para as transições de tela
- **Servidor:** Kestrel (embutido no ASP.NET Core), servindo tanto a API quanto os arquivos estáticos do front-end a partir da pasta `wwwroot`

## Estrutura do projeto

```
Chatbot/
├── Program.cs              # Configuração do servidor e rota da API (/api/topico/{numero})
├── Models/
│   └── Topico.cs           # Classe que representa um tópico
├── Dados/
│   └── TopicoRepositorio.cs
└── wwwroot/                 # Front-end, servido estaticamente
    ├── index.html
    ├── css/style.css
    └── js/
        ├── script.js
        └── lib/gsap.min.js # GSAP baixado localmente
```

## Como rodar o projeto

Pré-requisito: [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
git clone https://github.com/pedrocas-noob/PoliticSearch.git
cd PoliticSearch
dotnet run
```

Depois é só abrir `http://localhost:5000` no navegador.

## Próximos passos

- Adicionar mais temas/ideologias
- Tema claro (light mode)
- Migrar a lógica de busca de tópicos para usar o repositório em `Dados/` em vez do switch direto no `Program.cs`

## Autor

Desenvolvido por [Pedro Corrêa](https://github.com/pedrocas-noob).
