INSERT INTO Product (ID, Name, Description)
VALUES 
    (NEWID(), 'Стул', 'Удобное и стильное кресло'),
    (NEWID(), 'Стол', 'Прочный и элегантный стол'),
    (NEWID(), 'Диван', 'Мягкий и уютный диван'),
    (NEWID(), 'Шкаф', 'Вместительный шкаф для хранения'),
    (NEWID(), 'Кресло', 'Комфортное кресло для отдыха'),
    (NEWID(), 'Кровать', 'Удобная кровать для сна'),
    (NEWID(), 'Стеллаж', 'Функциональный стеллаж для книг и декора'),
    (NEWID(), 'Стул-качалка', 'Современное кресло-качалка'),
    (NEWID(), 'Письменный стол', 'Удобный стол для работы и учебы'),
    (NEWID(), 'Пуф', 'Мягкий и стильный пуф для отдыха');


INSERT INTO ProductVersion (ID, ProductID, Name, Description, Width, Height, Length)
VALUES 
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Стул'), 'Classic', 'Классический стул', 45.0, 55.0, 50.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Стол'), 'Oak', 'Деревянный стол из дуба', 120.0, 70.0, 90.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Диван'), 'Luxury', 'Роскошный диван с мягкой обивкой', 220.0, 100.0, 80.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Шкаф'), 'Wardrobe', 'Просторный гардеробный шкаф', 180.0, 200.0, 60.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Кресло'), 'Recliner', 'Эргономичное кресло-релакс', 80.0, 90.0, 100.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Кровать'), 'King Size', 'Кровать King Size с ортопедическим матрасом', 200.0, 180.0, 160.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Стеллаж'), 'Modern', 'Современный стеллаж из металла и стекла', 100.0, 220.0, 40.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Стул-качалка'), 'Rocking Chair', 'Удобное кресло-качалка с подлокотниками', 60.0, 70.0, 80.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Письменный стол'), 'Workspace', 'Рабочий стол с выдвижными ящиками', 150.0, 80.0, 70.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = 'Пуф'), 'Round', 'Круглый пуф с текстильной обивкой', 50.0, 50.0, 50.0);
