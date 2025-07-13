## HandsOn 3 – Web API Using Custom Model, Authorization Filter & Exception Filter

### Objective:
- Create a Web API that returns a custom `Employee` object.
- Implement custom Authorization and Exception filters.
- Test API using Swagger with headers and exception scenarios.

### Steps Performed:

1. **Created Models**: `Employee`, `Department`, and `Skill` classes.
2. **Created Controller**: `EmployeeController` with GET and POST methods using `[HttpGet]`, `[HttpPost]`, and `[FromBody]`.
3. **Created Filters**:
   - `CustomAuthFilter`: Checks for `Authorization` header containing "Bearer".
   - `CustomExceptionFilter`: Catches and logs unhandled exceptions.
4. **Configured Filters**: Added them to the controller using attributes.
5. **Tested using Swagger**:
   - Performed GET without token – showed error.
   - Added token and received employee list.
   - Sent POST data and received it back.
   - Threw an exception and logged it to `error_log.txt`.

### Output:

| Step                           | Screenshot                              |
|--------------------------------|------------------------------------------|
| GET without Authorization      | ![Output1](./Output/output1.png)         |
| GET with Authorization         | ![Output2](./Output/output2.png)         |
| POST – Input                   | ![Output3_1](./Output/output3_1.png)         |
| POST – Response                | ![Output3_2](./Output/output3_2.png)         |
| Exception – 500 Error          | ![Output4](./Output/output4.png)         |
| Exception – error_log.txt File | ![Output5](./Output/output5.png)         |
