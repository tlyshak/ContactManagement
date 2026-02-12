using System;
using System.Collections.Generic;
using ContactManagement.Application.Interfaces.DataAccess;
using ContactManagement.Application.Interfaces.Repositories;
using System.Data.SQLite;
using System.Data;
using ContactManagement.Application.Models;

namespace ContactManagement.Infrastructure.DataAccess.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public ContactRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IList<Contact> GetContacts(string search, string category, string sort)
        {
            string orderBy;

            switch (sort)
            {
                case "Name Z-A":
                    orderBy = "last_name DESC, first_name DESC";
                    break;

                case "Newest":
                    orderBy = "created_at DESC";
                    break;

                case "Oldest":
                    orderBy = "created_at ASC";
                    break;

                default:
                    orderBy = "last_name ASC, first_name ASC";
                    break;
            }
            using (var connection = (SQLiteConnection)_connectionFactory.Create())
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = $@"
                    SELECT id,
                           first_name,
                           last_name,
                           email,
                           phone,
                           category,
                           company,
                           website,
                           notes,
                           address,
                           avatar_path,
                           created_at
                    FROM contacts
                    WHERE
                        (@search IS NULL OR
                         first_name LIKE @searchLike OR
                         last_name LIKE @searchLike)
                    AND
                        (@category IS NULL OR category = @category)
                    ORDER BY {orderBy};";

                // search
                if (string.IsNullOrWhiteSpace(search))
                {
                    cmd.Parameters.Add("@search", DbType.String).Value = DBNull.Value;
                    cmd.Parameters.Add("@searchLike", DbType.String).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@search", DbType.String).Value = search;
                    cmd.Parameters.Add("@searchLike", DbType.String).Value = "%" + search + "%";
                }

                // category
                if (string.IsNullOrWhiteSpace(category) || category == "All")
                    cmd.Parameters.Add("@category", DbType.String).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@category", DbType.String).Value = category;

                using (var reader = cmd.ExecuteReader())
                {
                    var contacts = new List<Contact>();

                    while (reader.Read())
                    {
                        contacts.Add(new Contact
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Email = reader.GetString(3),

                            Phone = reader.IsDBNull(4) ? null : reader.GetString(4),

                            Category = (ContactCategory)Enum.Parse(
                                typeof(ContactCategory),
                                reader.GetString(5)),

                            Company = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Website = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Notes = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Address = reader.IsDBNull(9) ? null : reader.GetString(9),
                            AvatarPath = reader.IsDBNull(10) ? null : reader.GetString(10),

                            CreatedAt = DateTime.Parse(reader.GetString(11))
                        });
                    }

                    return contacts;
                }
            }
        }

        public void RemoveContact(int id)
        {
            using (var connection = (SQLiteConnection)_connectionFactory.Create())
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = @"
                    DELETE FROM contacts
                    WHERE id = @id;";

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public int CreateContact(Contact contact)
        {
            using (var connection = (SQLiteConnection)_connectionFactory.Create())
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = @"
                    INSERT INTO contacts
                    (
                        first_name,
                        last_name,
                        email,
                        phone,
                        category,
                        company,
                        website,
                        notes,
                        address
                    )
                    VALUES
                    (
                        @firstName,
                        @lastName,
                        @email,
                        @phone,
                        @category,
                        @company,
                        @website,
                        @notes,
                        @address
                    );
                    SELECT last_insert_rowid();";

                cmd.Parameters.Add("@firstName", DbType.String).Value = contact.FirstName;
                cmd.Parameters.Add("@lastName", DbType.String).Value = contact.LastName;
                cmd.Parameters.Add("@email", DbType.String).Value = contact.Email;

                cmd.Parameters.Add("@phone", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Phone) ? (object)DBNull.Value : contact.Phone;

                cmd.Parameters.Add("@category", DbType.String).Value = contact.Category.ToString();

                cmd.Parameters.Add("@company", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Company) ? (object)DBNull.Value : contact.Company;

                cmd.Parameters.Add("@website", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Website) ? (object)DBNull.Value : contact.Website;

                cmd.Parameters.Add("@notes", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Notes) ? (object)DBNull.Value : contact.Notes;

                cmd.Parameters.Add("@address", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Address) ? (object)DBNull.Value : contact.Address;

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void UpdateContact(Contact contact)
        {
            using (var connection = (SQLiteConnection)_connectionFactory.Create())
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = @"
                    UPDATE contacts
                    SET
                        first_name = @firstName,
                        last_name  = @lastName,
                        email      = @email,
                        phone      = @phone,
                        category   = @category,
                        company    = @company,
                        website    = @website,
                        notes      = @notes,
                        address    = @address
                    WHERE id = @id;";

                cmd.Parameters.Add("@id", DbType.Int32).Value = contact.Id;

                cmd.Parameters.Add("@firstName", DbType.String).Value = contact.FirstName;
                cmd.Parameters.Add("@lastName", DbType.String).Value = contact.LastName;
                cmd.Parameters.Add("@email", DbType.String).Value = contact.Email;

                cmd.Parameters.Add("@phone", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Phone) ? (object)DBNull.Value : contact.Phone;

                cmd.Parameters.Add("@category", DbType.String).Value = contact.Category.ToString();

                cmd.Parameters.Add("@company", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Company) ? (object)DBNull.Value : contact.Company;

                cmd.Parameters.Add("@website", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Website) ? (object)DBNull.Value : contact.Website;

                cmd.Parameters.Add("@notes", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Notes) ? (object)DBNull.Value : contact.Notes;

                cmd.Parameters.Add("@address", DbType.String).Value =
                    string.IsNullOrWhiteSpace(contact.Address) ? (object)DBNull.Value : contact.Address;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
