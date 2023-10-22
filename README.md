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

## 6. MODELO DE NEGOCIO

Una de las fases más importantes a la hora de realizar y rentabilizar un producto software es el correcto desarrollo de un buen modelo de negocio. Desde el comienzo de este documento, se ha dejado claro que se va a desarrollar un videojuego pero, ¿cómo de rentable es?
La industria del videojuego ha experimentado una evolución significativa a lo largo de las décadas y se ha convertido en una de las industrias de entretenimiento más rentables del mundo superando incluso a la del cine. Tiene como origen los años 70 y 80 donde nacieron las salas recreativas, a partir de ahí ha crecido exponencialmente llegando al punto en el que tan solo en España, en el año 2022 recaudó un total de 2.012 millones de euros, un 12,1% más que el año anterior y el doble que en 2014 (referencia tomada del Informe Anual de la Asociación Española de Videojuegos (AEVI)).
La rentabilidad de un videojuego se basa en los siguientes puntos:
- **Gran audiencia:** Tienen un amplio alcance hacia todo tipo de públicos.
- **Innovación tecnológica:** La industria está en constante evolución.
- **Modelos de negocio flexibles:** Se pueden optar por diversos modelos de monetización, adaptados a los objetivos y la audiencia.
- **Comunidad y compromiso:** Los juegos en línea fomentan la interacción y el compromiso a largo plazo de los jugadores.
- **Exportación global:** Los videojuegos pueden ser exportados a nivel mundial.
- **Cultura y entretenimiento:** Se han convertido en una parte integral de la cultura popular y el entretenimiento, lo que aumenta su demanda. 
En resumen, la industria del videojuego ha evolucionado enormemente a lo largo de los años debido a la innovación tecnológica y la diversificación de los modelos de negocio. La rentabilidad se deriva de su capacidad para atraer a una amplia audiencia, su adaptación constante a nuevas tecnologías y su capacidad para ofrecer experiencias de entretenimiento inmersivas y atractivas por lo tanto, SÍ es rentable realizar un videojuego siempre y cuando se planifique de manera correcta un buen modelo de negocio.
Una vez introducido el punto y contestada la pregunta respecto a la rentabilidad, a continuación se abordarán una serie de puntos en relación a dos grandes pilares:
- **Perfil de los clientes:** Se hablará de los dos grande sectores en los que se divide nuestro público objetivo y se mostrarán sus respectivos mapas de empatía
- **Plan de monetización:** Se mostrará el lienzo del modelo de negocio y se comentarán cada uno de sus puntos de forma detallada.

### 6.1. Perfil de los clientes

Explorar el perfil de los clientes es algo fundamental para el éxito de cualquier negocio. A lo largo de este apartado nos sumergimos en la comprensión detallada de quiénes son nuestros clientes ideales, qué los motiva y cómo satisfacer sus necesidades. El conocimiento profundo de este perfil es la brújula que guía nuestras estrategias de marketing, desarrollo de productos y servicio al cliente. En un mundo en constante evolución, adaptarnos a las demandas y expectativas de nuestros clientes es esencial.
A lo largo de todo el documento se han diferenciado y reconocido dos sectores de público objetivo:

#### 6.1.1. Primer sector: Educación
Nuestro principal público objetivo para este videojuego, en una primera instancia, se centra en la Consejería de Educación. Nuestra intención es que este videojuego se convierta en una valiosa herramienta para enseñar el pensamiento computacional a niños pequeños, fomentando el desarrollo de habilidades esenciales como: 
- **Reconocimiento de elementos clave en un problema:** Los jugadores deben descubrir las mecánicas esenciales en cada nivel y determinar qué elementos son interactuables.
- **Descomposición de problemas en componentes más manejables:** Esto se logra a través de la combinación de diversas mecánicas de juego.
- **Deducción:** Los niños deben buscar soluciones a cada nivel y discernir qué interacciones son beneficiosas y cuáles no.
- **Toma de decisiones sobre la gestión de recursos:** Aprender a administrar recursos de manera efectiva es una habilidad esencial que este juego promueve.
- **Resolución de problemas basándose en soluciones previas:** Los jugadores aplican mecánicas aprendidas en niveles anteriores para superar desafíos más avanzados.	
En lugar de enfocarnos exclusivamente en comprender las necesidades y comportamiento de los niños, creemos que es fundamental desarrollar el perfil de los profesores. El motivo radica en que son estos educadores quienes distribuirán y utilizarán esta herramienta en las aulas, y, en muchos casos, quienes la financiarán, con especial atención a la propia Consejería de Educación. Una vez planteado el perfil de este tipo de clientes obtenemos el siguiente mapa de empatía (véase IMAGEN 9), herramienta visual utilizada en el ámbito del diseño de productos, marketing y desarrollo de negocios para comprender y profundizar en la experiencia y perspectiva de los clientes o usuarios.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/9.png)

Una vez completado el mapa de empatía y, como conclusión de esta primera etapa enfocada en comprender un segmento específico de nuestro público objetivo, hemos identificado las siguientes características:
- Nuestro enfoque se dirige hacia profesores que están en búsqueda de nuevas herramientas de enseñanza.
- Estos profesores perciben que los métodos tradicionales están perdiendo efectividad, ya que sus alumnos muestran cada vez menos interés y atención.
- Están motivados a innovar en el entorno de sus aulas y desean aprovechar sus propios intereses y pasatiempos como instrumentos educativos.
- La búsqueda se centra en herramientas que puedan mejorar las habilidades de sus estudiantes de manera efectiva.
- A pesar de su deseo de brindar atención individualizada a cada alumno, a menudo se ven limitados por la falta de tiempo.
En resumen, nuestro cliente ideal en este primer segmento es un profesor que busca renovar sus métodos de enseñanza, considera que los videojuegos pueden ser una forma sencilla de atraer y comprometer a sus alumnos, y tiene el objetivo de promover el desarrollo de habilidades de manera indirecta a través de esta estrategia.

#### 6.1.2. Segundo sector: Jugadores Casual

Para este segundo sector comentar muy brevemente que pese a desarrollar una herramienta enfocada a la educación, también estamos trabajando con un videojuego por ello no debemos olvidar a una parte importante de nuestro público objetivo, los jugadores casual, por los siguientes motivos:
1. Como empresa buscamos aumentar las ganancias todo lo posible y ya que desarrollamos un videojuego de plataformas, esto servirá para atraer a jugadores de topo tipo.
2. Los jugadores más expertos nos van a ayudar mucho con el desarrollo del videojuego a nivel de testeo.
En referencia al segundo punto,  Melocotonero Studio pretende seguir tanto las directrices de la consejería de educación como principal público y foco de financiación pero también, pretende acercarse a todo tipo de jugadores con los cuáles tendremos cierto acercamiento en redes para conseguir feedback útil de cara al desarrollo.
Una vez establecido estos puntos y conociendo a este segundo sector, obtenemos el siguiente mapa de empatía (véase IMAGEN 10).

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/10.png)

A modo de resumen, nuestro cliente ideal para este segundo sector sería un jugador de videojuegos al que le gusten los nuevos retos y busque alguna manera de entrenar la mente como hobbie.

#### 6.1.3. Arquetipos de usuario

Una vez hemos definido ambos sectores, a modo de finalización en cuanto a la información de nuestro público objetivo, cabe destacar cuáles son los arquetipos de usuarios posibles:

##### 6.1.3.1. Arquetipos del primer sector:

Identificamos varios perfiles de usuarios en nuestra exploración:
- **Profesor Tradicional:** Este grupo incluye a los profesores que prefieren seguir métodos de enseñanza convencionales y no tienen un interés particular en los videojuegos.
- **Profesor Innovador:** Estos docentes buscan enriquecer sus prácticas pedagógicas con herramientas novedosas, pero no sienten una afinidad especial hacia los videojuegos.
- **Profesor Gamer Tradicional:** Este segmento está formado por profesores que siguen enfoques de enseñanza tradicionales en el aula, pero disfrutan de los videojuegos en su tiempo libre.
- **Profesor Gamer Innovador:** Estos educadores no solo buscan innovar en sus métodos de enseñanza, sino que también son entusiastas jugadores de videojuegos en su tiempo libre, fusionando sus dos pasiones de manera efectiva.
Este análisis nos proporciona una visión más completa de los distintos enfoques y actitudes de los profesores con respecto a la integración de los videojuegos en el entorno educativo.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/11.png)

##### 6.1.3.1. Arquetipos del segundo sector:

En cuanto a la identificación de los arquetipos de este sector, el enfoque va más generalizado:
- **El Jugador Casual:** Este tipo de jugador busca una experiencia de juego relajada y ocasional. Puede no estar muy involucrado en los aspectos competitivos y prefiere disfrutar del juego de manera informal.
- **El Speedrunner:** Los speedrunners son jugadores que buscan completar el juego lo más rápido posible. Les gusta optimizar sus movimientos y conocer a fondo el juego para establecer récords de velocidad.
- **El Coleccionista:** Estos jugadores se enfocan en recolectar todos los objetos, secretos y logros en el juego. Les gusta explorar minuciosamente cada nivel en busca de tesoros y desafíos ocultos.
- **El Competitivo:** Este jugador busca desafiar a otros jugadores en modos multijugador o competir por las puntuaciones más altas en las tablas de clasificación. Valora la habilidad y la competencia.
Al tratarse de un perfil mucho más genérico, cada uno de los arquetipos propuestos serían ideales como clientes aunque en este caso destacaremos el jugador casual como arquetipo ideal (véase IMAGEN 12).

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/12.png)

### 6.2. Plan de monetización
Esta última sección del modelo de negocio la dividiremos en dos partes:
1. Mostraremos los principales stakeholders de la empresa y las relaciones a través del método de la caja de herramientas.
2. Mostraremos y explicaremos brevemente cada una de las secciones del modelo de canvas en referente al modelo de negocio final de videojuego.

#### 6.2.1. Caja de herramientas
Esta herramienta se basa en mostrar cuáles son los principales stakeholder de la empresa, es decir, aquellos bloques de interacción más relevantes, y cuáles son las interacciones.
En cuanto a los stakeholders que interactúan con Melocotonero Studio tenemos:
- **Proveedores:** Unity es un ejemplo destacado en esta categoría. Obtener acceso a su motor nos permite crear y desarrollar nuestros videojuegos. A cambio, a partir de un cierto número de descargas, Unity obtiene beneficios monetarios.
- **Distribuidores:** Estos son socios estratégicos que nos ayudan a poner nuestros videojuegos en plataformas populares como Steam. Ofrecemos nuestros videojuegos, lo que les permite generar ingresos, mientras nosotros obtenemos visibilidad y una plataforma efectiva de distribución.
- **Consumidores:** Este grupo está compuesto principalmente por jugadores casuales. Nuestra relación con ellos es directa: proporcionamos un producto y, a cambio, recibimos beneficios monetarios.
- **Inversores:** Referidos a la consejería de educación, nosotros le ofrecemos una herramienta nueva junto a todo su desarrollo y mantenimiento y a cambio nos ofrecen ayuda y dinero.
- **Prensa:** Los medios de comunicación y la prensa juegan un papel importante al recibir nuestros productos y darles cobertura. A cambio, obtenemos publicidad y, a menudo, un incremento en la visibilidad de nuestros videojuegos.
Para una visualización mucho más gráfica de los stakeholders y las relaciones comentadas véase IMAGEN 13.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/13.png)

#### 6.2.2. Lienzo del modelo de negocio

El Lienzo del Modelo de Negocio se erige como una herramienta versátil que desempeña un papel fundamental en el desarrollo de estrategias, la planificación empresarial y el análisis de modelos de negocio preexistentes. Facilita a las empresas la capacidad de visualizar con precisión cómo cada componente de su operación se entrelazan para engendrar valor y fomentar el flujo de ingresos. Este lienzo se compone de nueve bloques cruciales, y es precisamente por esta razón que para finalizar con este gran apartado, nos adentraremos en el desarrollo de cada uno de estos bloques, ya que lo consideramos la herramienta más eficaz para el sólido desarrollo de un buen modelo de negocio.

##### 6.2.2.1. Socios claves
- **Nuestros Socios Clave:**
En nuestro entorno de colaboración, destacan la Consejería de Educación y el sector educativo, quienes desempeñan un papel fundamental al proporcionar el financiamiento necesario para la realización del proyecto al integrarlo en sus programas educativos. Además, establecemos colaboraciones estratégicas con empresas de distribución y fabricantes de productos relacionados con el videojuego.
- **Proveedores Clave:**
En el contexto de la creación de un videojuego, los proveedores de materias primas desempeñan un papel secundario, ya que la materia prima no es un componente principal. Sin embargo, las distribuidoras de videojuegos adquieren un rol esencial al encargarse de la distribución y comercialización de nuestros productos.
- **Recursos Clave adquiridos de Socios Clave:**
De nuestros socios clave, adquirimos un motor de desarrollo que optimiza nuestra eficiencia en la creación del videojuego. Además, las empresas de distribución y los fabricantes de productos relacionados con el merchandising, contribuyen significativamente, ampliando nuestra gama de recursos con productos afines.
- **Actividades de Socios Clave:**
Nuestros socios clave desempeñan una función crítica al colaborar en la supervisión y evaluación del proyecto a través de métricas bien definidas. Trabajamos en estrecha colaboración con expertos de diversos campos, incluyendo psicólogos, para garantizar que el videojuego efectivamente fomente el desarrollo de habilidades cognitivas en los jóvenes.

##### 6.2.2.2. Actividades clave
Establecer comunicación con la Consejería de Educación con el propósito de promover la adopción de nuestro producto en las aulas, buscando, además, la posibilidad de obtener financiamiento por parte de dicha entidad.

##### 6.2.2.3. Recursos clave
¿Qué recursos clave necesita nuestra propuesta de valor?
Principalmente, necesitamos asegurar la financiación necesaria para el desarrollo del proyecto a través de la colaboración con la consejería de educación.

##### 6.2.2.4. Propuestas de valor
- **¿Qué valor estamos entregando a nuestros clientes?**
Ofrecemos un producto de alta calidad que no solo brinda entretenimiento, sino que también sirve como una valiosa herramienta para medir y fomentar el desarrollo de habilidades esenciales en los más jóvenes.
- **¿Qué problema estamos resolviendo?**
En el sector educativo, abordamos la falta de atención y recursos dedicados al desarrollo de habilidades en los niños. Asimismo, en el ámbito de los jugadores casuales, proporcionamos una nueva forma de entretenimiento que se adapta a sus necesidades y tiempos.
- **¿Qué necesidad estamos satisfaciendo?**
Atendemos la necesidad de incorporar el potencial educativo de los videojuegos de una manera que no parezca un típico videojuego educativo, ofreciendo una solución innovadora en el ámbito de la educación.
- **¿Qué tipo de productos ofrecemos a nuestros clientes?**
Proporcionamos una gama de nuevos videojuegos, y estamos preparados para desarrollar contenido adicional a medida que se requiera, con el fin de mantenernos alineados con las necesidades cambiantes de nuestros clientes.

##### 6.2.2.5. Relación con el cliente
Utilizamos las redes sociales como un canal cercano para interactuar con nuestros clientes, realizando encuestas que nos ayudan a comprender y optimizar ciertos aspectos del diseño de nuestros productos.
En el ámbito de la educación, adoptamos un enfoque más formal a través de plataformas como Teams. Dado el contexto educativo, garantizamos una comunicación seria y profesional para atender las necesidades específicas de nuestros clientes en este sector.

##### 6.2.2.6. Canales
- **Marketing a través de medios de difusión en redes sociales:** Utilizamos estrategias de marketing en las redes sociales para llegar a nuestros clientes y mantenerlos informados.
- **Tiendas en línea y sitios web:** Nuestra presencia en línea se extiende a tiendas y páginas web, donde los clientes pueden acceder a nuestros productos y obtener información detallada sobre ellos.
- **Reuniones y llamadas a través de Teams (en el sector educativo):** Para atender de manera efectiva las necesidades del sector educativo, empleamos reuniones y llamadas a través de Teams, proporcionando un canal de comunicación serio y enfocado en este ámbito.

##### 6.2.2.7. Segmento de cliente
- **¿Para quién estamos creando valor?**
Como estudio indie de videojuegos, creamos valor en primer lugar para los propietarios del estudio al generar ganancias sostenibles. Adicionalmente, brindamos valor a los profesores y al sistema educativo al ofrecerles una herramienta útil y educativa. Asimismo, nuestro valor se extiende a personas de todas las edades que disfrutan de los videojuegos, al proporcionarles un nuevo y emocionante juego para su entretenimiento.
- **¿Quiénes son nuestros clientes más importantes?**
Nuestros clientes más importantes son los profesores de todo el mundo, cuya adopción de nuestro producto en entornos educativos es fundamental. Además, nuestros jugadores casuales son esenciales, ya que continuamente les ofrecemos contenido nuevo, manteniendo su interés y satisfaciendo sus necesidades de entretenimiento en constante evolución.

#####6.2.2.8. Estructura de costos
- **Costos fijos:** Incluyen pagos a empleados, impuestos, gastos de comercialización, licencias de programas, equipos (ordenadores) y gastos administrativos. Estos costos son constantes y necesarios para el funcionamiento de la empresa.
- **Costos variables:** Comprenden gastos como mantenimiento o reparación de equipos, mano de obra adicional (distribuidoras), inversión en marketing (anuncios pagados) y suministros adicionales según sea necesario. Estos costos varían en función de las necesidades operativas y las demandas del mercado.
En cuanto a los costos más significativos, los costos fijos son cruciales, ya que representan la base financiera para llevar a cabo el proyecto, el cual busca ser financiado por la Consejería de Educación.
Además, la actividad clave más costosa se relaciona con la elaboración de un sólido proyecto para asegurar la obtención de dicha financiación. Antes de lograrlo, planeamos iniciar una startup para avanzar en el desarrollo del videojuego destinado a jugadores casuales, lo que nos permitirá ganar una parte de nuestra audiencia objetivo de antemano.

##### 6.2.2.9. Fuente de ingresos
Nuestro modelo de financiamiento para el videojuego se basa en las siguientes fuentes:
- En primer lugar, buscamos obtener financiamiento de la Consejería de Educación o el Gobierno al presentar nuestro producto como una valiosa herramienta para su inclusión en las aulas, lo que constituye nuestra principal fuente de ingresos.
- Adicionalmente, esperamos generar ingresos a través de la venta directa del juego a jugadores casuales que deseen adquirirlo. También ofreceremos contenido descargable (DLC) y micropagos para la versión no educativa, diversificando nuestras fuentes de ingresos.
- Para iniciar el desarrollo del proyecto, contamos con una startup que respaldará financieramente esta etapa inicial.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/14.png)

## 7. MECÁNICAS
En un videojuego, las mecánicas representan uno de los pilares fundamentales del desarrollo. Comprenden todas las acciones llevadas a cabo por el jugador que tienen el poder de modificar el "estado del juego", es decir, la posición y las características específicas de todos los objetos y entornos en un momento particular del tiempo.
A lo largo de este amplio apartado, tocaremos una serie de puntos en relación a las acciones que puede realizar el jugador, la composición de los mundos e interacciones de Endless Dream:

1. **Tipo de cámara:** Se presentará una breve descripción de la posición de la cámara del jugador y se explicará la razón detrás de su disposición.
2. **Controles:** Se proporcionará una representación gráfica de los controles del videojuego, acompañada de comentarios explicativos.
3. **Métricas, puntuación y sistema de guardado:** Se abordará el tema de la medición de métricas discutidas en secciones previas, destacando su importancia para el desarrollo del pensamiento computacional a través del juego.
4. **Jugabilidad y curva de dificultad:** Se analizará la progresión de la dificultad a lo largo de los diferentes mundos y niveles del juego, describiendo cómo evoluciona la experiencia del jugador.
5. **Objetos interactuables e interacciones:** Se identificarán los principales elementos con los que el jugador puede interactuar y se explicará su función dentro del juego.

### 7.1. Tipo de cámara
Uno de los aspectos más destacados del diseño es la elección de la perspectiva de la cámara. En el caso de Endless Dream, hemos decidido utilizar una cámara en tercera persona donde se observa al personaje desde un punto de vista situado detrás y ligeramente por encima (véase IMAGEN 15) de este aunque, el jugador podrá realizar una serie de rotaciones laterales a la cámara para poder visualizarlo desde distintas perspectivas estando limitadas las rotaciones verticales ya que es el propio juego quien se encarga de seguir automáticamente al jugador en el eje Y. Ahora bien, ¿Por qué hemos tomado la decisión de utilizar esta perspectiva de cámara que es ampliamente reconocida en otros videojuegos?

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/15.png)

1. **Visión más completa:** La perspectiva en tercera persona proporciona una vista más completa del entorno del juego. Esto es particularmente beneficioso en juegos que requieren una conciencia espacial, exploración y resolución de rompecabezas. Los jugadores en Endless Dream, al tratarse de un videojuego de puzzles, van a tener una mejor comprensión de la disposición de los obstáculos, enemigos y elementos del juego, lo que facilita la toma de decisiones estratégicas.
2. **Atractivo visual y espectáculo:** La cámara en tercera persona a menudo se asocia con un mayor atractivo visual. El modo de construcción de escenarios en nuestro videojuego, está realizado de tal manera que sea disfrutable su visualización por lo tanto, la cámara en tercera persona hace que se pueda ver mucho mejor todas las partes del mapa en cada nivel.
3. **Conexión con el personaje:** La cámara en tercera persona permite una mayor empatía y conexión entre el jugador y el personaje que controla. Al tener una visión clara del personaje y su entorno, los jugadores pueden sentir una identificación más profunda, ya que pueden ver las acciones y reacciones del personaje en pantalla. Esta conexión emocional puede mejorar la inmersión y el compromiso del jugador.
En resumen, la elección de una cámara en tercera persona en un videojuego se basa en una combinación de factores que van desde la conexión emocional con el personaje hasta la jugabilidad, el estilo visual y la narrativa. Esta perspectiva ha demostrado ser una opción efectiva para proporcionar experiencias de juego envolventes y satisfactorias, y su popularidad continuará siendo sólida en el mundo del diseño de videojuegos.

### 7.2. Controles
Cuando se trata de los controles en Endless Dream, es importante considerar que el videojuego se está desarrollando para dos plataformas. Además, dado que el público objetivo son niños pequeños, hemos optado por mantener la simplicidad en las acciones del juego, evitando una sobrecarga de controles para poder enfocarnos en los aspectos previamente mencionados.
#### 7.2.1. Controles para PC
Para los controles en PC (véase IMAGEN 16) la disposición es la siguiente:
- WASD para el movimiento del personaje siendo W avanzar hacia delante del modelo del personaje, S hacia atrás, A hacia la izquierda y D hacia la derecha.
- El puntero del ratón será visible en el videojuego para PC por lo tanto, el click izquierdo del ratón será quien rote la cámara y ejecute las acciones de los items interactuables.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/16.png)

#### 7.2.2. Controles para móvil
Los controles para móvil (véase IMAGEN 17) son similares a los de PC con la diferencia que:
La rotación de la cámara y la ejecución de las interacciones con los distintos objetos se llevan a cabo de manera sencilla, simplemente tocando o deslizando el dedo por la pantalla. 
Para el movimiento del personaje, hemos implementado un joystick circular que permite desplazar al protagonista en todas las direcciones del escenario.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/17.png)


### 7.3. Métricas, puntuación y sistema de guardado
A lo largo de todo el documento, hemos abordado en varias ocasiones el enfoque que va más allá de ser simplemente un videojuego. Nuestra principal meta es desarrollar una herramienta destinada a ayudar a los niños a cultivar competencias cognitivas que desarrollen el pensamiento computacional. Además, buscamos medir una serie de métricas que serán de gran utilidad para el sector educativo, permitiéndoles llevar a cabo estudios más específicos, rápidos y eficaces sobre los alumnos.
Por lo tanto, en esta sección, además de explicar el sistema de guardado típico de un videojuego convencional, nos centraremos en la característica distintiva de nuestro videojuego: la medición de métricas.

#### 7.3.1 Sistema de guardado
El sistema de guardado se presenta de manera sencilla y se divide en dos enfoques:
1. **Versión Educativa:**
En la versión educativa, el sistema realizará guardados automáticos del progreso del juego al alcanzar logros, desbloquear objetos o completar niveles. Estos datos se almacenarán en la nube, ya que la versión educativa se centra en la gestión de cuentas y la integración con redes sociales.

2. **Versión Completa para Jugadores Casuales:**
En la versión completa dirigida a jugadores casuales, el guardado también es automático, pero los datos se guardarán localmente en el sistema en lugar de la nube. Esto se aplicará cuando se cumplan los mismos requisitos mencionados anteriormente.
Es importante señalar que la recolección de métricas se realizará exclusivamente en la versión educativa del juego.

#### 7.3.2 Puntuación
La puntuación es un elemento que el jugador podrá visualizar independientemente de otros sistemas de medición dentro del videojuego. Esta puntuación se centra en aspectos competitivos y se calculará y evaluará de la siguiente manera:
1. El jugador acumulará puntos en función de una regla que calcula la puntuación en intervalos de tiempo, basada en el tiempo que le lleve completar cada nivel.
2. Además, se sumarán puntos por recoger diversos objetos coleccionables esparcidos por los mapas en forma de monedas (véase IMAGEN 18). Cada nivel incluye una serie de elementos que el jugador podrá recolectar. Aunque no son esenciales para superar el nivel, su recolección desbloqueará elementos cosméticos, logros y aumentará la puntuación final.
Cada uno de estos elementos coleccionables otorgará 100 puntos adicionales, y en total, existen tres de ellos en cada nivel.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/18.png)

#### 7.3.3 Métricas
A lo largo de todo el documento, hemos estado haciendo un gran inciso en el sistema de métricas. Esta sección es un componente crítico en el desarrollo de nuestro videojuego puesto que en este apartado es donde delinearemos con detalle las distintas variables y datos que planeamos medir a lo largo de la experiencia de juego. Estas métricas son esenciales para evaluar el progreso del jugador, su nivel de compromiso, así como el impacto educativo de nuestro juego. No solo nos permitirá cuantificar el desempeño de los jugadores, sino también refinar y ajustar la experiencia de juego para lograr nuestros objetivos educativos. A continuación, exploraremos las métricas clave que rastrearemos y cómo estas se relacionan con nuestra visión de reforzar el pensamiento computacional de una manera atractiva y efectiva.
Ajustandonos a la siguiente tabla (véase IMAGEN 19):

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/19.png)

1. **Tiempo tardado:** Medir el tiempo que tardan los jugadores en superar un nivel para poder visualizar cómo de rápido desarrollan o tienen desarrolladas ciertas habilidades.
2. **Coleccionables recogidos:** Los distintos coleccionables mencionados en el apartado anterior harán que los jugadores cambien de objetivo, ajustándose a recorrer el mapa de distintas maneras en función de qué quieren conseguir antes de finalizar el nivel. 
3. **Objetos activables:** Dado que la métrica más crucial es la frecuencia de las interacciones del jugador, registraremos cuántas veces utiliza un objeto específico en el entorno. Esto nos permitirá evaluar la capacidad de deducción del jugador, y junto con esta métrica, se considerarán otras habilidades de gran importancia:
a. **Reconocer elementos claves en un problema:** Visualizando que items y zonas son interactuables.
b. **Decidir sobre el buen uso de recursos:** Habrá niveles en los que el jugador dispondrá de una serie de combinaciones limitadas para poder pasar el nivel con la mayor puntuación posible.
c. **Resolver problemas basándose en soluciones anteriores:** Al reciclar mecánicas en distintos niveles. 
d. **Identificación de patrones, conexiones, similitudes:** Igual que en el punto anterior, ver como volver a resolver el mismo problema con una mecánica nueva.
4. **Número de muertes:** Al igual que con el tiempo tardado, ayuda a visualizar la capacidad de deducción.

### 7.4. Jugabilidad y curva de dificultad
Al tratarse de un juego de puzles y plataformas, como diseñadores de niveles debemos mantener un equilibrio entre la diversión y el desafío sin olvidarnos quien es el público objetivo de nuestro videojuego. La curva de dificultad debe mantener a los jugadores comprometidos y motivados a medida que avanzan en el juego. 
Esta sección es crucial para garantizar que la experiencia de juego sea gratificante y accesible para una amplia audiencia, al tiempo que proporciona un desafío significativo para aquellos que buscan un puzle estimulante (haciendo inciso en esta parte en los jugadores más casual para que no parezca un videojuego infantil). A lo largo de las próximas páginas, desglosaremos cómo planeamos lograr un equilibrio óptimo en términos de jugabilidad y dificultad, y cómo esto contribuirá a una experiencia de juego inmersiva y envolvente que mantendrá a los jugadores comprometidos de principio a fin.

La estructura de niveles, aunque no profundizaremos en su diseño específico en este punto, se presenta de la siguiente manera:
- El juego constará de un total de 5 mundos, cada uno con un tema relacionado con sueños o pesadillas.
- Cada mundo albergará 3 niveles que los jugadores podrán completar.
- El primer nivel de cada mundo estará diseñado en torno a una mecánica específica, lo que permitirá que los jugadores se familiaricen con ella.
- Los otros dos niveles de cada mundo presentarán una combinación de mecánicas de otros mundos, aumentando la complejidad del desafío a medida que se avanza en el juego.
- Además, habrá escenarios que se repetirán, pero sin la mecánica principal, lo que requerirá que los jugadores los superen de manera diferente.
Por lo tanto, la curva de dificultad del videojuego se caracteriza por un aumento gradual a medida que los jugadores avanzan a través de los niveles de los distintos mundos. Sin embargo, esta curva no siempre sigue un aumento constante, ya que, al comenzar cada mundo, el nivel de desafío disminuye cierto grado. Pese a ello, el primer nivel del cuarto mundo será más complejo que el primer nivel del segundo mundo. El objetivo es proporcionar una experiencia de juego equilibrada que mantenga a los jugadores comprometidos sin abrumarlos con una dificultad excesiva (véase IMAGEN 20).

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/20.png)

### 7.5. Objetos interactuables e interacciones
Un elemento fundamental en cualquier videojuego es la capacidad de sumergir al jugador en un mundo interactivo y envolvente. Para lograr esto, es esencial incorporar objetos interactuables que permitan a los jugadores explorar, experimentar y dar vida a la narrativa del juego. En esta sección desglosaremos cada una de las interacciones y objetos que formarán parte de las mecánicas base de los niveles:

#### 7.5.1. Baldosas/bloques transportadores
Se trata de una serie de bloques o baldosas que transportarán al jugador de una zona específica a otra. Este tipo de plataformas se usarán sobretodo para llegar a lugares elevados y limitar zonas de acceso al no poder saltar.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/21.png)

#### 7.5.2. Elevadores de agua
Se trata de una serie de botones que cambian el nivel del agua de cierta zona. En caso de que el jugador toque el agua, morirá. Por ello existirán una serie de plataformas que variarán según el propio nivel del agua y por las que el jugador podrá pasar.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/22.png)

#### 7.5.3. Foco de luz
El foco de luz giratorio es un elemento de juego que, de ser iluminado por él, el jugador sufre un efecto letal, lo que puede resultar en su muerte en el juego. Este elemento agrega un desafío adicional, ya que el jugador debe evitar la luz giratoria para sobrevivir, lo que podría requerir habilidades de sigilo o resolución de acertijos para avanzar con éxito en el juego sin ser detectado por la luz giratoria. Este tipo de mecánica puede aportar tensión y emoción al juego al crear un obstáculo mortal y la necesidad de estrategia por parte del jugador.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/23.png)

#### 7.5.4. Ovejas
Cuando el jugador hace clic en una oveja, esta comienza a perseguirlo. Son útiles ya que activan una serie de plataformas las cuáles requieren de un número determinado de ovejas. La mecánica de hacer clic en una oveja agrega un elemento de desafío y estrategia, ya que el jugador debe equilibrar la gestión de las ovejas mientras trabaja para alcanzar el número requerido y activar las plataformas elevadoras evitando que se caigan. Esto puede requerir planificación y resolución de acertijos para superar obstáculos y avanzar en el juego.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/24.png)

#### 7.5.5. Plataforma de cambio de gravedad
La plataforma de cambio de gravedad es un elemento de juego que, al ser pisado por el personaje, modifica la dirección de la gravedad a su alrededor. Esto significa que el personaje, después de activar la plataforma, caerá en una dirección diferente a la gravedad convencional, lo que puede abrir oportunidades para exploración, resolución de acertijos y superar obstáculos únicos en el juego. Este tipo de plataforma agrega una mecánica de juego intrigante que desafía la percepción y la estrategia del jugador, creando situaciones y rompecabezas innovadores en el juego.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/25.png)

#### 7.5.6. Palanca del puente
El puente controlado por una palanca es un elemento de juego que permite al jugador controlar el acceso a ciertas zonas. Al activar la palanca, el puente se despliega o se retrae, afectando la accesibilidad a diferentes áreas del juego. Si el puente no está activado, ciertas zonas pueden volverse inaccesibles, lo que agrega un componente de resolución de acertijos y estrategia al juego. Los jugadores deben tomar decisiones estratégicas sobre cuándo y cómo activar la palanca para garantizar que puedan acceder a las áreas deseadas y avanzar en el juego.


![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/26.png)

#### 7.5.6. Puertas giratorias
La pared giratoria es un elemento de juego que agrega una mecánica de exploración y descubrimiento. Cuando el jugador pisa la zona adecuada, la pared comienza a girar, revelando una nueva área o pasaje. La plataforma de activación se encuentra escondida, lo que impulsa a los jugadores a buscar y descubrir la forma de avanzar en el juego. Esta mecánica fomenta la exploración y la interacción con el entorno, ofreciendo sorpresas y desafíos a medida que los jugadores descubren cómo utilizarla para acceder a nuevas zonas.


![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/27.png)

#### 7.5.7. Bloques destructibles
La mecánica de los bloques destructibles es un elemento de juego en el que uno o varios bloques están ocultos en el escenario. Cuando el jugador los toca varias veces, estos bloques se rompen, lo que proporciona acceso a nuevas zonas o áreas previamente inaccesibles. Esta mecánica fomenta la exploración y la interacción con el entorno, ya que los jugadores deben descubrir la ubicación de los bloques camuflados y tocarlos repetidamente para avanzar en el juego. Los bloques camuflados pueden ocultar sorpresas, tesoros o desafíos adicionales, lo que agrega un elemento de descubrimiento y recompensa a la experiencia de juego.


![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/28.png)

#### 7.5.8. Dientes que se caen 
La mecánica de los dientes que se caen es un elemento de juego el cual actúa de plataformas. Una vez pisadas por el jugador, comienzan a caerse después de un cierto período de tiempo. El jugador debe ser rápido y estratégico al usar estas plataformas, ya que deben moverse rápidamente para evitar caer cuando las plataformas se desploman. Esta mecánica agrega un elemento de tiempo y habilidad al juego, ya que los jugadores deben calcular el momento adecuado para avanzar a través de estas plataformas antes de que se vuelvan inestables y los hagan caer.

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/29.png)

#### 7.5.9. Bloques de hielo
Esta mecánica es un elemento de juego en el que el jugador avanza sin parar sobre superficies de hielo hasta que choca con una pared o se desliza fuera de la plataforma, lo que puede resultar en la muerte del personaje. Esta mecánica agrega un desafío de control y navegación, ya que el jugador debe anticipar y planificar los movimientos para evitar caer o llegar a la zona correcta deslizándose por las zonas indicadas. Puede requerir reflejos rápidos y estrategia para superar obstáculos en el juego mientras se desliza sobre estas superficies de hielo aparte de resolver problemas como una especie de laberinto.
A modo de referencia, esta mecánica está basada en el gimnasio de tipo hielo de pokemon Diamante y Perla (véase IMAGEN 30).

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/30.png)

## 8. FLUJO DE PANTALLAS
Integrar el concepto del "flujo de pantallas" en un Game Design Document es esencial para delinear de manera efectiva la experiencia de juego que se está desarrollando. En un videojuego es un aspecto fundamental que define la experiencia del jugador y la estructura narrativa del juego. Es la forma en que el juego guía al jugador a través de diferentes momentos, desafíos y narrativas, y tiene un profundo impacto en la inmersión y la jugabilidad.
En este sentido, hemos llevado a cabo un minucioso diseño de las diversas pantallas del videojuego, ajustándonos en todo momento a los requisitos y las historias de usuario proporcionados por nuestros clientes. Antes de presentar el esquema del flujo del videojuego, proporcionaremos una breve explicación de lo que el jugador experimentará en cada una de las pantallas:

1. **Pantalla de Inicio:** Se muestra el logo de la empresa junto a la imagen promocional principal del videojuego.
2. **Pantalla de Login:** Es la primera pantalla interactiva que se encuentra el jugador en la cual podrá acceder al menú principal  si rellena las credenciales correspondientes o, pulsar otro botón que se ubicará debajo del inicio de sesión y el cual dirigirá al jugador a la pantalla de creación de cuenta en caso de no poseer una.
3. **Pantalla de creación de cuenta:** El jugador podrá crearse una cuenta y pasar automáticamente a la pantalla de Login.
4. **Menú principal:** Se encuentran las siguientes opciones:
a. **JUGAR:** Lleva al jugador a la pantalla de selección de mundo.
b. **OPCIONES:** Lleva al jugador a la pantalla de opciones.
c. **COSMÉTICOS:** El jugador es dirigido a la pantalla correspondiente donde podrá aplicar cosméticos al personaje.
5. **Pantalla de selección de mundo:** Estarán los distinto mundos jugables (bloqueados y desbloqueados) y se podrá seleccionar uno para acceder a él.
6. **Pantalla de selección de nivel:** Se podrá seleccionar el nivel que se quiera del mundo correspondiente en caso de estar desbloqueado.
7. **Pantalla de juego:** Se ubica el personaje y el escenario jugable.
8. **Pantalla de Opciones:** Accesible desde casi cualquier pantalla, el jugador podrá realizar los ajustes que están disponibles y crea pertinentes al juego (subir o bajar el volumen, apartado de gráficos…)
9. **Pantalla de personalización de cosméticos:** Se mostrarán todos los cosméticos desbloqueados por el jugador y podrá realizar cambios visuales en el personaje.
10. **Pantalla de gráficos de las métricas:** En caso de poseer una cuenta de docente y tratarse de la versión educativa, los profesores dispondrán en el menú principal de esta opción la cual muestra distintas gráficas de las métricas obtenidas.
Una vez explicada cada una de las pantallas, véase la IMAGEN 31 (esquema del flujo).

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/31.png)

## 9. NIVELES

La creación y el diseño de niveles son una parte fundamental en el desarrollo de un videojuego puesto que son la combinación de las mecánicas, arte y narrativa creadas ya comentadas en secciones anteriores.
En este apartado,  se explica con detalle cómo planificamos y diseñamos los diversos mundos y niveles que compondrán nuestro juego. Para ello, usaremos las fichas de nivel creadas por el estudio donde se recoge la siguiente información de cada mundo:
- **Nombre del mundo.**
- **Imagen o mockup del mundo.**
- **Mecánica principal:**  Cuál es la mecánica característica del mundo comentado, sobre todo de cara al primer nivel.
- **Mecánicas secundarias:** Las cuales se combinarán junto a la principal para el desarrollo del resto de niveles.
- **Ambientación del mundo:** Comentaremos que sueño o pesadilla representa , es decir, el tema principal del mundo.

Antes de comenzar a mostrar las fichas, cabe resaltar que al tratarse de un documento vivo, algo que ya comentamos en la introducción, la mayoría de  imágenes utilizadas son mockups y referencias que hemos tomado para la creación de esos niveles. Una vez esté el nivel terminado, se cambiará por su imagen correspondiente.


![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/32.png)

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/33.png)

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/34.png)

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/35.png)

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/36.png)

![](https://github.com/MelocotoneroSTUDIO/Endless-Dream/blob/main/GDD%20Images/37.png)

