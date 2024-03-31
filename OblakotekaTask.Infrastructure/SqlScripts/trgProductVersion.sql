CREATE TRIGGER trg_ProductVersion_Audit
ON ProductVersion
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EventDescription NVARCHAR(MAX);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        SET @EventDescription = 'ProductVersion record(s) inserted/updated.';
    END
    ELSE
    BEGIN
        SET @EventDescription = 'ProductVersion record(s) deleted.';
    END

    INSERT INTO EventLog (ID, EventDate, Description)
    VALUES (NEWID(), GETDATE(), @EventDescription);
END
GO