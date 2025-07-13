## HandsOn 4 – Web API CRUD Operation

### Objective:
To demonstrate `Create`, `Update`, and `Delete` operations using a Web API with a custom model.

### Steps Performed:

- Continued from the project created in HandsOn 3.
- Used `[HttpPut]` action method to update Employee data based on input ID.
- Used `[FromBody]` attribute to bind complex JSON input to the model.
- Implemented validations to return appropriate status codes (`400 BadRequest`).
- Tested the API using Swagger UI with sample JSON payload.
- Returned the updated employee data as the response.

### Output:
![PUT Success](./Outputs/Handson4_Output.png)
