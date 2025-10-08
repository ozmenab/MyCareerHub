# MyCareerHub

A mini job-board built with **ASP.NET Core 8** to showcase full-stack .NET skills for job applications.

🔗 Live Demo: *(coming soon)*  
🧪 Test Results: *(coming soon)*  
📦 Docker: *(coming soon)*

---

## ✨ Features

| Area | Functionality | Status |
|------|---------------|--------|
| Identity | Register / Login (JobSeeker & Company & Admin) | ✅ |
| Roles | Role-based authorization | ✅ |
| Jobs | CRUD operations for job posts | ✅ |
| Applications | Apply to a job | ✅ |
| Admin | Manage users & jobs | ✅ |
| API | RESTful endpoints with Swagger | ✅ |
| Tests | Unit & Integration tests | ✅ |
| CI/CD | GitHub Actions → Azure | ✅ |

---

## 🧱 Tech Stack

- **ASP.NET Core 8** (Razor Pages + Web API)
- **Entity Framework Core** (SQLite → PostgreSQL)
- **ASP.NET Core Identity** (role-based auth)
- **FluentValidation**
- **xUnit + Moq** for testing
- **GitHub Actions** for CI/CD
- **Azure App Service** for hosting
- **Docker** support

---

## 🚀 Quick Start (Local)

```bash
git clone https://github.com/ozmenab/MyCareerHub.git
cd MyCareerHub
dotnet restore
dotnet ef database update
dotnet run
