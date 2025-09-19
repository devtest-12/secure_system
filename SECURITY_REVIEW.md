# Manual Security Code Review – Scoops2Go API

## Scope
This review covers all current application code:
- Controllers
  - AuthController.cs
  - OrdersController.cs
- Services
  - AuthService.cs
  - OrderService.cs
- Models
  - User.cs
  - Order.cs
- Program.cs

---

## ✅ Positive Security Practices

| Practice                          | Description                                                                 |
|----------------------------------|------------------------------------------------------------------------------|
| Password hashing implemented      | Passwords are hashed before storage (currently SHA256)                      |
| Separation of concerns            | Authentication, business logic, and HTTP routing are separated by layers    |
| No hardcoded secrets               | No API keys, DB strings, or secrets are hardcoded                           |
| No sensitive data in error output  | No exception stack traces are shown to users                                |
| HTTPS redirection enabled          | HTTPS redirection middleware added in `Program.cs`                          |

---

## ⚠️ Issues Identified

| Issue                                | Location                       | Risk Level | Description                                                         | Recommendation                                                     |
|--------------------------------------|--------------------------------|--------------|----------------------------------------------------------------------|---------------------------------------------------------------------|
| No input validation                   | AuthController, OrdersController | High         | User input is accepted without validation or length checks            | Add `[Required]`, `[StringLength]` data annotations on input models |
| Weak password hashing (SHA256)        | AuthService                     | High         | SHA256 is fast and vulnerable to brute force attacks                  | Use bcrypt via `BCrypt.Net` package                                  |
| No authentication on Orders endpoints | OrdersController                | High         | Any user can access all orders without login                          | Add JWT authentication and require valid token for access            |
| No role-based authorization           | Entire app                      | Medium       | All users are treated the same                                        | Add role checks (admin vs user) in controllers                       |
| No logging or error handling          | Entire app                      | Medium       | Security events and errors are not logged                             | Implement centralized error handler + logging middleware             |
| No rate limiting                      | Entire app                      | Low           | API could be abused by brute force or DoS                             | Add rate limiting middleware                                        |
| No CSRF protection (if web clients)   | Entire app                      | Low           | Not a current issue (API only), but needed if web forms are added     | Add anti-forgery tokens if browser-based forms are added             |
| No persistent storage                 | AuthService, OrderService       | Low           | All data is stored in-memory and lost on restart                      | Optional: use EF Core + SQLite for persistent secure storage         |

---

## 🛠 Plan to Fix
- Add model classes for request bodies with validation attributes
- Integrate `BCrypt.Net` for password hashing
- Implement JWT-based authentication and protect `/orders` endpoints
- Add role-based authorization
- Add global error handling middleware and `ILogger` logging
- Integrate `AspNetCoreRateLimit` for rate limiting
- (Optional) Migrate to EF Core with SQLite database

---

**Reviewed By:** Wh  
**Date:** 19 Sept 2025  
**Review Method:** Manual code review using VS Code and GitHub PR review

---

## 📌 Notes
This review was conducted as part of Week 6 of the Secure System Development project (1CWK100). It demonstrates secure code review practices and identifies risks and mitigations before production deployment.
