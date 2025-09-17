# Security Requirements – Scoops2Go API

This document lists the security requirements defined by our team to ensure secure development of the Scoops2Go API.

## Authentication & Authorization
- All endpoints (except /register and /login) require valid JWT authentication.
- Implement role-based access control (admin vs user).

## Data Protection
- All user passwords must be hashed using bcrypt or PBKDF2.
- All traffic must use HTTPS (TLS 1.2+).
- Secrets (JWT signing key, DB passwords) must not be hardcoded — use environment variables.

## Input Validation
- Validate and sanitise all client input.
- Reject requests with missing or malformed data.

## Error Handling & Logging
- Centralised error handling middleware.
- No sensitive data in error responses.
- Log failed login attempts, suspicious activity, and access violations.

## DevSecOps
- Enable dependency vulnerability scanning in CI.
- Run automated build and test on each PR.
- Run static analysis (optional: CodeQL, SonarCloud).

## Availability
- Implement basic rate limiting to reduce DoS risk.
- Monitor health endpoint (`/health`) to detect downtime.

