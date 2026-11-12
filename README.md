# Escena Invernal de Rescate

Proyecto del taller de Unity: una escena invernal con un vehículo policial,
sirena de emergencia, humo de escape y una tormenta de nieve.

## Requisitos

- Unity 6.6.0 o compatible.
- Render Pipeline Universal (URP).
- Windows, macOS o Linux.

## Abrir el proyecto

1. Abre Unity Hub.
2. Selecciona **Add** y elige esta carpeta:
   `My project (2)`.
3. Abre el proyecto con Unity.
4. Abre la escena:
   `Assets/Scenes/WinterRescue.unity`.
5. Pulsa **Play** para probar la escena.

## Jerarquía principal

La escena contiene los objetos solicitados:

```text
Main Camera
Moon_Light
Snow_Terrain
Police_Car
    Car_Mesh
    Siren_Pivot
        Red_Light
        Blue_Light
    Exhaust_Smoke
Global_Blizzard
```

## Elementos implementados

### Terreno y vehículo

- `Snow_Terrain` utiliza `Snow_Material`, de color blanco azulado.
- El terreno está elevado para cubrir visualmente la parte inferior y las
  ruedas del vehículo.
- `Police_Car` mantiene una posición `Y = -0.5` y queda parcialmente enterrado.
- El modelo policial se encuentra en `Car_Mesh`.

### Sirena policial

- `Siren_Pivot` tiene el componente `SirenRotation`.
- Las luces roja y azul giran juntas a 180 grados por segundo.
- La barra superior usa materiales rojo, azul y blanco.
- Los materiales de la sirena usan URP para evitar superficies magenta en Unity 6.

### Humo

- `Exhaust_Smoke` es hijo de `Police_Car`.
- Está colocado en la parte trasera del vehículo.
- Las partículas aumentan de tamaño y se vuelven transparentes al desaparecer.

### Nieve

- `Global_Blizzard` es independiente del vehículo.
- Emite partículas desde una zona amplia sobre la escena.
- La gravedad y la orientación hacen que la nieve caiga hacia el terreno.

## Controles de prueba

No se requieren controles de teclado. Al pulsar **Play** se deben observar:

- La sirena girando.
- El humo saliendo por la parte trasera.
- La nieve cayendo.
- El centro blanco de la barra y los laterales rojo y azul.

## Comprobación final

Antes de entregar, verifica en Unity:

- [ ] La escena `WinterRescue` abre sin errores.
- [ ] No hay errores rojos en la ventana **Console**.
- [ ] La sirena gira al pulsar **Play**.
- [ ] La parte trasera del vehículo se distingue del humo.
- [ ] La nieve cae y es visible en la vista **Game**.
- [ ] La barra superior muestra rojo, blanco y azul.
- [ ] El repositorio de GitHub es público si el taller lo exige.
- [ ] No se subieron las carpetas generadas `Library`, `Temp` u `obj`.

## GitHub

Repositorio:

https://github.com/DeysiVarela/Unity-Taller-Invierno-Rivas

El proyecto está sincronizado con la rama `main`. El último commit contiene
los ajustes de partículas y de la sirena policial.

## Historial

Los cambios principales se registraron en commits separados, incluyendo:

- Configuración inicial del proyecto.
- Escena y vehículo policial.
- Jerarquía y rotación de la sirena.
- Partículas de nieve y humo.
- Ajustes visuales de la sirena y materiales URP.

