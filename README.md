## 📌 Project TODO / Roadmap

### ✅ Phase 1 — Core API (MVP)

- [x] Create entities (e.g. `Bookmark`, `User`)
- [x] Configure PostgreSQL database
- [x] EF Core migrations
- [ ] CRUD endpoints
  - [x] Create item
  - [x] Get all items
  - [x] Get item by id
  - [x] Update item
  - [x] Delete item
  - [x] Get all items admin + count

- [x] Basic validation (required fields, lengths)
- [x] Proper HTTP status codes
- [x] OpenAPI + Scalar documentation

---

### 🧠 Phase 2 — Architecture & Safety

- [x] Introduce DTOs (no entities over the wire)
- [x] Add `AsNoTracking` for read queries
- [ ] Centralized exception handling
- [ ] Logging (request + error logs)
- [ ] Health checks endpoint

---

### ⚡ Phase 3 — Performance & Reliability

- [ ] Pagination for list endpoints
- [ ] Filtering & sorting

---
