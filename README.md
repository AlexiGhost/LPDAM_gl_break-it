# lp_gl_break-it
Projet du module de génie loigiciel, création d'un casse-brique.

## Accroche du projet
Tu t'ennuie dans l'avion ? Tu cherches à faire passer le temps ? Breat It est fait pour toi ! Un jeu de casse brique hors du commun qui sera t'occuper pendant plusieurs heures grâce aux différents niveaux dont il est composé ! 
## Nom des etudiants
- COURIEUX Alexi
- DEMMER Lisa-Marie
- FOURNIER Nathan
## Modeles d'analyses
- [Diagramme de blocs](https://github.com/AlexiGhost/lp_gl_break-it/blob/master/Documentation/Diagrammes/Diagramme_de_blocs.pdf)
- [Diagramme de séquence](https://github.com/AlexiGhost/lp_gl_break-it/blob/master/Documentation/Diagrammes/Diagramme_de_sequence.pdf)
- [Diagramme des cas d'utilisation](https://github.com/AlexiGhost/lp_gl_breakit/blob/master/Documentation/Diagrammes/Diagramme_de_cas_d_utilisation.pdf)
## Exigences
### Jouer
- Description: On doit pouvoir jouer au jeu 
- Id: 100
### Déplacer la plateforme
- Description: On doit pouvoir déplacer la plateforme pour pouvoir jouer au jeu
- Id: 110
### Casser des briques
- Description: Le joueur doit pouvoir casser des briques pour terminer le niveau
- Id: 120
## Maquettes
Les maquettes sont accessibles [ici](https://github.com/AlexiGhost/lp_gl_break-it/tree/master/Documentation/Maquettes).
Deux versions sont disponibles, la version image ou la version navigateur.
La version navigateur est consultable depuis n'importe quel naviguateur récent tel que Chrome ou Mozilla Firefox et est interactive.
> Le menu pause s'affiche si vous appuyez sur echap depuis la maquette de jeu.
## Technologies utilisées
On utilise Unity avec le langage CSharp car Unity est un outil pour créer des jeux vidéos et qui permet de faire des applications disponible sur Android et Apple. L'avantage par rapport aux technologies natives et qu'on a pas de surcouche, on a accès directement aux fonctionnalités grâce au langage CSharp. De plus, les technologies hybrides ne serait pas très utiles car il y a peu de menu.
## Organisation du projet

### Politique des branches
Il y a 3 niveaux de branches
- La branche master, où tout le contenu devra avoir passé les tests unitaires et les test d'intégrations.
- La branche development, où les fonctionnalités ayant passé les test unitaires seront rassemblés afin d'effectuer des tests d'intégration.
- Les branches dédiées au développement d'une fonctionnalitée, elles seront assez instables et demanderons des tests plus avancés.
### Sprint (Milestone)
Les sprints sont regroupés [ici](https://github.com/AlexiGhost/lp_gl_break-it/milestones).
### Gestion des tests
Les tests sont gérés grâce à un outil inclus dans Unity3D : TestRunner. Cet outil permet de créer un fichier de test, et de lancer tout les tests en même temps.
### Politique d'intégration continue
Utilisation de Travis CI afin d'effectuer les test de compilation.
### Boards
Le board principal peux être trouvé [ici](https://github.com/AlexiGhost/lp_gl_break-it/projects/1)
