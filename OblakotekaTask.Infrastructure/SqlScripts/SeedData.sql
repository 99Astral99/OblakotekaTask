INSERT INTO Product (ID, Name, Description)
VALUES 
    (NEWID(), 'Chair', 'Comfortable and stylish armchair'),
    (NEWID(), 'Table', 'A sturdy and elegant table'),
    (NEWID(), 'Sofa', 'A soft and cozy sofa'),
    (NEWID(), 'Wardrobe', 'Spacious storage cabinet'),
    (NEWID(), 'Armchair', 'A comfortable lounge chair'),
    (NEWID(), 'Bed', 'Comfortable bed for sleeping'),
    (NEWID(), 'Shelf', 'Functional bookshelf and decor'),
    (NEWID(), 'Rocking chair', 'Modern rocking chair'),
    (NEWID(), 'Desk', 'A comfortable desk for work and study'),
    (NEWID(), 'Padded stool', 'A soft and stylish padded stool for relaxing');


INSERT INTO ProductVersion (ID, ProductID, Name, Description, Width, Height, Length)
VALUES 
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Chair'), 'Classic', 'Classic chair', 45.0, 55.0, 50.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Table'), 'Oak', 'Wooden table made of oak', 120.0, 70.0, 90.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Sofa'), 'Luxury', 'Luxury sofa with upholstered upholstery', 220.0, 100.0, 80.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Wardrobe'), 'Wardrobe classic', 'Spacious wardrobe', 180.0, 200.0, 60.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Armchair'), 'Recliner', 'Ergonomic relaxation chair', 80.0, 90.0, 100.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Bed'), 'King Size', 'King Size bed with orthopedic mattress', 200.0, 180.0, 160.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Shelf'), 'Modern', 'Modern metal and glass shelving', 100.0, 220.0, 40.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Rocking chair'), 'Classic', 'Comfortable rocking chair with armrests', 60.0, 70.0, 80.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Desk'), 'Workspace', 'Work desk with drawers', 150.0, 80.0, 70.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Padded stool'), 'Round', 'Round pouf with textile upholstery', 50.0, 50.0, 50.0);
