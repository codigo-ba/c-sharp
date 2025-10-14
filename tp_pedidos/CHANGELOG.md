# Registro de Cambios – TP Pedidos

## ✅ Versión Final

### 🔧 Corrección de Warnings CS8618

Durante la compilación inicial, se presentaron los siguientes warnings:

```
warning CS8618: Non-nullable property 'Nombre' must contain a non-null value when exiting constructor.
warning CS8618: Non-nullable property 'Direccion' must contain a non-null value when exiting constructor.
warning CS8618: Non-nullable property 'Codigo' must contain a non-null value when exiting constructor.
warning CS8618: Non-nullable property 'Descripcion' must contain a non-null value when exiting constructor.
warning CS8618: Non-nullable property 'Cliente' must contain a non-null value when exiting constructor.
```

### ✅ Solución aplicada

Se utilizó el modificador `required` en las propiedades afectadas para indicar que deben ser inicializadas al momento de crear el objeto. Ejemplo:

```csharp
public required string Nombre { get; set; }
```

Esto elimina los warnings y mejora la seguridad del código, asegurando que las propiedades no queden sin valor.

---

### 🎨 Mejora de legibilidad en consola

Se mejoró la salida del método `Imprimir()` en la clase `Pedido` utilizando saltos de línea `\n` y sangrías para que la información se vea más clara.

Ejemplo de salida:

```
Pedido N°1
Fecha: 14/10/2025
Cliente: Juan Pérez, Dirección: Calle Falsa 123
Total: 200
Items:
  - Item: A1, Lapicera, Cantidad: 2, Precio: 50, Importe: 100
  - Item: B2, Cuaderno, Cantidad: 1, Precio: 100, Importe: 100
```

Esto se logró con:

```csharp
string itemsTexto = string.Join("\n  - ", Items.Select(i => i.Imprimir()));
```

Y en el `return` del método:

```csharp
return $"Pedido N°{NroDePedido}\nFecha: {Fecha.ToShortDateString()}\n{Cliente.Imprimir()}\nTotal: {Total}\nItems:\n  - {itemsTexto}";
```

---

## 🏁 Estado del Proyecto

- ✅ Código funcional y completo
- ✅ Sin warnings de compilación
- ✅ Salida clara y legible
- ✅ Documentación incluida (`README.md` y `CHANGELOG.md`)
- ✅ Listo para entrega o revisión
