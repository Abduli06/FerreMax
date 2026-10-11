# FerreMax — Diseño Arquitectural del Sistema con IA (Unidad 3)

## Empresa Asignada
- **Caso:** FerreMax (Ferretería y Venta Empresarial)
- **Proceso Principal:** Cotización, crédito, venta, inventario y entrega

## Integrantes
- [Cristian aleli Garcia Avalos]
- [Abdul Ali Vazquez Flores]
- [Juan Manuel Casanova Avila]
---

## Organización de Entregables
- **Informe de Arquitectura:** `docs/01_informe_arquitectura.pdf`
- **Diagramas (UML y Secuencias):**
  - Fuentes: `diagrams/src/`
  - Exportaciones legibles (PNG): `diagrams/exports/`
- **Architecture Decision Records (ADRs):** `docs/adr/`
- **Matriz de Trazabilidad:** `docs/matriz_trazabilidad.md`
- **Bitácora de IA:** `docs/bitacora_ia.md`
- **Código Fuente (Domain, Application, Infrastructure):** `src/`

---

## Decisiones Arquitecturales Clave
1. **Patrón de lógica de negocio:** Justificado en `docs/adr/ADR-001-patron-logica-negocio.md`.
2. **Persistencia desacoplada:** Repository y Unit of Work en `docs/adr/ADR-002-separacion-persistencia-uow.md`.
3. **Lecturas y Escrituras:** Separación CQRS básico en `docs/adr/ADR-003-cqrs-inventario-cotizaciones.md`.