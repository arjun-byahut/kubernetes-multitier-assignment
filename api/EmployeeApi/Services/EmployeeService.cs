using EmployeeApi.Models;
using Npgsql;

namespace EmployeeApi.Services;

public class EmployeeService
{
    private readonly IConfiguration _configuration;

    public EmployeeService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<Employee>> GetEmployees()
    {
        var employees = new List<Employee>();

        var connectionString =
            $"Host={Environment.GetEnvironmentVariable("DB_HOST")};" +
            $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
            $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
            $"Username={Environment.GetEnvironmentVariable("DB_USER")};" +
            $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}";

        await using var conn = new NpgsqlConnection(connectionString);

        await conn.OpenAsync();

        var cmd = new NpgsqlCommand(
            "SELECT id,name,department FROM employees",
            conn);

        await using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            employees.Add(new Employee
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Department = reader.GetString(2)
            });
        }

        return employees;
    }
}