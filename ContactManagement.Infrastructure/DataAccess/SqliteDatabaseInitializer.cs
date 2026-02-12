using System.Data;
using System;
using System.Data.SQLite;
using System.IO;
using ContactManagement.Application.Interfaces.DataAccess;
using ContactManagement.Application.Models;

namespace ContactManagement.Infrastructure.DataAccess
{
    public class SqliteDatabaseInitializer : IDatabaseInitializer
    {
        private readonly IDbConnectionFactory _factory;

        public SqliteDatabaseInitializer(IDbConnectionFactory factory)
        {
            _factory = factory;
        }

        public void Initialize()
        {
            var dbPath = _factory.DataSource;

            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var connection = (SQLiteConnection)_factory.Create())
                {
                    connection.Open();
                    var sql = File.ReadAllText("SQL/001_create_schema.sql");
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void SeedDemoData()
        {
            using (var connection = (SQLiteConnection)_factory.Create())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    using (var check = connection.CreateCommand())
                    {
                        check.Transaction = transaction;
                        check.CommandText = "SELECT 1 FROM contacts LIMIT 1;";

                        var exists = check.ExecuteScalar();
                        if (exists != null)
                        {
                            transaction.Commit();
                            return;
                        }
                    }

                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.Transaction = transaction;

                        cmd.CommandText = @"
                        INSERT INTO contacts
                        (
                            first_name,
                            last_name,
                            email,
                            phone,
                            category,
                            created_at,
                            company,
                            website,
                            notes,
                            address,
                            avatar_path
                        )
                        VALUES
                        (
                            @firstName,
                            @lastName,
                            @email,
                            @phone,
                            @category,
                            CURRENT_TIMESTAMP,
                            @company,
                            @website,
                            @notes,
                            @address,
                            @avatarPath
                        );";

                        cmd.Parameters.Add("@firstName", DbType.String);
                        cmd.Parameters.Add("@lastName", DbType.String);
                        cmd.Parameters.Add("@email", DbType.String);
                        cmd.Parameters.Add("@phone", DbType.String);
                        cmd.Parameters.Add("@category", DbType.String);
                        cmd.Parameters.Add("@company", DbType.String);
                        cmd.Parameters.Add("@website", DbType.String);
                        cmd.Parameters.Add("@notes", DbType.String);
                        cmd.Parameters.Add("@address", DbType.String);
                        cmd.Parameters.Add("@avatarPath", DbType.String);

                        void InsertContact(
                            string firstName,
                            string lastName,
                            string email,
                            string phone,
                            ContactCategory category,
                            string company,
                            string website,
                            string notes,
                            string address,
                            string avatarPath)
                        {
                            cmd.Parameters["@firstName"].Value = firstName;
                            cmd.Parameters["@lastName"].Value = lastName;
                            cmd.Parameters["@email"].Value = email;
                            cmd.Parameters["@phone"].Value =
                                string.IsNullOrWhiteSpace(phone) ? (object)DBNull.Value : phone;

                            cmd.Parameters["@category"].Value = category.ToString();

                            cmd.Parameters["@company"].Value =
                                string.IsNullOrWhiteSpace(company) ? (object)DBNull.Value : company;

                            cmd.Parameters["@website"].Value =
                                string.IsNullOrWhiteSpace(website) ? (object)DBNull.Value : website;

                            cmd.Parameters["@notes"].Value =
                                string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes;

                            cmd.Parameters["@address"].Value =
                                string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address;

                            cmd.Parameters["@avatarPath"].Value = 
                                string.IsNullOrWhiteSpace(avatarPath) ? (object)DBNull.Value : avatarPath;

                            cmd.ExecuteNonQuery();
                        }

                        InsertContact(
                            "Lucas", "Miller", "lucas.miller@mail.com", "+1 555 1007",
                            ContactCategory.Business,
                            "Bright Solutions", "https://brightsolutions.com",
                            "Client from last project", "Chicago, USA", "Assets\\Avatars\\avatar1.png");

                        InsertContact(
                            "Noah", "Lee", "noah.lee@mail.com", "+1 555 1011",
                            ContactCategory.Business,
                            "TechNova", "https://technova.dev",
                            "Met at meetup", "Seattle, USA", "Assets\\Avatars\\avatar2.png");

                        InsertContact(
                            "Oliver", "Martinez", "oliver.m@mail.com", "+1 555 1009",
                            ContactCategory.Business,
                            "MarketHub", "https://markethub.io",
                            null, "San Francisco, USA", "Assets\\Avatars\\avatar5.png");

                        InsertContact(
                            "James", "Young", "james.young@mail.com", "+1 555 1014",
                            ContactCategory.Business,
                            "FinCore", "https://fincore.com",
                            null, "New York, USA", "Assets\\Avatars\\avatar6.png");

                        InsertContact(
                            "William", "Hall", "will.hall@mail.com", "+1 555 1013",
                            ContactCategory.Business,
                            "LogistiCo", null,
                            "Supplier contact", "Dallas, USA", "Assets\\Avatars\\avatar7.png");

                        InsertContact(
                            "Sophia", "Garcia", "sophia.garcia@mail.com", "+1 555 1010",
                            ContactCategory.Family,
                            null, null,
                            "Cousin", "Madrid, Spain", "Assets\\Avatars\\avatar3.png");

                        InsertContact(
                            "Ava", "Walker", "ava.walker@mail.com", "+1 555 1012",
                            ContactCategory.Private,
                            null, "https://avawalker.blog",
                            null, "Denver, USA", null);

                        InsertContact(
                            "Isabella", "Allen", "isabella.allen@mail.com", "+1 555 1013",
                            ContactCategory.Family,
                            null, null,
                            "Family friend", "Toronto, Canada", "Assets\\Avatars\\avatar4.png");

                    }
                    transaction.Commit();
                }
            }
        }
    }
}
