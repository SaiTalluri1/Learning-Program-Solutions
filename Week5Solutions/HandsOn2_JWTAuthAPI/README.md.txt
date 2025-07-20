Hands-On 2 – JWT Authentication in ASP.NET Core Web API

## Author: Sai

Prerequisites
- .NET SDK installed
- Visual Studio Code / Visual Studio
- Postman or Swagger for API testing

---

Setup Instructions

1. Clone or create the ASP.NET Core Web API project.
2. Add JWT NuGet packages:
   - `Microsoft.AspNetCore.Authentication.JwtBearer`
3. Configure `Jwt:Key`, `Jwt:Issuer`, `Jwt:Audience` in `appsettings.json`.
4. Create `AuthController.cs` to generate JWT token.
5. Create a secure endpoint in `TestController.cs`.
6. Configure JWT authentication in `Program.cs`.
7. Test using:
   - `POST /api/auth/login` – Get JWT token.
   - `GET /api/test/secure-data` – Without token → 401 Unauthorized.
   - `GET /api/test/secure-data` – With token → Success message.

---

### 📸 Screenshots

1. TokenGenerated.png** – JWT token generated from `/api/auth/login`
2. Unauthorized.png** – 401 error when accessing secure endpoint without token
3. AccessGranted.png** – Successfully accessing `/api/test/secure-data` with token

Output

json
"This is a protected endpoint!"
