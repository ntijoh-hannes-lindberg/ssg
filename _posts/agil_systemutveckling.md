# Agil systemutveckling

Agil utveckling handlar om arbetskultur med fokus på att förbättra samarbetet mellan olika delar av verksamheten för att tillsammans ansvara för att bygga en så bra produkt som möjligt. Det betyder att både utvecklingsteam och affären arbetar och ansvarar tillsammans med att prioritera och välja ut de viktigaste delarna av arbetet.

Klassiskt har metoder för mjukvaruutveckling kommit från utveckling av andra (fysiska) produkter som t.ex. att bygga en bil eller en bro. En bil designas för att sedan byggas i exakt likadana kopior. Mjukvara behöver oftast inte dupliceras på det sättet. Produkten kan istället fortsätta att utvecklas under hela livscykeln. Skillnaden mellan mjukvara och hårdvara är stor.

En klassisk utvecklingsmetod är **vattenfallsmetoden** där fokus ligger på att minimera sena ändringar eftersom det kan kosta väldigt mycket pengar att t.ex. förändra en hel fabrik sent i processen. Varje fas blir färdig innan nästa påbörjas. Utvecklingen sker sekventiellt ungefär i dessa steg:

![Vattenfall](agil-vattenfall.png)

Ett av problemen med att använda en så stelbent process för att bygga mjukvara är att steget från krav till färdig produkt blir långt. Ofta vet varken team eller kund vad de vill ha förrän efter produkten är färdig — och då är det oftast dyrt att ändra.

I alla agila metoder arbetar istället företaget för att hela tiden utveckla och leverera nästa fungerande produkt så fort som möjligt. För att göra det måste man arbeta i korta iterationer där fokus är att bryta ner varje större uppgift till lagom stora steg att visa kunden, som då kan delta i större utsträckning. I varje steg går det att känna på produkten och försäkra sig om att man är på rätt väg.

Längden på en utvecklingsiteration är olika men ofta från några dagar till några veckor. Det finns lika många varianter på agila arbetsmetoder som det finns projekt eller företag.

![Spiral](agil-spiral.png)

### Läs

- [Agile software development på Wikipedia](https://en.wikipedia.org/wiki/Agile_software_development) 📖  
- [Waterfall model på Wikipedia](https://en.wikipedia.org/wiki/Waterfall_model) 📖

---

## Kanban

**Kanban** är en agil metod från Japan och blev känd från Toyota. Den s.k. *kanban-boarden* kommer härifrån.  
Se [Atlassians förklaring av att arbeta iterativt](https://www.youtube.com/watch?v=iVaFVa7HYj4).  
Även om de pratar om Kanban i videon gäller koncepten för agilt arbete. Videon är vald för att den tydligt visar hur *todos* kan hanteras med post-it-lappar.

**Scrums** (nedan) motsvarighet till kanban-tavlan heter **sprint backlog**.

**Läs:** [Kanban på Wikipedia](https://en.wikipedia.org/wiki/Kanban_(development)) 📖

![Kanban Board](agile-kanban-board-wikipedia.jpg)

---

## Scrum

**Scrum** är en av de mest använda agila arbetsmetoderna i mjukvaruprojekt. Den bestämmer i större detalj hur arbetet går till.

**Läs:** [Scrum på 5 minuter (PDF)](https://hyper.peterhagander.se/content/Scrum_broschyr.pdf) 📖

### Roller i Scrum

**Product Owner (PO)** – Ansvarar för att ta fram och prioritera de övergripande förändringar som ska göras i en produkt. Representerar kunderna och ansvarar för *product backlog*.

**Scrum Master (SM)** – Hjälper utvecklingsteamet att arbeta effektivt. Kan ses som coach, fixare och dörrvakt. Ansvarar bl.a. för att kalla till sprint demo.

**Scrum Team (utvecklare)** – De som utvecklar produkten. Vanligtvis 5–9 personer.  
Teamet ska lära sig ta på sig lagom mycket arbete under varje sprint.

---

### Arbetsgången i Scrum (förenklad)

Arbetet sker i **sprints** på cirka två veckor.

1. **Sprint planning:** PO, SM och utvecklare väljer ut *product backlog items* till *sprint backlog*.  
2. **Sprint backlog:** Liknar en Kanban-board med post-it-lappar som flyttas mellan kolumner.  
3. **Daily standup:** 10 minuters möte där varje utvecklare svarar på:
   - Igår gjorde jag…
   - Idag ska jag…
   - Jag har problem med…
4. **Demo & retrospective:** När sprinten är slut visas resultatet och utvärderas.

Om *items* blir kvar minskas nästa sprint. Teamets produktionsförmåga kallas **velocity**.

![Scrum](agile-scrum.png)

---

### Definition of Done (DoD)

För att veta när något är färdigt måste alla vara överens om vad som räknas som *klart*.  
Exempel: alla tester körda, kod granskad och godkänd i *code review*.

Det viktigaste är att alla, inklusive PO, förstår vad kriterierna innebär.

![DoD](geek-poke-doad.jpg)

---

### Story Points

Story points används för att uppskatta *storlek* och *komplexitet* snarare än tid.  
Planning poker är en metod för att gissa hur stora uppgifter är:

| Kort | Beskrivning |
|------|--------------|
| `0` | Redan färdig eller ogiltig |
| `1/2`, `1`, `2`, `3`, `5`, `8`, `13` | Poängnivåer |
| `20`, `40`, `100`, `?` | För stor för uppskattning / kräver förarbete |
| ☕️ | Trött – ge mig kaffe! |

Det finns även andra skalor som t-shirt-storlek (`XS`–`XL`).

![Planning Poker](agile-planning-poker.jpg)

---

### Velocity

Teamets **velocity** är antalet färdiga *items* (enligt DoD) per sprint.  
Det används för att planera framtida sprintar, skapa *burn down charts* och uppskatta projektets slutdatum.

Idén är att lära av tidigare sprintar istället för att gissa framåt.

---

### Code Review / Kodgranskning

Kodgranskning används för att hitta fel tidigt.  
När en *item* flyttas från *doing* till *done* bör en kollega granska koden.

Förslag på process:

1. Utvecklaren visar sina ändringar och commit-meddelanden.  
2. Kollegan ställer frågor och letar fel.  
3. Hittas fel flyttas itemen tillbaka till *doing*.

Kodgranskning kan även ingå i DoD och stärker teamets förståelse.

---

## Uppgifter 1 – Agila metoder

Förklara följande med egna ord. Håll det kort och koncist:

- Vad är en sprint?  
- Roller i Scrum: `Product Owner`, `Scrum Master`, `Scrum Team`  
- Vad är en `product backlog item` och varför används de?  
- Vad är `product backlog` och `sprint backlog`?  
- Vad är `minimum viable product (MVP)`?  
- Vad betyder `definition of done (DoD)`?  
- Vad innebär det att arbeta agilt – kultur, metod eller krav?  
- För- och nackdelar med Scrum jämfört med Kanban.  
- Hur skulle ni vilja lägga upp nästa projekt?  
- Tankar om vattenfallsmetoden?

---

## Uppgift 2 – Agila metoder

Utveckla era svar från uppgift 1. Fokus: diskussion och reflektion.

- [Kort repetition](https://www.youtube.com/watch?v=1iccpf2eN1Q)  
- Varför behövs både *product backlog* och *sprint backlog*?  
- Varför "lägger sig inte produktägaren i under sprinten"?  
- När kan en *feature* räknas som färdig (DoD)?  
- Vill ni arbeta mer som Scrum eller Kanban i nästa projekt?  
- Vad betyder det i praktiken att vara *agil* och *flexibel*?  
- Se: [Changed mindset-video](https://www.youtube.com/watch?v=J9UjD_cKpnc)  
  _“Changed mindset. From: A → B → C → done. To A → B → C → learn → repeat.”_  
  Diskutera vad han menar.  
- Hur skulle ert arbete se ut om ni tvingades arbeta enligt vattenfallsmodellen?  
- Hur kan ni använda *code review* i era projekt?  
- Andra funderingar om *agile*? Nya lärdomar?

---

## Uppgift 3 – Agila metoder

### Läs

- [A Short Story About a Scrum Team – Amazing Outcomes](https://amazing-outcomes.de/en/blog/a-short-story-about-a-scrum-team) 📖  
- [Scrum glossary – scrum.org](https://www.scrum.org/resources/scrum-glossary) 📖  
- [Agile glossary – Agile Alliance](https://www.agilealliance.org/agile101/agile-glossary/) 📖  

Plocka ut fem ord eller koncept du visste minst om, läs på och sammanfatta.
