# Practice Journal – Scoops2Go API
**Module:** 1CWK100 Secure System Development  
**Project:** Scoops2Go Secure API  
**Team Members:** DevTest (Developer & DevSecOps), wh (Reviewer & Security Analyst)

---

## Skills & Attributes Demonstrated

### Team Player
- Collaborated using GitHub Flow (feature branches, PRs, reviews)
- wh regularly reviewed my pull requests and provided comments
- Discussed design decisions and security trade-offs during PR reviews
- Example PRs/screenshots: resources/week2/3.png, 4.png, 5.png, 6.png

---

### Problem Solver
- Researched and fixed environment issues (missing .NET runtimes, 404 errors)
- Solved validation errors by switching from query params to JSON bodies
- Debugged CI build errors until workflow passed
- Evidence: resources/week1/2.png, week5/12.png

---

### Evaluative Practitioner
- Balanced security vs usability when planning features (simple in-memory storage for demo vs full DB)
- Considered privacy and data protection (no sensitive data in responses)
- Discussed commercial viability of secure design during planning
- Documented trade-offs in SECURITY.md and THREAT_MODEL.md

---

### Version Control Systems
- Used Git and GitHub for version control
- Created branches, commits with clear messages, pull requests, and merges
- Configured local git user/email for project identity
- Evidence: resources/week2/3.png–6.png

---

### Documentation of Secure Designs
- Created SECURITY.md with security requirements
- Created THREAT_MODEL.md with DFD diagram and STRIDE analysis
- Reviewed and updated these based on wh’s feedback
- Evidence: resources/week3/7.png–9.png, week4/10.png–11.png

---

### Secure Coding and Testing
- Implemented secure endpoints for register/login/orders
- Used password hashing and separated logic layers
- Conducted manual code review and documented risks in SECURITY_REVIEW.md
- Added CI pipeline to build and scan dependencies
- Evidence: resources/week5/12.png, week6/13.png, week7/14.png–17.png

---

### DevSecOps
- Built GitHub Actions CI pipeline for automated build, test, and security scan
- Ensured no secrets in the pipeline and used `.gitignore` for safety
- CI workflow runs on every push and pull request
- Evidence: resources/week7/14.png–17.png

---

## Security Economics Reflection
Implementing secure design took additional time, especially building the CI pipeline, manual reviews, and threat modelling.  
However, this reduced security risk significantly by:
- Preventing data breaches through authentication & hashing
- Reducing supply chain risks via dependency scanning
- Reducing long-term costs by catching vulnerabilities early

Trade-offs:  
- Higher initial development time and learning curve  
- More planning and documentation work  
We accepted this cost because secure systems save far more by avoiding reputational and legal damage later.

---

## Week-by-Week Timeline

| Week | Summary | Contributor(s) | Evidence |
|------|----------|-------------|--------------|
| 0 | Project planning & assessment briefing, SSDLC overview | DevTest + wh | (meeting notes) |
| 1 | Environment setup (.NET, Git), sample API working | DevTest | week1/1.png, 2.png |
| 2 | GitHub repo + branch/PR workflow | DevTest + wh | week2/3–6.png |
| 3 | Security requirements documented | DevTest (wrote), wh (reviewed) | week3/7–9.png |
| 4 | Threat modelling (diagram + STRIDE) | DevTest (made), wh (reviewed) | week4/10–11.png |
| 5 | Implemented API (secure coding) | DevTest | week5/12.png |
| 6 | Manual security code review | DevTest (review), wh (approved) | week6/13.png |
| 7 | CI pipeline for build + security scan | DevTest (DevSecOps), wh (verified) | week7/14–17.png |
| 8 | Documentation + practice journal draft | DevTest (wrote), wh (reviewed) | (journal draft) |
| 9 | Security economics + final cleanup | DevTest (analysis), wh (checked) | (final repo) |
| 10 | Final polish and review against marking grid | DevTest + wh | (review screenshots) |
| 11 | Submission of project + journal | DevTest | (GitHub link submitted) |

---

## Conclusion
This journal evidences my contribution to the development of a secure system using SSDLC practices, and demonstrates skills across teamwork, problem-solving, secure coding, security testing, and DevSecOps.  
It also reflects on security economics and how secure design impacts project cost, risk, and quality.  
The project was successfully finalised, reviewed, and submitted for assessment.

