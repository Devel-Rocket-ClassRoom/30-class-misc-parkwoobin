using System;

var basicQuery = new QueryBuilder()
    .Select("*")
    .From("Users")
    .Build();

Console.WriteLine("=== 기본 쿼리 ===");
Console.WriteLine(basicQuery);
Console.WriteLine();

var conditionQuery = new QueryBuilder()
    .Select("Name, Age")
    .From("Users")
    .Where("Age > 18")
    .Build();

Console.WriteLine("=== 조건 쿼리 ===");
Console.WriteLine(conditionQuery);
Console.WriteLine();

var sortedQuery = new QueryBuilder()
    .Select("*")
    .From("Products")
    .Where("Price > 1000")
    .OrderBy("Price")
    .Build();

Console.WriteLine("=== 정렬 쿼리 ===");
Console.WriteLine(sortedQuery);

public class QueryBuilder
{
    private string selectClause;
    private string fromClause;
    private string whereClause;
    private string orderByClause;

    public QueryBuilder Select(string columns)
    {
        selectClause = $"SELECT {columns}";
        return this;
    }

    public QueryBuilder From(string table)
    {
        fromClause = $"FROM {table}";
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        whereClause = $"WHERE {condition}";
        return this;
    }

    public QueryBuilder OrderBy(string column)
    {
        orderByClause = $"ORDER BY {column}";
        return this;
    }

    public string Build()
    {
        var query = $"{selectClause} {fromClause}";

        if (!string.IsNullOrWhiteSpace(whereClause))
        {
            query += $" {whereClause}";
        }

        if (!string.IsNullOrWhiteSpace(orderByClause))
        {
            query += $" {orderByClause}";
        }

        return query;
    }
}
