# Entity Splitting

This repro contains the sample project for my Stack Overflow question at:
http://stackoverflow.com/questions/34616449/entity-splitting-across-three-tables-with-two-different-keys

## Usage

1. Clone the repro.
2. Run the `script/create database.sql` script to create the database and populate it with a sample user.
3. Open and build the solution in Visual Studio.
4. Load the `Data` assembly into LinqPad and try to query the `Users` DbSet.
5. You should get the following error:

> Properties for type 'User' can only be mapped once. The non-key property 'Id' is mapped more than once. Ensure the Properties method specifies each non-key property only once.
