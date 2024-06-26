CREATE FUNCTION SearchProductVersions
(
    @ProductName NVARCHAR(100),
    @VersionName NVARCHAR(100),
    @MinVolume FLOAT,
    @MaxVolume FLOAT
)
RETURNS TABLE
AS
RETURN
(
    SELECT pv.ID, 
	p.Name AS ProductName, 
	pv.Name AS VersionName, 
	pv.Description, 
	pv.Width, 
	pv.Height, 
	pv.Length
	
    FROM Product p
    JOIN ProductVersion pv ON p.ID = pv.ProductID
    WHERE p.Name = @ProductName
    AND pv.Name = @VersionName
    AND (@MinVolume IS NULL OR (pv.Width * pv.Height * pv.Length) >= @MinVolume)
    AND (@MaxVolume IS NULL OR (pv.Width * pv.Height * pv.Length) <= @MaxVolume)
);
