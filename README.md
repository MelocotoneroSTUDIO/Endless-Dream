# Endless-Dream

## 0. HISTORIAL DE VERSIONES

## 1. INTRODUCCIÓN 

Sirva este documento como escrito en el que se recogen todas las directrices relacionadas con el *Game Design* y la producción de *Endless Dream*, videojuego de puzles y plataformas 3D desarrollado por *Melocotonero Studio*.

En *Endless Dream* se controlará a un pequeño ser, el cual trata ser la personificación del subconsciente en el mundo de los sueños. Se deberá pasar una serie de niveles temáticos en función de lo que sueña el protagonista y cada uno dispondrá de una serie de mecánicas que se han de combinar para poder superar el nivel con éxito con la premisa que hace especial a este videojuego de plataformas, **no se puede saltar**.

El objetivo principal de Melocotonero Studio con este videojuego es crear una herramienta capaz de ayudar a los más pequeños a desarrollar una serie de habilidades entre las que se encuentran:
- **Reconocer elementos clave en un problema:** Al tener que descubrir cuáles son las mecánicas claves en cada nivel y qué cosas son interactuables.
- **Descomposición de problemas en otros más pequeños:** Por las mecánicas combinadas.
- **Deducción:** Al tener que buscar una solución a cada uno de los niveles y ver qué interacciones benefician y cuáles no.
- **Decidir sobre el buen uso de recursos:** Cómo gestionar.
- **Resolver problemas basándose en soluciones anteriores:** Al repetir mecánicas de niveles anteriores.

Además, buscamos poder monitorizar los resultados obtenidos para recabar información útil y poder realizar una serie de estudios en base a la educación, habilidades y facultades de cada alumno. Aún así, para poder generar mayores ingresos, pese a que el objetivo principal es el comentado, tratamos de realizar un videojuego apto para todos los públicos y que puedan disfrutar todas las edades, realizando un diseño y gameplay minimalista pero que sea atractivo y divertido para todos.

En cuanto a las plataformas, principalmente se busca desarrollarlo para **móviles y pc** haciéndolo funcionar tanto por descarga del mismo (aplicación móvil), como por páginas web, labor que facilitará su venta y distribución a las aulas y cuya información se extenderá más adelante en el modelo de negocio.

Al tratarse de un documento vivo, ciertos contenidos pueden verse afectados/actualizados a medida que se va desarrollando el videojuego, todos los cambios en relación a versiones anteriores, serán notificados en el apartado 0. HISTORIAL DE VERSIONES.

## 2. FICHA TÉCNICA

| Título  | Endless Dream |
|  :---:   |  :---:   |
| Desarrolladora | Melocotonero Studio |
| Mótor Gráfico  | Unity |
| Equipo de desarrollo | **Aisayan Jiménez Viera:** Project Manager, Programador y Game Designer, **Víctor Cabanillas Solís:** Lead Programmer, **Nerea Díaz Jérica:** Game Designer y Concept Artist, **Rosa Suffo García:** Artista 3D, **Adriana Sánchez Illán:** Artitsta 3D, **Jorge Sanz Coronel:** Programador y efectos de sonido |
| Género  | Plataformas 3D, puzzles |
| Plataformas objetivo | PC, dispositivos móviles y páginas Web |
| Estilo gráfico  | Estilizado (simulación de trazos) |
| Ambientación  | Fantasía, mundo de los sueños |
| Sinopsis  | Evadiendo el mundo real, supera los distintos mundo que trae este sueño sin fin. |
| Elevator pitch  | *¿Cansado de que los videojuegos solo se centren en la diversión?* En el maravilloso mundo de Endless Dream te enfrentarás a una serie de desafíos en mundos de ensueño que te ayudarán a evadirte de la realidad y dar rienda suelta a tu imaginación, pero no solo eso. Juega y diviértete a la vez que desarrollas una serie de capacidades cognitivas y además, podrás medir tus capacidades, poniéndote a prueba en cada nivel. Aquí no hablamos de edades, sino de disfrutar desde los más pequeños hasta los más grandes. |

## 3. HERRAMIENTAS DE DESARROLLO
En este apartado se exponen las herramientas utilizadas a lo largo del desarrollo de Endless Dream y para qué se han utilizado. Se clasifican en los 3 campos esenciales en los que se divide el desarrollo de un videojuego: 

### 3.1. Herramientas de diseño
- **Blender:** Dedicado especialmente al modelado, iluminación, renderizado, la animación y gráficos tridimensionales, es utilizado para la creación de los mundos en 3D y del personaje.
- **Photoshop:** Programa de Adobe que ha sido utilizado para la creación de los concepts del personaje e items que encontramos a lo largo del juego.
- **Clip Studio Paint:**  Aplicación de ilustración utilizada para los concepts del mundo.
- **Procreate:** Con una funcionalidad parecida a la de Clip Studio Paint pero perteneciente a IOS, se ha utilizado para la creación de las interfaces.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/1.png)

### 3.2. Herramientas de programación y montaje del videojuego
- **Unity:** Motor de videojuego multiplataforma creado por Unity Technologies. Es el principal foco de trabajo del videojuego.
- **C#:** Lenguaje de programación del videojuego que viene asociado a Unity.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/2.png)

### 3.3. Herramientas de creación de los efectos de sonidos y música:
- **Audacity:** Editor de sonidos utilizado para la creación de los efectos de sonido.
- **LMMS Studio:** A diferencia de audacity, está especializado en la creación de música.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/3.png)

## 4. METODOLOGÍA
Al tratarse de la ejecución de un videojuego y por lo tanto de un proyecto software, el equipo en su conjunto decidió optar por utilizar SCRUM y KANBAN como metodologías ágiles a poner en práctica. 
En cuanto a las herramientas utilizadas para la organización del trabajo, se ha utilizado Trello para gestionar las distintas tareas del proyecto siguiendo la premisa del:
- **DO:** Tareas por hacer
- **DOING:** Tareas en Curso
- **DONE:** Tareas finalizadas
Trello ha sido elegido frente a cualquier otra herramienta de gestión de proyectos (Jira, Confluence…) ya que todos los miembros del estudio lo conocen, es completamente gratuita y, además, muy visual y sencilla de utilizar.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/4.png)

Aparte de utilizar simplemente Trello (Véase “Imagen 4”) con su respectiva repartición de tareas, se han utilizado distintas técnicas de SCRUM para agilizar el proceso de desarrollo del proyecto.
Lo más común eran las Dailys, reuniones que realizamos varias veces por semana y en la que exponemos cuánto trabajo hemos avanzado individualmente, además comentamos que es lo siguiente que vamos a desarrollar y proponemos ciertas horas de trabajo conjunto por Teams o de manera presencial, sobre todo para aquellos casos en los que se necesitan juntar los resultados de los distintos campos de un videojuego. 
Además de los Dailys,  se hizo una pequeña selección de distintas técnicas probando cuál puede venirle mejor al equipo (conocido también como Cherry Picking). De esta manera, se decidió comenzar a usar la estimación de tareas Punto-Historia, en la que se comenzó a puntuar las tareas en función de las horas y complejidad que conllevan. Sin embargo, ya que con las reuniones se tiene claro cuál va a ser la próxima tarea a realizar y las fechas en las que tenían que ser realizadas, se optó por dejar de utilizar dicha técnica. 

### 4.1. Roles del equipo
Para finalizar con este apartado, cabe destacar cuáles con los roles específicos de cada miembro y su división:
- **Portavoz:** Encargado de la comunicación sobre los problemas surgidos y de comunicarse con el resto de entidades. 
- **Organizadores/Equipo de dirección :** Encargados de la planificación del trabajo, así como de la comprobación de que todas las tareas se van realizando con éxito y en el tiempo acordado. 
- **Redactores:** Encargados de la redacción final del GDD, de su maquetación y revisión..
- **Diseñadores UI:** Encargados del diseño de las interfaces.
- **Concept Artist:** Parte artística 2D del videojuego (personajes y mundos).
- **Modeladores 3D:**  Creación de los escenarios y personajes 3D.
- **Programadores:** Encargados de todo lo relacionado con la programación del videojuego.
- **Efectos de sonido y música:** Encargados de toda la parte acústica del videojuego.
- **Game & Level Design:** Encargados de la creación de los niveles y ambientación del videojuego.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/5.png)

## 5. INFLUENCIAS PARA EL DESARROLLO DE ENDLESS DREAM
Como ya se ha comentado con anterioridad, pese a que *Endless Dream* es un videojuego original creado y desarrollado por *Melocotonero Studio*, existen una serie de influencias que nos han ayudado a diseñar todo el mundo y las mecánicas que lo engloban. Antes de comenzar a hablar de factores de diseño como los personajes o las mecánicas, es de suma importancia visualizar cuáles han sido las principales referencias y sobre todo, saber de qué nos hemos nutrido de cada una de ellas:

### 5.1. Capitan Toad
*Capitán Toad* es un juego de rompecabezas y plataformas que fue desarrollado y publicado por Nintendo exclusivamente para la consola Wii U. Este título es un spin-off de la exitosa franquicia Mario y se originó a partir de un minijuego que hizo su debut en *Super Mario 3D World*. En este juego, los jugadores asumen el control del intrépido capitán Toad, quien se enfrenta al desafío de navegar de manera segura a través de una serie de obstáculos con el objetivo de alcanzar una codiciada estrella de oro al final de cada nivel. Lo que hace que Capitán Toad sea verdaderamente singular es la premisa de que este personaje **no puede saltar**, lo que añade un toque distintivo a las mecánicas de juego.
Este título se convierte en nuestro principal referente en términos de mecánicas, ya que presenta un mundo en 3D con dimensiones reducidas, lo que permite a los jugadores visualizar todo el nivel de un vistazo. Esta característica única, junto con la prohibición de saltar, desafía a los jugadores al requerir una gestión cuidadosa de recursos y la exploración minuciosa del entorno para identificar los elementos interactivos clave que les permitirán superar con éxito cada nivel (véase IMAGEN 6).
Es importante recordar que, más allá de ser simplemente un videojuego, estamos desarrollando una herramienta que tiene como objetivo ayudar a los más jóvenes a desarrollar una serie de habilidades, como se detalla en la introducción. Por lo tanto, la restricción del salto, combinada con otras mecánicas adicionales que se explorarán en secciones posteriores, amplía significativamente nuestras posibilidades para diseñar rompecabezas funcionales que cumplan con este propósito educativo.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/6.png)

### 5.2. Monument Valley
Se trata de un juego de rompecabezas independiente desarrollado y publicado por Ustwo Games. En este juego, los jugadores acompañan a la princesa Ida a través de intrincados laberintos llenos de ilusiones ópticas y objetos aparentemente imposibles, mientras manipulan el entorno que la rodea para alcanzar distintas plataformas.
Lo que nos ha impresionado como estudio, y lo que nos ha llevado a considerarlo como una referencia fundamental al crear Endless Dream, es el sorprendente arte minimalista que presenta (véase IMAGEN 7). Además, es digno de destacar que este juego ha sido diseñado específicamente para dispositivos móviles y tabletas, lo cual coincide con nuestro cometido en cuanto a las plataformas de desarrollo. Como mencionamos anteriormente, nuestro objetivo es crear un videojuego que atraiga a una amplia audiencia, no solo a niños, pese a que sean el público objetivo. Por lo tanto, la elección de un estilo minimalista para la creación de escenarios y personajes no sólo resulta atractiva para los más jóvenes, sino que, si se maneja con esmero, puede ser apreciada por un público de todas las edades, evitando ser percibida como una estética infantilizada.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/7.png)

Este enfoque, que también es evidente en otros juegos como Hollow Knight (véase IMAGEN 8), demuestra que un estilo visual llamativo para los niños puede, al mismo tiempo, ser una opción atractiva y válida para un público adulto.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/8.png)

