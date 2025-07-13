Objective:
To demonstrate JSON Web Token (JWT) based authentication and role-based authorization using Web API and Postman.

Steps Performed:
Enabled JWT Authentication in Program.cs with AddAuthentication() and AddJwtBearer() configuration.

Created an AuthController with a method GenerateToken to return a valid JWT.

Generated token by hitting /api/Auth/GenerateToken using Swagger.

Used the JWT in Postman to call GET /Employee/GetStandard with different scenarios:

Valid token → returned employee data with 200 OK.

Invalid token → resulted in 401 Unauthorized.

Expired token (after 2 mins) → also showed 401 Unauthorized.

Role-based check using [Authorize(Roles = "POC")] with Admin token → 401 Unauthorized.

Added Admin,POC roles → access granted → 200 OK.

Output:
6 screenshots showing Swagger token generation, valid and invalid token usage, role-based authorization.

