# Registro de Cambios – TP Pedidos (Versión Interactiva)

## ✅ Versión Interactiva

### 🔄 Cambio principal

Se migró el proyecto desde una versión **no interactiva** (con datos cargados en código) a una versión **interactiva**, donde el usuario ingresa los datos por consola.

### 🆚 Diferencias con la versión anterior

| Aspecto                  | Versión Básica                     | Versión Interactiva                        |
|--------------------------|------------------------------------|--------------------------------------------|
| Ingreso de datos         | Hardcodeado en el código           | Ingresado por el usuario vía consola       |
| Cantidad de pedidos      | 2                                  | 2                                          |
| Ítems por pedido         | Pedido 1: 2 ítems<br>Pedido 2: 1 ítem | Igual                                      |
| Estructura de clases     | Igual                              | Igual                                      |
| Métodos `Imprimir()`     | Igual                              | Igual                                      |
| Salida en consola        | Estática                           | Dinámica según los datos ingresados        |

---

### 🧠 Lógica agregada

- Se agregó un bucle `for` para cargar los 2 pedidos.
- Se usó `Console.ReadLine()` para capturar:
  - Nombre y dirección del cliente
  - Código, descripción, cantidad y precio de cada ítem
- Se mantuvo la lógica de impresión y cálculo de totales.

---

### 🧪 Validación

- Se probó el ingreso de datos por consola.
- Se verificó que los totales y formatos de salida sean correctos.
- Se mantuvo la estructura modular y reutilizable del código.

---

## 🏁 Estado del Proyecto

- ✅ Funcionalidad interactiva implementada
- ✅ Cumple con el enunciado original
- ✅ Código limpio y legible
- ✅ Documentación actualizada (`README.md` y `CHANGELOG.md`)
