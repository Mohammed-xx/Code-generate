﻿using System.Reflection;
using Microsoft.Data.SqlClient;
namespace Code_Generate.DA
{
    public class DataBaseInfo
    {
        public class DatabaseSchema
        {
            public string DatabaseName { get; set; }
            public List<TableInfo> Tables { get; set; }
        }
        public class TableInfo
        {
            public string TableName { get; set; }
            public List<ColumnInfo> Columns { get; set; }
        }
        public class ColumnInfo
        {
            public string ColumnName { get; set; }
            public string DataType { get; set; }
            public bool IsNullable { get; set; }
            public int? MaxCharacters { get; set; }
            public byte NumberOfColumn { get; set; }
        }
        public class clsDatabaseInfoData
        {
            private static string SourceName = Assembly.GetExecutingAssembly().GetName().Name;
            private static string ConnectionString = clsSettingsDataAccess.ConnectionString;

            //"يستدعي جميع اسماء الداتا بيز"
            public static List<string> GetDatabases()
            {
                List<string> DatabasesName = new List<string>();
                string qurey = @"SELECT name FROM sys.databases
                   WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(qurey, connection))
                {

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dbName = reader.GetString(0); // Get the value from the first column
                                DatabasesName.Add(dbName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                return DatabasesName;
            }

            //"يستدعي جميع اسماء الجداول"
            public static List<string> GetTables(string selectedDatabase)
            {
                List<string> TablesName = new List<string>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $@"USE {selectedDatabase};
                              SELECT name FROM sys.tables
                              WHERE name NOT IN ('sysdiagrams')";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string tableName = reader.GetString(0); // Get the value from the first column
                                    TablesName.Add(tableName); // Add the table name to the list
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                return TablesName;
            }

            //"يستدعي جميع معلومات الكولومز داخل الجدول"
            public static List<ColumnInfo> GetColumns(string selectedDatabase, string tableName)
            {
                List<ColumnInfo> columns = new List<ColumnInfo>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $@"USE {selectedDatabase};
                              SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE, CHARACTER_MAXIMUM_LENGTH 
                              FROM INFORMATION_SCHEMA.COLUMNS
                              WHERE TABLE_NAME = '{tableName}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                byte columnNumber = 0;

                                while (reader.Read())
                                {
                                    columns.Add(new ColumnInfo
                                    {
                                        ColumnName = reader["COLUMN_NAME"].ToString(),
                                        DataType = reader["DATA_TYPE"].ToString(),
                                        IsNullable = reader["IS_NULLABLE"].ToString() == "YES",
                                        MaxCharacters = reader["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value ? (int?)Convert.ToInt32(reader["CHARACTER_MAXIMUM_LENGTH"]) : null,
                                        NumberOfColumn = ++columnNumber
                                    });
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);     
                        }
                    }
                }

                return columns;
            }

            //"استدعاء جميع الداتا بيزس مع جداولهم و معلوماتهم"
            public static List<DatabaseSchema> GetAllDatabaseSchemas()
            {
                List<DatabaseSchema> schemas = new List<DatabaseSchema>();
                var databases = GetDatabases();

                foreach (var database in databases)
                {
                    var schema = new DatabaseSchema
                    {
                        DatabaseName = database,
                        Tables = new List<TableInfo>()
                    };

                    var tables = GetTables(database);
                    foreach (var tableName in tables)
                    {
                        var table = new TableInfo
                        {
                            TableName = tableName,
                            Columns = GetColumns(database, tableName)
                        };

                        schema.Tables.Add(table);
                    }

                    schemas.Add(schema);
                }

                return schemas;
            }
        }
    }
}
