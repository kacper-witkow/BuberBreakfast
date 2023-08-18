using BuberBreakfast.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BuberBreakfast.Database
{
    public class BreakfastDatabase : Idatabase
    {
        SqliteConnection _connection;
        public BreakfastDatabase(string Connectionstring)
        {
            _connection = new SqliteConnection("Data Soruce=" + Connectionstring);

        }

        public void UpdateDatabase(SqliteCommand command)
        {

            _connection.Open();
            // TODO Add loggger


            command.ExecuteReader();

            _connection.Close();
        }
        public void DeleteBreakfast(int Id)
        {
            var command = _connection.CreateCommand();
            command.CommandText =
            @"
                DELETE FROM breakfast
                WHERE id = $id
            ";
            command.Parameters.AddWithValue("$id", Id);

            UpdateDatabase(command);

        }

        public Breakfast GetBreakfast(int Id)
        {
            var command = _connection.CreateCommand();
            command.CommandText =
            @" Select * from breakfast
                WHERE Id=$id
            ";
            command.Parameters.AddWithValue("$id", Id);

            var respond = new Breakfast();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                        respond.Id = reader.GetInt32(0);
                        respond.Name = reader.GetString(1);
                        respond.Description = reader.GetString(2);
                    DateTime tmp;
                    if (DateTime.TryParse(reader.GetString(3),out tmp))
                        respond.StartDateTime = tmp;
                    if (DateTime.TryParse(reader.GetString(3), out tmp))
                        respond.EndDateTime = tmp;
                    if (DateTime.TryParse(reader.GetString(3), out tmp))
                        respond.LastModifiedDateTime = tmp;

                }
            }
            return respond;
        }

        public void InstertBreakfast(DbBreakfast breakfast)
        {
            var command = _connection.CreateCommand();
            command.CommandText =
            @"
                INSTER INTO breakfast (Name,Description,StartDateTime,EndtDateTime,LastModifiedDateTime,Sweet,Savory)
                VALUES (
                $Name,
                $Description,
                $StartDateTime,
                $EndtDateTime,
                $LastModifiedDateTime,
                $Sweet,
                $Savory)
            ";
            command.Parameters.AddWithValue("$Name", breakfast.Name);
            command.Parameters.AddWithValue("$Description", breakfast.Description);
            command.Parameters.AddWithValue("$StartDateTime", breakfast.StartDateTime);
            command.Parameters.AddWithValue("$EndtDateTime", breakfast.EndDateTime);
            command.Parameters.AddWithValue("$LastModifiedDateTime", breakfast.LastModifiedDateTime);
            command.Parameters.AddWithValue("$Sweet", breakfast.Sweet);
            command.Parameters.AddWithValue("$Savory", breakfast.Savory);


            UpdateDatabase(command);
        }
    }
}
