## 📌 Project TODO / Roadmap

### ✅ Phase 1 — Core API (MVP)

- [ x ] Create entities (e.g. `Bookmark`, `User`)
- [ ] Configure PostgreSQL database
- [ ] EF Core migrations
- [ ] CRUD endpoints
  - [ ] Create item
  - [ ] Get all items
  - [ ] Get item by id
  - [ ] Update item
  - [ ] Delete item

- [ ] Basic validation (required fields, lengths)
- [ ] Proper HTTP status codes
- [ ] OpenAPI + Scalar documentation

---

### 🔐 Phase 2 — Auth & Security

- [ ] User registration
- [ ] User login
- [ ] Password hashing
- [ ] JWT authentication
- [ ] Authorization (user-owned resources)
- [ ] HTTPS enforced in production
- [ ] CORS configuration

---

### 🧠 Phase 3 — Architecture & Safety

- [ ] Move business logic to services
- [ ] Introduce DTOs (no entities over the wire)
- [ ] Add `AsNoTracking` for read queries
- [ ] Centralized exception handling
- [ ] Logging (request + error logs)
- [ ] Health checks endpoint

---

### ⚡ Phase 4 — Performance & Reliability

- [ ] Pagination for list endpoints
- [ ] Filtering & sorting
- [ ] Indexes on frequently queried columns
- [ ] Connection pooling tuning
- [ ] Optional in-memory caching
- [ ] Background jobs (if needed)

---

### 🧪 Phase 5 — Testing

- [ ] Unit tests (services)
- [ ] Integration tests (API + DB)
- [ ] Test database setup
- [ ] Seed data for tests
- [ ] CI pipeline

---

### 📦 Phase 6 — Deployment

- [ ] Dockerfile for API
- [ ] Docker Compose (API + PostgreSQL)
- [ ] Environment-based config
- [ ] Secrets management
- [ ] Production logging
- [ ] Database backups

---

### 🧭 Phase 7 — Nice-to-haves

- [ ] Rate limiting
- [ ] API versioning
- [ ] Soft deletes
- [ ] Audit fields (created/updated timestamps)
- [ ] Role-based access
- [ ] Metrics & monitoring

---

## 📝 Notes

- DbContext is request-scoped
- PostgreSQL connection pooling enabled by default
- EF Core migrations are the source of truth
- Keep controllers thin, logic in services
- Prefer safety over cleverness
