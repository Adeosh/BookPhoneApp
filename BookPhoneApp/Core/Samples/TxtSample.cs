namespace BookPhoneApp.Core.Samples
{
    public class TxtSample
    {
        public string Text { get; set; }
        public string SQL { get; set; }

        public TxtSample()
        {
            Text = "" +
                "BEGIN TRANSACTION;" +
                "-- Insert Person 1\r\n" +
                "INSERT INTO Persons (FirstName, MiddleName, LastName)\r\n" +
                "VALUES ('John', 'Michael', 'Doe');\r\n\r\n" +
                "-- Declare and retrieve PersonId for Person 1\r\n" +
                "DECLARE @PersonId1 BIGINT;\r\n" +
                "SET @PersonId1 = SCOPE_IDENTITY();\r\n\r\n" +
                "-- Insert Phone number for Person 1\r\n" +
                "INSERT INTO Phone (PhoneNumber, PersonId)\r\n" +
                "VALUES ('555-123-4567', @PersonId1);\r\n\r\n" +
                "-- Insert Address for Person 1\r\n" +
                "INSERT INTO Address (AddressOf, PersonId)\r\n" +
                "VALUES ('123 Main Street', @PersonId1);\r\n\r\n" +
                "-- Insert BirthDate for Person 1\r\n" +
                "INSERT INTO BirthDate (BirthDate, PersonId)\r\n" +
                "VALUES ('1980-01-01', @PersonId1);\r\n\r\n" +
                "-- Insert Person 2\r\n" +
                "INSERT INTO Persons (FirstName, MiddleName, LastName)\r\n" +
                "VALUES ('Jane', 'Anne', 'Smith');\r\n\r\n" +
                "-- Declare and retrieve PersonId for Person 2\r\n" +
                "DECLARE @PersonId2 BIGINT;\r\n" +
                "SET @PersonId2 = SCOPE_IDENTITY();\r\n\r\n" +
                "-- Insert Phone number for Person 2\r\n" +
                "INSERT INTO Phone (PhoneNumber, PersonId)\r\n" +
                "VALUES ('555-789-0123', @PersonId2);\r\n\r\n" +
                "-- Insert Address for Person 2\r\n" +
                "INSERT INTO Address (AddressOf, PersonId)\r\n" +
                "VALUES ('456 Elm Street', @PersonId2);\r\n\r\n" +
                "-- Insert BirthDate for Person 2\r\n" +
                "INSERT INTO BirthDate (BirthDate, PersonId)\r\n" +
                "VALUES ('1975-12-31', @PersonId2);\r\n" +
                "COMMIT TRANSACTION;";

            SQL = "" + 
                "INSERT INTO Persons (FirstName, MiddleName, LastName) " +
                "VALUES ('Bettie', 'Skyler', 'Hyatt');\r\n" +
                "DECLARE @PersonId BIGINT;\r\n" +
                "SET @PersonId = SCOPE_IDENTITY();\r\n" +
                "INSERT INTO Phone (PhoneNumber, PersonId) " +
                "VALUES ('501-766-663', @PersonId);\r\n" +
                "INSERT INTO Address (AddressOf, PersonId) " +
                "VALUES ('8294 Norris Pike', @PersonId);\r\n" +
                "INSERT INTO BirthDate (BirthDate, PersonId) " +
                "VALUES ('1975-11-23', @PersonId);\r\n\r\n" +
                "INSERT INTO Persons (FirstName, MiddleName, LastName) " +
                "VALUES ('Kol', 'Faston', 'Almaz');\r\n" +
                "DECLARE @PersonId2 BIGINT;\r\n" +
                "SET @PersonId2 = SCOPE_IDENTITY();\r\n" +
                "INSERT INTO Phone (PhoneNumber, PersonId) " +
                "VALUES ('501-766-721', @PersonId2);\r\n" +
                "INSERT INTO Address (AddressOf, PersonId) " +
                "VALUES ('11 Norris Lake', @PersonId2);\r\n" +
                "INSERT INTO BirthDate (BirthDate, PersonId) " +
                "VALUES ('2001-11-23', @PersonId2);";
        }

    }
}
