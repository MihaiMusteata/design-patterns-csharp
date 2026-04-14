# Singleton Pattern

## Definiție
Pattern-ul `Singleton` este un pattern creațional care garantează că o clasă are o singură instanță și oferă un punct global de acces la aceasta.

## Implementare în proiect
În acest proiect, clasa `Singleton` are constructor privat, păstrează instanța într-un câmp static și expune metoda `GetInstance(...)` pentru acces controlat. S-a păstrat structura inițială a codului, cu o ajustare mică pentru a evita warning-urile și pentru a evidenția mai clar comportamentul singleton-ului.

## Diagramă UML
![Singleton UML](singleton.png)

## Avantaje și dezavantaje

| Avantaje | Dezavantaje |
| --- | --- |
| Asigură existența unei singure instanțe pentru o clasă. | Introduce stare globală în aplicație. |
| Oferă acces global controlat la instanță. | Poate face testarea mai dificilă. |
| Poate economisi resurse când același obiect trebuie partajat. | Ascunde dependențele reale dintre clase. |
| Este util pentru configurări sau servicii globale. | Dacă este folosit excesiv, crește cuplarea între componente. |

## Domenii de aplicare
- Configurații globale ale aplicației.
- Logging centralizat.
- Manageri de cache.
- Conexiuni sau servicii partajate.
- Coordonatori care trebuie să existe o singură dată în aplicație.
