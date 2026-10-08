var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("api/topico/{numero}", (string numero) =>
{
    if (!int.TryParse(numero, out int id))
    {
        return Results.BadRequest(new { erro = "Digite apenas um número."});

    }

    string? texto = ObterExplicacao(id);

    if (texto is null)
    {
        return Results.NotFound(new { erro = "Número inválido. Escolha um tópico da lista."});
    }

    return Results.Ok(new { numero = id, texto});

});


app.Run();

static string? ObterExplicacao(int numero)
{
    switch (numero)
    {
        case 1:
         return """
Origens e Contexto Histórico

O socialismo surge como corpo de ideias no início do século XIX, num momento de transformação radical da vida material na Europa. A Revolução Industrial havia deslocado populações inteiras do campo para as cidades, criando fábricas onde homens, mulheres e crianças trabalhavam jornadas de 14 a 16 horas em condições frequentemente desumanas. Esse contexto de miséria urbana, concentração de riqueza nas mãos dos donos de fábricas e ausência quase total de proteção legal aos trabalhadores foi o solo onde germinou o pensamento socialista.

A palavra "socialismo" começou a circular por volta da década de 1830, usada tanto por seus defensores quanto por críticos, para descrever propostas que colocavam a organização coletiva da sociedade acima do individualismo liberal então dominante.

Os Socialistas Utópicos

A primeira geração de pensadores socialistas é hoje chamada de "utópica" — termo que, na época, não era necessariamente pejorativo, mas que Marx e Engels usariam depois para diferenciar suas próprias ideias, que consideravam "científicas".

Henri de Saint-Simon (1760-1825) defendia uma sociedade organizada por cientistas e industriais, voltada à produção racional e ao bem-estar coletivo, superando a desorganização do capitalismo liberal.

Charles Fourier (1772-1837) propôs a criação de comunidades autossuficientes chamadas "falanstérios", onde a vida coletiva e o trabalho organizado por afinidades substituiriam a competição do mercado.

Robert Owen (1771-1858), industrial britânico bem-sucedido, colocou parte de suas ideias em prática: em sua fábrica em New Lanark, na Escócia, reduziu jornadas de trabalho, proibiu trabalho infantil abaixo de certa idade e criou escolas para os filhos dos operários. Depois tentou fundar comunidades cooperativas, como a New Harmony, nos Estados Unidos, que acabou fracassando financeiramente.

Essas experiências tinham em comum a crença de que era possível convencer as elites e a sociedade, pela razão e pelo exemplo, a adotar formas mais justas de organização econômica — sem necessariamente depender de conflito de classes ou revolução.

A Virada Marxista

Em 1848, Karl Marx e Friedrich Engels publicam o "Manifesto do Partido Comunista", texto que reformula o socialismo numa chave bem diferente. Para eles, o socialismo não deveria ser um ideal moral a ser alcançado por boa vontade, mas resultado inevitável de contradições internas do próprio capitalismo — a luta de classes entre burguesia (donos dos meios de produção) e proletariado (trabalhadores que vendem sua força de trabalho).

Em 1867, Marx publica o primeiro volume de "O Capital", análise econômica detalhada de como o capitalismo gera mais-valia e acumulação, antecipando crises cíclicas e, eventualmente, uma transição para uma sociedade sem classes.

Essa distinção entre socialismo "utópico" e "científico" se tornaria central no movimento: os marxistas passaram a considerar as experiências de Owen e Fourier como ingênuas, por não atacarem a raiz estrutural do problema — a propriedade privada dos meios de produção.

Organização do Movimento

Em 1864 é fundada em Londres a Associação Internacional dos Trabalhadores, conhecida como Primeira Internacional, reunindo socialistas, marxistas, anarquistas e sindicalistas de diversos países europeus. As tensões entre Marx e o anarquista Mikhail Bakunin sobre o papel do Estado levariam, poucos anos depois, à ruptura entre socialistas e anarquistas como correntes distintas.

Nas décadas seguintes, partidos socialistas se organizam em diversos países europeus: o Partido Social-Democrata Alemão (fundado em 1875) se torna um dos mais influentes, elegendo deputados e construindo uma vasta rede de sindicatos, jornais e associações operárias.

A Bifurcação: Revolução ou Reforma

No final do século XIX, surge um debate fundamental dentro do movimento socialista. Eduard Bernstein, dentro do próprio Partido Social-Democrata Alemão, defende o que ficou conhecido como "revisionismo": a ideia de que o socialismo poderia ser alcançado gradualmente, por meio de reformas dentro do sistema democrático e parlamentar, sem necessidade de revolução violenta.

Essa divisão se aprofunda definitivamente após a Revolução Russa de 1917, quando os bolcheviques de Lênin tomam o poder defendendo a via revolucionária e a ditadura do proletariado como etapa necessária. A partir daí, o campo socialista se divide em duas grandes tradições:

Social-democracia: aceita a democracia liberal como terreno de disputa, busca reformas graduais, Estado de bem-estar social, dentro do capitalismo regulado.
Comunismo: busca a tomada revolucionária do poder e a abolição completa da propriedade privada dos meios de produção, inspirado no modelo soviético.
Socialismo no Século XX

Ao longo do século XX, o socialismo (na sua vertente social-democrata) teve grande influência na construção de Estados de bem-estar social na Europa Ocidental, com sistemas de saúde pública, educação gratuita, seguro-desemprego e aposentadorias — especialmente após a Segunda Guerra Mundial.

Já o socialismo de inspiração mais radical influenciou movimentos de libertação nacional e experiências de governo em diversas partes do mundo, da América Latina à África e Ásia, com resultados bastante variados — desde experiências democráticas até regimes autoritários.

Características Centrais do Pensamento Socialista

Independentemente da vertente, algumas ideias atravessam praticamente todo o espectro socialista:

Crítica à concentração de propriedade privada dos meios de produção nas mãos de poucos
Valorização do trabalho coletivo e da solidariedade de classe
Busca por redução das desigualdades econômicas e sociais
Papel ativo do Estado ou de formas coletivas de organização na economia
Crítica ao mercado como mecanismo único de distribuição de recursos
""";
case 2:
    return """
Origens e Contexto Histórico

O liberalismo nasce entre os séculos XVII e XVIII como resposta ao absolutismo monárquico e à organização social baseada em privilégios hereditários da aristocracia e do clero. É filho direto do Iluminismo, movimento intelectual que colocou a razão humana, e não a tradição ou a autoridade religiosa, como fonte legítima de conhecimento e organização política.

O pano de fundo histórico é a progressiva ascensão de uma classe burguesa — comerciantes, industriais, profissionais liberais — que acumulava riqueza mas não tinha poder político correspondente, já que esse poder permanecia concentrado nas mãos de reis e nobres por direito de nascimento. O liberalismo oferece a essa classe emergente uma justificativa filosófica para reivindicar direitos políticos e liberdade econômica.

As Bases Filosóficas: Locke e o Contratualismo

John Locke (1632-1704) é geralmente apontado como o pai filosófico do liberalismo. Em seus "Dois Tratados sobre o Governo" (1689), Locke argumenta que os seres humanos nascem com direitos naturais — vida, liberdade e propriedade — que existem independentemente do Estado. Para ele, os governos não concedem esses direitos; eles existem para protegê-los.

Locke desenvolve a ideia de "contrato social": os indivíduos consentem em formar um governo para garantir a proteção desses direitos, mas esse consentimento é condicional. Se o governo trai esse pacto — governando tiranicamente —, os cidadãos têm o direito de resistir e substituí-lo. Essa ideia seria fundamental para legitimar revoluções futuras contra monarcas absolutistas.

Locke também lança as bases do liberalismo econômico ao defender a propriedade privada como extensão do trabalho humano: ao misturar seu esforço com a natureza, o indivíduo adquire direito legítimo sobre aquilo que produziu.

Montesquieu e a Separação de Poderes

Outro pilar fundamental vem de Montesquieu, que em "O Espírito das Leis" (1748) propõe a divisão do poder político em três esferas independentes — Executivo, Legislativo e Judiciário — como forma de evitar a concentração de poder e, consequentemente, a tirania. Essa ideia se tornaria estrutural em praticamente todas as constituições liberais modernas.

As Revoluções Liberais

O liberalismo deixa de ser apenas teoria e se torna força histórica concreta em duas revoluções decisivas do século XVIII:

Revolução Americana (1776): as treze colônias britânicas na América declaram independência, redigindo um documento — a Declaração de Independência, de Thomas Jefferson — fortemente inspirado em Locke, afirmando que "todos os homens são criados iguais" e dotados de direitos inalienáveis à vida, liberdade e busca da felicidade. A Constituição americana de 1787, com suas checks and balances, operacionaliza a separação de poderes de Montesquieu.

Revolução Francesa (1789): a derrubada do Antigo Regime na França produz a Declaração dos Direitos do Homem e do Cidadão, afirmando a igualdade perante a lei, a liberdade individual e a soberania popular como fundamento legítimo do poder político, em oposição direta ao direito divino dos reis.

O Liberalismo Econômico: Adam Smith

Paralelamente ao liberalismo político, desenvolve-se o liberalismo econômico, cujo marco fundador é Adam Smith e sua obra "A Riqueza das Nações" (1776). Smith argumenta que a busca racional do interesse próprio dos indivíduos, operando livremente no mercado, gera benefícios coletivos de forma espontânea — a famosa metáfora da "mão invisível".

Smith critica o mercantilismo, sistema então dominante em que o Estado controlava e regulava fortemente o comércio para acumular riqueza nacional. Em seu lugar, propõe a livre concorrência, a divisão do trabalho como motor de produtividade, e um Estado com funções limitadas: garantir justiça, segurança e algumas infraestruturas que o mercado não supriria sozinho.

Expansão no Século XIX

Ao longo do século XIX, o liberalismo se consolida como força política dominante em boa parte da Europa Ocidental e das Américas recém-independentes. Alguns desenvolvimentos importantes:

John Stuart Mill (1806-1873) aprofunda o pensamento liberal em obras como "Sobre a Liberdade" (1859), defendendo que a única justificativa legítima para o Estado restringir a liberdade individual é impedir dano a terceiros — princípio que ficou conhecido como "princípio do dano". Mill também defende o sufrágio feminino, sendo pioneiro nessa pauta dentro do liberalismo.

Movimentos de independência na América Latina (início do séc. XIX) também bebem fortemente da tradição liberal, com líderes como Simón Bolívar inspirados nos ideais de soberania popular e direitos individuais contra o domínio colonial espanhol.

Reformas eleitorais britânicas ao longo do século (1832, 1867, 1884) ampliam gradualmente o direito ao voto, incorporando cada vez mais camadas da população ao sistema representativo — um processo tipicamente liberal de reforma gradual em vez de ruptura revolucionária.

A Crise do Liberalismo Clássico

No final do século XIX e início do XX, o liberalismo clássico — centrado no Estado mínimo e no livre mercado puro — passa por uma crise de legitimidade. A industrialização gerou desigualdades sociais brutais, crises econômicas cíclicas e movimentos operários cada vez mais fortes que questionavam se a liberdade formal perante a lei tinha algum significado real para quem vivia em miséria extrema.

Isso leva ao surgimento do que se chama liberalismo social ou novo liberalismo, que aceita um papel mais ativo do Estado na correção de desigualdades e na garantia de condições mínimas de vida, sem abandonar os princípios fundamentais de liberdade individual e democracia representativa. Pensadores como Thomas Hill Green no Reino Unido ajudam a construir essa ponte, que décadas depois se aproximaria das políticas social-democratas de bem-estar.

O Liberalismo no Século XX

A Grande Depressão de 1929 e suas consequências levam a uma reformulação importante do liberalismo econômico. John Maynard Keynes argumenta que o Estado deve intervir ativamente na economia em momentos de crise, estimulando a demanda através de gastos públicos, para evitar desemprego em massa — uma ruptura parcial com o laissez-faire clássico que, ainda assim, continua operando dentro de um arcabouço liberal democrático.

Na segunda metade do século, surge uma reação a essa tendência intervencionista: o neoliberalismo, associado a pensadores como Friedrich Hayek e Milton Friedman, que defendem o retorno a princípios de livre mercado, privatizações e redução do papel econômico do Estado. Essa vertente ganha força política concreta nos governos de Margaret Thatcher no Reino Unido e Ronald Reagan nos Estados Unidos, nos anos 1980.

Características Centrais do Pensamento Liberal

Atravessando suas várias vertentes históricas, alguns elementos permanecem constantes no liberalismo:

Primazia da liberdade individual frente ao poder do Estado e de grupos coletivos
Direitos naturais ou fundamentais que preexistem e limitam a autoridade política
Governo representativo, baseado em consentimento e constituição
Separação de poderes como mecanismo contra a tirania
Igualdade formal perante a lei, independente de nascimento ou status social
Valorização, em maior ou menor grau conforme a vertente, da propriedade privada e da livre iniciativa econômica
""";
case 3:
    return """
    O comunismo nasce dentro do campo socialista, mas se consolida como corrente própria a partir da obra de Karl Marx e Friedrich Engels em meados do século XIX. É importante entender que, inicialmente, "socialismo" e "comunismo" eram praticamente sinônimos — o próprio texto fundador de Marx e Engels se chama "Manifesto do Partido Comunista" (1848), não "Manifesto Socialista". A separação clara entre os dois termos como ideologias distintas só se consolida depois da Revolução Russa de 1917, quando os bolcheviques de Lênin adotam o nome "comunista" para se diferenciar dos socialistas reformistas, considerados por eles insuficientemente revolucionários.

As Bases Teóricas de Marx e Engels

A teoria marxista parte de uma leitura específica da história, chamada materialismo histórico: para Marx, as estruturas econômicas de uma sociedade — quem possui os meios de produção e como o trabalho é organizado — determinam, em última instância, suas estruturas políticas, jurídicas e culturais. A história, nessa visão, é movida pela luta entre classes sociais com interesses econômicos antagônicos: senhores e escravos na Antiguidade, senhores feudais e servos na Idade Média, burguesia e proletariado no capitalismo.

Em "O Capital" (1867), Marx desenvolve sua análise econômica central: a teoria da mais-valia. Segundo ele, o valor de uma mercadoria vem do trabalho humano empregado em produzi-la, mas o trabalhador recebe em salário menos do que o valor que seu trabalho efetivamente gera — essa diferença, a mais-valia, é apropriada pelo capitalista como lucro. Para Marx, essa é a engrenagem estrutural da exploração no capitalismo, e não um problema moral pontual a ser corrigido por boa vontade.

A partir dessa análise, Marx previa que o capitalismo geraria crises cíclicas cada vez mais graves, concentração crescente de capital, empobrecimento relativo do proletariado e, eventualmente, uma revolução em que os trabalhadores tomariam o poder, aboliriam a propriedade privada dos meios de produção e instaurariam uma fase de transição — a "ditadura do proletariado" — antes de alcançar uma sociedade comunista plena, sem classes, sem Estado e sem propriedade privada.

Lênin e a Revolução Russa

Marx escreveu pensando principalmente em sociedades industrializadas da Europa Ocidental, como a Alemanha e a Inglaterra, onde o proletariado industrial já era numeroso. A Rússia do início do século XX, porém, era um país majoritariamente agrário, com industrialização incipiente — o que colocava um problema teórico: como fazer uma revolução "proletária" num país sem proletariado numeroso?

Vladimir Lênin resolve essa questão propondo o conceito de "partido de vanguarda": um grupo organizado e disciplinado de revolucionários profissionais que conduziria a revolução em nome da classe trabalhadora, mesmo que esta ainda não tivesse consciência de classe plenamente desenvolvida. Essa ideia, desenvolvida principalmente em "Que Fazer?" (1902), se tornaria estrutural para praticamente todos os movimentos comunistas do século XX.

Em outubro de 1917 (pelo calendário juliano então usado na Rússia), os bolcheviques liderados por Lênin tomam o poder em Petrogrado, derrubando o governo provisório que havia substituído o czar meses antes. Segue-se uma sangrenta guerra civil (1918-1922) entre o Exército Vermelho bolchevique e as forças "brancas" contrarrevolucionárias, apoiadas por potências estrangeiras. Com a vitória bolchevique, forma-se em 1922 a União das Repúblicas Socialistas Soviéticas (URSS), o primeiro Estado a se declarar oficialmente comunista.

Stalin e a Consolidação do Modelo Soviético

Após a morte de Lênin em 1924, Josef Stalin consolida o poder através de uma sucessão de disputas internas no Partido Comunista, eliminando rivais como Trotsky (expulso e depois assassinado no exílio) por meio de expurgos e julgamentos políticos.

Sob Stalin, a URSS passa por um processo de industrialização acelerada e planejamento centralizado através dos planos quinquenais, iniciados em 1928, que transformaram a União Soviética numa potência industrial em poucas décadas, a um custo humano altíssimo. A coletivização forçada da agricultura, iniciada no final dos anos 1920, provocou fome generalizada, com destaque para o Holodomor na Ucrânia (1932-1933), que causou milhões de mortes. O período também foi marcado pelo Grande Terror (1936-1938), com execuções em massa e envio de milhões de pessoas a campos de trabalho forçado, os gulags.

Esse modelo soviético — partido único, planejamento econômico estatal centralizado, culto à personalidade do líder e forte repressão política — se tornaria referência, para o bem e para o mal, de boa parte dos regimes que se autodenominariam comunistas ao longo do século XX.

Expansão Global do Comunismo

Após a Segunda Guerra Mundial, o comunismo se expande significativamente:

Europa Oriental: países como Polônia, Hungria, Tchecoslováquia e Alemanha Oriental passam a integrar a esfera de influência soviética, com governos comunistas instalados sob tutela de Moscou — o que Winston Churchill descreveria como a "Cortina de Ferro".

China: Mao Tsé-Tung lidera o Partido Comunista Chinês à vitória na guerra civil contra os nacionalistas do Kuomintang, proclamando a República Popular da China em 1949. Mao adapta o marxismo-leninismo ao contexto chinês, dando peso central ao campesinato (e não apenas ao proletariado urbano) como base revolucionária. Seu governo implementa o Grande Salto Adiante (1958-1962), tentativa de industrialização e coletivização forçada que resultou numa das maiores fomes da história, com dezenas de milhões de mortos. Depois viria a Revolução Cultural (1966-1976), movimento de purga política e ideológica que causou profunda instabilidade social.

Cuba: Fidel Castro e Che Guevara derrubam a ditadura de Fulgêncio Batista em 1959; Cuba se declara socialista em 1961, tornando-se aliado próximo da URSS durante a Guerra Fria, a poucos quilômetros dos Estados Unidos.

Outros movimentos: regimes e movimentos comunistas ou de inspiração comunista também se estabeleceram ou tiveram forte presença no Vietnã, Coreia do Norte, Laos, Camboja (sob o regime do Khmer Vermelho, de Pol Pot, responsável por um dos genocídios mais letais do século XX), Angola, Moçambique e Etiópia, entre outros.

A Guerra Fria

Entre 1947 e 1991, o mundo viveu sob a lógica bipolar da Guerra Fria, confronto geopolítico, ideológico e militar (embora sem confronto direto entre as duas potências) entre os Estados Unidos, representando o bloco capitalista ocidental, e a União Soviética, à frente do bloco comunista. Esse período incluiu episódios de altíssima tensão, como a Crise dos Mísseis de Cuba (1962), além de guerras por procuração em diversos continentes, como Coreia (1950-1953), Vietnã (1955-1975) e Afeganistão (1979-1989).

O Colapso do Bloco Soviético

A partir de meados dos anos 1980, Mikhail Gorbatchov implementa na URSS as políticas de glasnost (abertura/transparência) e perestroika (reestruturação econômica), tentando reformar o sistema soviético sem abandoná-lo completamente. Esse processo, porém, acelera o enfraquecimento do controle soviético sobre a Europa Oriental.

Em 1989, o Muro de Berlim, símbolo maior da divisão entre os blocos, é derrubado, seguindo-se uma onda de queda dos regimes comunistas em toda a Europa Oriental. Em 1991, a própria União Soviética se dissolve oficialmente, fragmentando-se em quinze países independentes — marco geralmente apontado como o fim da Guerra Fria e, para muitos, da viabilidade do modelo comunista soviético como projeto global.

O Comunismo Hoje

Apesar do colapso soviético, alguns países mantêm oficialmente sistemas de partido único comunista, embora com profundas transformações econômicas. A China, desde as reformas de Deng Xiaoping a partir de 1978, combina controle político rígido do Partido Comunista com abertura progressiva ao mercado e ao capital privado — um modelo que gera debates acadêmicos intensos sobre até que ponto ainda pode ser chamado de "comunista" no sentido clássico. Cuba, Vietnã, Laos e Coreia do Norte também seguem, cada um à sua maneira e com diferentes graus de abertura econômica, sob regimes de partido único de origem comunista.

Características Centrais do Pensamento Comunista

Alguns elementos aparecem de forma relativamente constante nas diversas experiências e formulações comunistas:

Abolição da propriedade privada dos meios de produção como objetivo central
Papel do partido comunista como vanguarda organizadora da classe trabalhadora
Ditadura do proletariado como fase de transição necessária
Planejamento econômico centralizado, em oposição ao mercado como mecanismo de alocação de recursos
Objetivo final de uma sociedade sem classes e, teoricamente, sem necessidade de Estado
Na prática histórica, forte concentração de poder político num único partido e frequente repressão à oposição
""";
case 4:
    return """
Origens e Contexto Histórico

O anarquismo se desenvolve ao longo do século XIX, no mesmo caldo histórico que gerou o socialismo e o comunismo — a industrialização, a miséria urbana, a exploração do trabalho fabril. A diferença fundamental, desde o início, está no diagnóstico sobre a origem da opressão: enquanto marxistas concentravam sua crítica na propriedade privada e nas relações de classe, os anarquistas estendiam essa crítica a toda forma de hierarquia coercitiva, incluindo o próprio Estado — mesmo um Estado socialista ou controlado pela classe trabalhadora.

Essa divergência levaria a uma ruptura histórica profunda entre as duas tradições, que marcaria o movimento operário internacional por décadas.

Proudhon e as Primeiras Formulações

Pierre-Joseph Proudhon (1809-1865) é geralmente considerado o primeiro pensador a se autodenominar anarquista, num sentido político e filosófico, não apenas como sinônimo de caos. Em "O Que É a Propriedade?" (1840), Proudhon oferece sua resposta mais célebre: a propriedade privada dos meios de produção, obtida sem trabalho direto, é uma forma de roubo, pois permite que alguém se aproprie do fruto do trabalho alheio sem produzir nada em troca.

Proudhon não defendia a abolição total de qualquer forma de posse, mas distinguia propriedade de posse: o uso legítimo de algo por quem efetivamente trabalha nele seria aceitável, mas a propriedade como instrumento de exploração e acumulação deveria ser superada. Ele propunha um sistema de mutualismo, baseado em cooperativas, associações de crédito e trocas diretas entre produtores, sem a necessidade de um Estado centralizador.

Bakunin e a Ruptura com Marx

Mikhail Bakunin (1814-1876), nobre russo exilado por suas atividades revolucionárias, é a figura central na consolidação do anarquismo como movimento organizado e na sua separação definitiva do marxismo. Bakunin participou ativamente da Primeira Internacional (fundada em 1864), onde se tornou o principal rival teórico e político de Marx dentro do movimento operário internacional.

O cerne do desacordo entre os dois era a questão do Estado. Marx defendia que o proletariado deveria tomar o poder estatal, mesmo que temporariamente, para depois promover sua extinção gradual. Bakunin considerava essa estratégia uma ilusão perigosa: para ele, qualquer grupo que assumisse o controle do aparato estatal — mesmo em nome da classe trabalhadora — acabaria constituindo uma nova elite burocrática e repressiva, perpetuando a dominação sob nova roupagem. Bakunin previu, com notável antecipação, que uma "ditadura do proletariado" tenderia a se transformar na ditadura de um pequeno grupo de dirigentes sobre o proletariado — profecia que muitos anarquistas consideram confirmada pela experiência soviética décadas depois.

Esse conflito culminou na expulsão de Bakunin e seus seguidores da Primeira Internacional, em 1872, selando a divisão entre as tradições marxista e anarquista dentro do movimento socialista mais amplo.

Kropotkin e o Anarco-Comunismo

Piotr Kropotkin (1842-1921), também aristocrata russo, desenvolve uma vertente que ficaria conhecida como anarco-comunismo, combinando a crítica anarquista ao Estado com a defesa da propriedade comum (e não apenas mutualista, como em Proudhon). Em obras como "Ajuda Mútua: Um Fator de Evolução" (1902), Kropotkin argumenta, contra certas leituras deterministas do darwinismo social, que a cooperação — e não apenas a competição — é um fator central na evolução das espécies e das sociedades humanas, servindo de base biológica e histórica para sua visão de uma sociedade organizada sem Estado, baseada em federações voluntárias de comunidades autogeridas.

Outras Correntes Importantes

O anarquismo nunca foi um bloco monolítico, e ao longo do século XIX e XX se desenvolveram vertentes distintas:

Anarco-sindicalismo: corrente que viu nos sindicatos de trabalhadores o principal instrumento de luta e de organização de uma futura sociedade sem Estado, apostando na greve geral como ferramenta revolucionária central. Teve força particular na Espanha e na França no início do século XX.

Individualismo anarquista: associado a pensadores como Max Stirner, que enfatiza a soberania absoluta do indivíduo contra qualquer forma de coletivismo ou coerção, incluindo a pressão social e moral, não apenas o Estado formal.

A Revolução Espanhola

O momento de maior experimentação prática anarquista da história ocorre durante a Guerra Civil Espanhola (1936-1939). Em regiões como a Catalunha e Aragão, sindicatos anarquistas — principalmente a CNT (Confederação Nacional do Trabalho) — e suas organizações aliadas promoveram coletivizações em massa de fábricas, terras agrícolas e serviços urbanos, geridos diretamente por assembleias de trabalhadores, sem patrões nem gestão estatal centralizada.

Essas experiências de autogestão, embora de curta duração — esmagadas pela vitória das forças franquistas em 1939, mas também minadas internamente por conflitos com comunistas stalinistas que disputavam o controle da resistência republicana —, são até hoje referência central para anarquistas em todo o mundo como prova histórica de que formas de organização horizontal e sem Estado podiam funcionar em larga escala, inclusive em contexto de guerra.

Anarquismo no Século XX e Contemporâneo

Após o período entre guerras, o anarquismo perde protagonismo político de massa em relação a outras ideologias de esquerda, mas permanece vivo como corrente de pensamento e ativismo, ressurgindo com força em alguns momentos específicos:

Maio de 1968, na França, trouxe de volta elementos anarquistas e libertários ao debate político, com forte ênfase em autogestão, crítica à burocracia e às hierarquias tanto capitalistas quanto do socialismo de Estado soviético.

Movimentos antiglobalização, no final dos anos 1990 e início dos anos 2000 — como os protestos de Seattle contra a Organização Mundial do Comércio, em 1999 —, trouxeram práticas organizacionais de inspiração anarquista, como tomada de decisão por consenso e estruturas horizontais sem lideranças formais, de volta ao debate público global.

Hoje o anarquismo também dialoga e se funde com outras pautas, como o ecologismo radical (dando origem ao ecoanarquismo ou anarco-primitivismo) e movimentos feministas, formando correntes híbridas como o anarcofeminismo.

Características Centrais do Pensamento Anarquista

Apesar da diversidade interna, algumas ideias atravessam praticamente todas as vertentes anarquistas:

Rejeição de toda forma de hierarquia coercitiva e não consentida, especialmente o Estado
Crítica tanto ao capitalismo quanto ao socialismo de Estado como formas de dominação
Defesa da organização social horizontal, federativa e voluntária
Ação direta e autogestão como métodos preferenciais de transformação social, em vez da disputa eleitoral ou da tomada do aparato estatal
Forte ênfase na liberdade individual combinada com solidariedade e cooperação coletiva
Desconfiança histórica profunda em relação a qualquer grupo que concentre poder político, mesmo em nome de causas revolucionárias
""";
default:
    return null;
    }
}