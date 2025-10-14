# Trabajo Práctico Programación II – Pedidos

## Se pide

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

## Estructura del Proyecto

Este proyecto está desarrollado en C# utilizando .NET 8.0. La estructura incluye:

- `Program.cs`: archivo principal con el método `Main()` que crea los objetos y muestra los pedidos.
- Clases: `Cliente`, `Item`, `Pedido`, cada una con sus propiedades y método `Imprimir`.
- `README.md`: este archivo con el enunciado y guía de uso.
- `CHANGELOG.md`: registro de cambios y mejoras aplicadas.

---

## Ejecución

Para ejecutar el programa en GitHub Codespaces, Visual Studio Code o cualquier entorno con .NET instalado:

1. Abrí la terminal en la raíz del proyecto.
2. Ejecutá el siguiente comando:

```bash
dotnet run
```

Esto compilará y ejecutará el programa, mostrando los pedidos cargados en consola.

---

## Salida esperada

```plaintext
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
✅ [Sin warnings de compilación](CHANGELOG.md#corrección-de-warnings-cs8618)  
✅ Salida clara y legible  
✅ Listo para entrega o revisión

