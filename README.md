# Álgebra Relacional con Entity Framework y Northwind

Este proyecto implementa operaciones unarias del álgebra relacional (Selección, Proyección y Renombramiento) utilizando Entity Framework en C# sobre la base de datos clásica **Northwind** en SQL Server.

---

## Contenido del Proyecto

- Consultas LINQ que representan operaciones unarias:
  - **Selección (σ):** Filtrado de filas usando distintos predicados (comparación, rango, pertenencia).
  - **Proyección (π):** Selección de columnas específicas, eliminando duplicados cuando es necesario.
  - **Renombramiento (ρ):** Cambio de nombres de atributos en el resultado para mayor claridad.

- Aplicación web ASP.NET WebForms con interfaz para ejecutar las consultas y mostrar resultados.

- Modelo de datos generado con Entity Framework desde la base de datos Northwind.

---

## Requisitos

- Visual Studio 2019 o superior.
- SQL Server con la base de datos Northwind instalada.
- .NET Framework 4.x

---

## Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/RPMaykol/EFAlgebra-Relacional.git

