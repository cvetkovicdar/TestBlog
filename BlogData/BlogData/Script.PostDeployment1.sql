/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT Posts ON
MERGE INTO Posts AS Target
USING ( VALUES 
        (1, 'Title1', '2019-12-31', 'DC'),
        (2, 'Neki Naslov', '2020-01-02', 'IvanRDVC'),
        (3, 'Ozbiljan Title', '2020-01-05', 'Hogar Strasni')
)
AS Source (Id, Title, Date, Authors)
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN
INSERT (Id, Title, Date, Authors)
VALUES (Id, Title, Date, Authors);
SET IDENTITY_INSERT Posts OFF