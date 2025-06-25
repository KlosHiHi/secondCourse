class QueryBuilder
{
    private string _select = "";
    private string _from = "";
    private string _where = "";
    private string _orderBy = "";

    public QueryBuilder(string dataSet)
    {
        _select = "SELECT *";
        _from = $"FROM {dataSet}";
    }

    public string Build() 
        => string.Join(" ", _select, _from, _where, _orderBy);

    public QueryBuilder Select(string columns)
    {
        _select = $"SELECT {columns}";
        return this;
    }

    public QueryBuilder OrderBy(string columns)
    {
        _select = $"ORDER BY {columns}";
        return this;
    }

    public QueryBuilder Where(string expression)
    {
        _where = $"WHERE {expression}";
        return this;
    }
}
