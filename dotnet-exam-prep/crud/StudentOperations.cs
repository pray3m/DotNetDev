using System;

class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Major { get; set; }
}

class DbConnection{
    private readonly string _connectionString;
    
}