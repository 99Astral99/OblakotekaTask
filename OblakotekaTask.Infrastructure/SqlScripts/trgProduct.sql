CREATE TRIGGER trg_Product_Audit
ON Product
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EventDescription NVARCHAR(MAX);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        SET @EventDescription = 'Product record(s) inserted/updated.';
    END
    ELSE
    BEGIN
        SET @EventDescription = 'Product record(s) deleted.';
    END

    INSERT INTO EventLog (ID, EventDate, Description)
    VALUES (NEWID(), GETDATE(), @EventDescription);
END
GO