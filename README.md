 Calculadora de Escritorio - Windows Forms (.NET)

> **Proyecto:** PPE09 – Desarrollo de una calculadora de escritorio con .NET Windows Forms  
> **Asignatura:** Diseño y Programación de Software  
> **Modalidad:** Trabajo individual  
<img width="1571" height="907" alt="image" src="https://github.com/user-attachments/assets/27a03107-dadd-4776-a149-b6d78420d693" />

---

## 1. Nombre del proyecto
**Calculadora WinForms C#** (`Calculadora`) — Aplicación de escritorio para operaciones aritméticas básicas.

## 2. Descripción general
Aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms (.NET)** que simula el funcionamiento de una calculadora convencional. El sistema está diseñado bajo el paradigma de **programación orientada a eventos**, permitiendo al usuario realizar cálculos mediante una interfaz gráfica intuitiva, limpia y profesional sin depender de la edición directa por teclado en la pantalla de visualización.

## 3. Objetivos
* **Objetivo general:** Desarrollar una aplicación de escritorio funcional y robusta en C# que resuelva operaciones matemáticas fundamentales mediante controles visuales de Windows Forms.
* **Objetivos específicos:**
  * Implementar una interfaz gráfica organizada con distribución uniforme de controles.
  * Gestionar eventos `Click` de botones numéricos y operadores de forma eficiente.
  * Validar entradas de usuario y controlar excepciones críticas, específicamente la **división para cero**.
  * Permitir el encadenamiento de operaciones consecutivas sin reiniciar la aplicación.

## 4. Características principales
* **Teclado numérico integrado:** Botones del `0` al `9` (`btn0` - `btn9`) como mecanismo principal de ingreso de datos.
* **Operaciones aritméticas fundamentales:**
  * Suma (`+`)
  * Resta (`-`)
  * Multiplicación (`×`)
  * División (`÷`)
* **Pantalla digital de solo lectura (`txtPantalla`):** Control `TextBox` configurado con `ReadOnly = true` y alineación a la derecha para evitar alteraciones manuales no válidas.
* **Operaciones consecutivas:** Permite encadenar resultados previos con nuevas operaciones de forma continua.
* **Control de limpieza (`C`):** Reinicia las variables de estado (`primerNumero`, `segundoNumero`, `resultado`, `operacion`) y limpia la pantalla.
* **Manejo de errores:** Detección de división entre cero y entradas inválidas mediante mensajes comprensibles para el usuario.

## 5. Tecnologías utilizadas
* **Lenguaje de programación:** C#
* **Framework / Plataforma:** .NET (Windows Forms)
* **Versión del SDK:** .NET 8.0 SDK *(ajustar a .NET 6.0 / .NET 7.0 según la versión elegida en Visual Studio)*
* **Entorno de desarrollo (IDE):** Visual Studio 2022
* **Control de versiones:** Git y GitHub

## 6. Requisitos de instalación
Para compilar y ejecutar este proyecto en un entorno local se requiere:
1. Sistema operativo **Windows 10** o **Windows 11**.
2. **Visual Studio 2022** (Community, Professional o Enterprise).
3. Carga de trabajo **"Desarrollo de escritorio de .NET"** instalada en Visual Studio.
4. **SDK de .NET** compatible con la versión del proyecto.
5. **Git** instalado para clonar el repositorio.

## 7. Instrucciones de ejecución
Sigue estos pasos para descargar y ejecutar la aplicación en tu equipo:

1. **Clonar el repositorio:**
   Abre una terminal y ejecuta el siguiente comando (reemplaza la URL por la de tu repositorio):
   ```bash
   git clone https://github.com
   ```
2. **Abrir el proyecto:**
   * Navega a la carpeta descargada y abre el archivo de solución (`.sln`) o el archivo de proyecto (`Calculadora.csproj`) con **Visual Studio 2022**.
3. **Compilar y ejecutar:**
   * Espera a que Visual Studio restaure las dependencias.
   * Presiona la tecla **`F5`** o haz clic en el botón **Iniciar (▶)** en la barra superior para compilar y abrir la calculadora.

## 8. Estructura del proyecto
```text
📦 Calculadora
 ┣ 📂 Properties/             # Configuración y recursos del ensamblado
 ┣ 📜 Calculadora.csproj      # Archivo de configuración del proyecto .NET
 ┣ 📜 Form1.cs                # Lógica principal, variables de estado y manejo de eventos
 ┣ 📜 Form1.Designer.cs       # Código generado automáticamente para la interfaz gráfica
 ┣ 📜 Form1.resx              # Recursos visuales del formulario
 ┗ 📜 Program.cs              # Punto de entrada principal de la aplicación
```

## 9. Capturas de pantalla
> *Nota: Sube tus capturas a una carpeta `assets/` o `screenshots/` en tu repositorio y actualiza las rutas a continuación.*

| Interfaz Principal | Ejemplo de Operación | Manejo de Error (División para 0) |
| :---: | :---: | :---: |
| ![Interfaz Principal](screenshots/interfaz.png) | ![Operación](screenshots/operacion.png) | ![Error](screenshots/error.png) |

## 10. Pruebas realizadas
Se verificó el correcto funcionamiento de la aplicación bajo los siguientes escenarios:

| ID | Escenario de prueba | Entrada | Resultado esperado | Estado |
| :--- | :--- | :--- | :--- | :---: |
| **P01** | Suma de enteros | `15` + `25` `=` | `40` | ✅ Aprobado |
| **P02** | Resta con resultado negativo | `10` - `30` `=` | `-20` | ✅ Aprobado |
| **P03** | Multiplicación estándar | `8` × `7` `=` | `56` | ✅ Aprobado |
| **P04** | División exacta y decimal | `15` ÷ `2` `=` | `7.5` | ✅ Aprobado |
| **P05** | División para cero | `9` ÷ `0` `=` | Mensaje de advertencia sin cierre inesperado | ✅ Aprobado |
| **P06** | Operaciones consecutivas | `5` + `5` `=` (`10`) × `2` `=` | `20` | ✅ Aprobado |
| **P07** | Reinicio con botón Limpiar | Ingresar dígitos + presionar `C` | Pantalla vacía y variables reiniciadas | ✅ Aprobado |
| **P08** | Bloqueo de edición manual | Intentar escribir en `txtPantalla` | El control rechaza la escritura (`ReadOnly`) | ✅ Aprobado |

## 11. Autor
* **Estudiante:** [Escribe aquí tus Nombres y Apellidos completos]
* **Asignatura:** Diseño y Programación de Software
