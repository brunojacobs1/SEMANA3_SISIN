# SEMANA3_SISIN

  Un puente tendido sobre un río, en malas condiciones, soporta como máximo el peso de 2 personas al mismo tiempo. En un extremo hay cuatro personas que desean cruzarlo de noche, usando para ello un único farol de aceite.
  
  Puesto que solo disponen de uno, cada vez que una pareja llega al extremo final del puente, alguien deberá volver al extremo inicial para                         que otros puedan usarlo.
  
  Además, cada uno de ellos tarda un tiempo diferente en recorrerlo: el más rápido puede hacerlo en un minuto; el siguiente tarda dos minutos; el tercero, cinco minutos y el más lento de todos consume 10 minutos.
  
  Por supuesto, dos personas juntas tardan en cruzar el puente, el tiempo que tarde el más lento de ellos.
  
  El farol tiene una cantidad de aceite limitada, de modo que se desea encontrar la combinación óptima de movimientos que minimiza el tiempo total para dejar a las cuatro personas en el extremo final.
  
  ![alt text](https://raw.githubusercontent.com/sumitc91/data/master/askgif-blog/1e4466ec-1048-446c-b2c6-8fb13e4e9d54_torch-bridge.jpg  "Problema")
  
  - **Espacio de problemas:**
  
    Tiempo | Extremo inicial | Acción | Extremo final
    --- | --- | --- | ---
    0 min | ABCD | |
    2 min | &nbsp; &nbsp; CD | A y B cruzan | AB
    3 min | A &nbsp; CD | A regresa | &nbsp; B
    8 min | &nbsp; &nbsp; &nbsp; D | A y C cruzan | ABC
    9 min | A &nbsp; &nbsp; D | A regresa | &nbsp; BC
    17 min | | A y D cruzan | ABCD
  
  - **¿Qué funciones heurísticas admisibles se te ocurren para guíar un algoritmo de búsqueda que encuentre la solución óptima a este problema?**
  
    Dado que para la solución de este problema se utiliza el algoritmo de búsqueda en anchura (BFS); y al ser un algoritmo de búsqueda no informada, no se encontraron heurísticas admisibles para acompañar a la lógica.
  
  
