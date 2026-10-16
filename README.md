# FerreMax — Diseño Arquitectural del Sistema con IA (Unidad 3)

## Empresa Asignada
- **Caso:** FerreMax (Ferretería y Venta Empresarial)
- **Proceso Principal:** Cotización, crédito, venta, inventario y entrega

## Integrantes
| Integrante | Rol en el Proyecto | Responsabilidades Principales |
| :--- | :--- | :--- |
| **Cristian Aleli Garcia Avalos** | Líder de Dominio y Modelado UML | Modelado DDD, Diagrama de Clases y Diagramas de Secuencia (Flujo normal y excepción) |
| **Juan Manuel Casanova Avila** | Líder de Patrones, Servicio y Código Base | Patrón de lógica de negocio (*Domain Model*), *Service Layer*, CQRS y maquetación del código en `src/` |
| **Abdul Ali Vazquez Flores** | Líder de Gobierno, Calidad y Repositorio | Revisión SOLID, Registros ADR, Matriz de Trazabilidad, Bitácora de IA y gestión de GitHub |

---

## Decisiones Arquitecturales Clave
1. **Patrón de Lógica de Negocio (*Domain Model*):** Las reglas comerciales (descuentos del 5% y 10%, vigencias de 3 y 5 días, crédito suspendido) están encapsuladas dentro de entidades y agregados (`Cotizacion`, `ClienteEmpresarial`, `Venta`).
2. **Desacoplamiento de Persistencia (*Repository + Unit of Work*):** Aislamiento de la base de datos mediante interfaces de repositorio (`IVentaRepository`, `IInventarioRepository`) y transacciones atómicas con `IUnitOfWork`.
3. **Separación de Comandos y Consultas (*CQRS Básico*):** Flujos de escritura (*Commands*) procesados por el Dominio y consultas masivas (*Queries*) optimizadas mediante DTOs de lectura para stock e inventario por SKU.


---

## Entregables
- Informa Arquitectura [Informe_Arquitectura_FerreMax](docs/Informe_Arquitectura_FerreMax.pdf)
- Matriz de Trazabilidad [Matriz_Trazabilidad](docs/Matriz_Trazabilidad.pdf)
- Bitacora de IA [Bitacora_IA](docs/Bitacora_IA.pdf)
- Registro de Desiciones Arquitecturales (ADRs):
  - [ADR-001: Seleecion de Domain Model](docs/ADRs/ADR-001.md)
  - [ADR-002: Repository y Unit of Work](docs/ADRs/ADR-002.md)
  - [ADR-003: CQRS Basico](docs/ADRs/ADR-003.md)
- Diagramas UML:
  - [Mapa de Dominio](diagrams/exports/Mapa_de_Dominio_FerreMax.png)
  - [Diagrama de Clases DDD](diagrams/exports/Diagrama%20de%20clases.png)
  - [Diagrama de Secuencia - CU-01 Flujo Normal](diagrams/exports/Diagrama%20de%20Secuencia%20CU-01.png)
  - [Diagrama de Secuencia - CU-04 Flujo Excepcion](diagrams/exports/Diagrama%20de%20Secuencia%20CU-04.png)