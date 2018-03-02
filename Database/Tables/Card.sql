USE [try.db]
go

IF OBJECT_ID('dbo.Card', 'U') IS NOT NULL
DROP TABLE [Card];

CREATE TABLE [Card] (
	Id int primary key identity(1,1),
	CardSetId int not null,
	foreign key (CardSetId) references CardSet(Id),
	[Name] nvarchar(50) not null,
	[Description] nvarchar(250),
	ImageUrl nvarchar(250),
	[Type] nvarchar(50)
)

INSERT INTO [Card]
	(CardSetId, [Name], [Description], ImageUrl, [Type])
VALUES 
	(1, 'Make a Coffee', 'Making coffee is awesome', '/img/card1.png', 'card type'),
	(1, 'coming soon', 'Description 2', '/img/card.png', 'card type'),
	(1, 'coming soon and feed sima', 'Description 3', '/img/card.png', 'card type'),
	(1, 'coming soon', 'Description 4', '/img/card.png', 'card type'),
	(1, 'coming soon', 'Description 5', '/img/card.png', 'card type'),
	(1, 'coming soon', 'Description 6', '/img/card.png', 'card type'),
	(1, 'coming soon', 'Description 7', '/img/card.png', 'card type'),
	(1, 'coming soon', 'Description 8', '/img/card.png', 'card type')
	select * from dbo.Card