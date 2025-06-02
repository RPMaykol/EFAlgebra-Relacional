# Proyecto: Álgebra Relacional con Entity Framework y Northwind

## Objetivo

- Comprender y aplicar las operaciones fundamentales del álgebra relacional en un contexto práctico utilizando ADO.NET Entity Framework.  
- Desarrollar habilidades para manipular y consultar datos de manera declarativa usando la base de datos **Northwind**.  
- Fomentar el trabajo en equipo, la comunicación técnica y la presentación de resultados.

## Descripción de la Actividad

Este proyecto consiste en diseñar e implementar soluciones que demuestren la aplicación de las operaciones unarias del álgebra relacional:

- **Selección (σ):** Consultas que filtran filas basadas en condiciones específicas, usando diferentes tipos de predicados (comparación, rango, pertenencia, etc.).  
- **Proyección (π):** Consultas que extraen columnas específicas de una o más entidades, eliminando duplicados si es necesario.  
- **Renombramiento (ρ):** Cambiar el nombre de atributos en el resultado de las consultas para facilitar claridad y la integración con otras operaciones.

Se desarrollaron 3 ejercicios distintos para cada operación.

---

## Entregables

- **Informe Técnico (PDF):** Documento con la descripción detallada del proyecto, modelo de datos, implementación y análisis de resultados.  
- **Exposición Oral:** Presentación del trabajo, incluyendo introducción al modelo de datos, demostración de código y explicación de resultados.  
- **Repositorio de Código en GitHub:** Código fuente completo con el modelo de datos, contexto y consultas implementadas. El repositorio está bien organizado y contiene este archivo README.

---

## Tecnologías y Herramientas

- Lenguaje: C#  
- Framework: ADO.NET Entity Framework  
- Base de datos: SQL Server (Northwind)  
- IDE: Visual Studio  
- Plataforma: ASP.NET WebForms

---

## Estructura del Proyecto

- **Modelos:** Clases generadas por Entity Framework desde la base de datos Northwind.  
- **Consultas:** Implementaciones en LINQ para las operaciones unarias.  
- **Páginas Web:** ASP.NET WebForms para ejecutar y mostrar resultados de las consultas.  
- **Configuración:** Archivo `Web.config` con la cadena de conexión a la base de datos.

---

## Cómo Ejecutar el Proyecto

1. Clona este repositorio:

   ```bash
   git clone https://github.com/RPMaykol/EFAlgebra-Relacional.git
