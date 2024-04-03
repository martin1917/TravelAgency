USE [my_db_1]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [Login], [Password], [Role]) VALUES (1, N'maks', N'123', N'client')
INSERT [dbo].[Accounts] ([Id], [Login], [Password], [Role]) VALUES (2, N'agent_1', N'123', N'touragent')
INSERT [dbo].[Accounts] ([Id], [Login], [Password], [Role]) VALUES (3, N'victor', N'123', N'client')
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [SecondName], [Patronymic], [Birthday], [Email], [PhoneNumber], [AccountId]) VALUES (1, N'максим', N'левин', N'Вячеславович', CAST(N'2002-08-09T00:00:00.0000000' AS DateTime2), N'testd3@mail.ru', N'+12345678910', 1)
INSERT [dbo].[Clients] ([Id], [Name], [SecondName], [Patronymic], [Birthday], [Email], [PhoneNumber], [AccountId]) VALUES (2, N'Виктор', N'Петров', N'Иванович', CAST(N'2000-01-18T00:00:00.0000000' AS DateTime2), N'victor@mail.ru', N'+98765432120', 3)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
