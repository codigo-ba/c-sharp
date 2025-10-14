# Trabajo Práctico Programación II – Pedidos (Versión Interactiva)

## Se pide: (se agrega ingreso por consola)

### 1ra Parte

**a)** Se desea desarrollar una aplicación de consola que permita cargar pedidos. Para ello nos apoyaremos en la siguiente definición de clases:

Cada Pedido pertenece a un Cliente y contiene uno o varios ítems.

#### Clases:

- **Pedido**
  - NroDePedido
  - Fecha
  - Cliente
  - Items
  - Total (Propiedad Calculada con la suma de los ítems)

- **Item**
  - Codigo
  - Descripcion
  - Cantidad
  - Precio
  - Importe (Propiedad Calculada: Cantidad * Precio)

- **Cliente**
  - Nombre
  - Dirección

**Importante:** Todas las clases deben tener un método que se llame `Imprimir` que devuelva la información de la clase en una línea concatenada.

---

**b)** Realizar un programa que cargue **2 pedidos** a **2 clientes distintos**:

- El **1er pedido** tendrá **2 ítems**
- El **2do pedido** tendrá **1 ítem**

Utilizar las clases realizadas en el punto a).

---

## Versión Interactiva – Diferencias clave

Esta versión cumple con el mismo enunciado que la versión básica, pero:

- ✅ Los datos de los clientes e ítems **se ingresan por teclado** usando `Console.ReadLine()`.
- ✅ Se mantiene la regla de **2 pedidos**: el primero con **2 ítems**, el segundo con **1 ítem**.
- ✅ Se utiliza un bucle `for` para cargar los pedidos dinámicamente.
- ✅ La lógica de impresión y cálculo (`Total`, `Importe`, `Imprimir()`) se mantiene igual.

---

## Estructura del Proyecto

- `Program.cs`: contiene la lógica principal del programa.
- Clases: `Cliente`, `Item`, `Pedido`, con sus propiedades y métodos.
- `README.md`: este archivo con el enunciado y guía de uso.
- `CHANGELOG.md`: registro de cambios y mejoras aplicadas.

---

## Ejecución

1. Abrí la terminal en la carpeta del proyecto.
2. Ejecutá:

```bash
dotnet run
```

3. Ingresá los datos solicitados por consola:
   - Nombre y dirección del cliente
   - Código, descripción, cantidad y precio de cada ítem

---

## Salida esperada (ejemplo)

```plaintext
=== PEDIDOS CARGADOS ===

Pedido N°1
Fecha: 14/10/2025
Cliente: Juan Pérez, Dirección: Calle Falsa 123
Total: 200
Items:
  - Item: A1, Lapicera, Cantidad: 2, Precio: 50, Importe: 100
  - Item: B2, Cuaderno, Cantidad: 1, Precio: 100, Importe: 100

Pedido N°2
Fecha: 14/10/2025
Cliente: Ana Gómez, Dirección: Av. Siempre Viva 742
Total: 500
Items:
  - Item: C3, Mochila, Cantidad: 1, Precio: 500, Importe: 500
```

---

## Requisitos

- .NET SDK 8.0 o superior
- Editor de código (Visual Studio Code, GitHub Codespaces, etc.)

---

## Estado del Proyecto

✅ Cumple con todos los requisitos del enunciado  
✅ Interactivo: permite ingresar datos por consola  
✅ Salida clara y legible  
✅ Documentación incluida  
✅ Listo para entrega o revisión
