INSERT INTO Product (ID, Name, Description)
VALUES 
    (NEWID(), '����', '������� � �������� ������'),
    (NEWID(), '����', '������� � ���������� ����'),
    (NEWID(), '�����', '������ � ������ �����'),
    (NEWID(), '����', '������������� ���� ��� ��������'),
    (NEWID(), '������', '���������� ������ ��� ������'),
    (NEWID(), '�������', '������� ������� ��� ���'),
    (NEWID(), '�������', '�������������� ������� ��� ���� � ������'),
    (NEWID(), '����-�������', '����������� ������-�������'),
    (NEWID(), '���������� ����', '������� ���� ��� ������ � �����'),
    (NEWID(), '���', '������ � �������� ��� ��� ������');


INSERT INTO ProductVersion (ID, ProductID, Name, Description, Width, Height, Length)
VALUES 
    (NEWID(), (SELECT ID FROM Product WHERE Name = '����'), 'Classic', '������������ ����', 45.0, 55.0, 50.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '����'), 'Oak', '���������� ���� �� ����', 120.0, 70.0, 90.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '�����'), 'Luxury', '��������� ����� � ������ �������', 220.0, 100.0, 80.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '����'), 'Wardrobe', '���������� ����������� ����', 180.0, 200.0, 60.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '������'), 'Recliner', '������������ ������-������', 80.0, 90.0, 100.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '�������'), 'King Size', '������� King Size � �������������� ��������', 200.0, 180.0, 160.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '�������'), 'Modern', '����������� ������� �� ������� � ������', 100.0, 220.0, 40.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '����-�������'), 'Rocking Chair', '������� ������-������� � ��������������', 60.0, 70.0, 80.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '���������� ����'), 'Workspace', '������� ���� � ���������� �������', 150.0, 80.0, 70.0),
    (NEWID(), (SELECT ID FROM Product WHERE Name = '���'), 'Round', '������� ��� � ����������� �������', 50.0, 50.0, 50.0);
