USE [master]
GO
/****** Object:  Database [Quanlytaikhoannganhang]    Script Date: 5/17/2019 2:08:44 AM ******/
CREATE DATABASE [Quanlytaikhoannganhang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlytaikhoannganhang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Quanlytaikhoannganhang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quanlytaikhoannganhang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Quanlytaikhoannganhang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlytaikhoannganhang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET QUERY_STORE = OFF
GO
USE [Quanlytaikhoannganhang]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/17/2019 2:08:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[Type] [tinyint] NULL,
	[CustomerId] [int] NULL,
	[ExpireDate] [datetime] NULL,
	[Status] [tinyint] NULL,
	[Money] [money] NULL,
 CONSTRAINT [PK_AccountUser] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/17/2019 2:08:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](100) NULL,
	[IDNumber] [varchar](15) NULL,
	[IDPlace] [nvarchar](200) NULL,
	[IDDate] [date] NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 5/17/2019 2:08:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[TransactionId] [int] NOT NULL,
	[AccountId] [int] NULL,
	[UserId] [int] NULL,
	[CustomerId] [int] NULL,
	[Time] [datetime] NULL,
	[Amount] [money] NULL,
	[Fee] [money] NULL,
	[Total] [money] NULL,
	[Type] [tinyint] NULL,
	[Status] [tinyint] NULL,
	[ReceiptId] [int] NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/17/2019 2:08:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [varchar](1000) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Type] [varchar](50) NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_User.] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountId], [AccountNumber], [CreateTime], [Type], [CustomerId], [ExpireDate], [Status], [Money]) VALUES (1, N'123456789                                         ', CAST(N'2019-05-15T12:30:00.000' AS DateTime), 1, 1, CAST(N'2025-05-15T00:00:00.000' AS DateTime), 0, 0.0000)
INSERT [dbo].[Account] ([AccountId], [AccountNumber], [CreateTime], [Type], [CustomerId], [ExpireDate], [Status], [Money]) VALUES (2, N'213652154                                         ', CAST(N'2019-05-15T12:30:00.000' AS DateTime), 0, 2, CAST(N'2025-05-15T00:00:00.000' AS DateTime), 1, 9989208500.0000)
INSERT [dbo].[Account] ([AccountId], [AccountNumber], [CreateTime], [Type], [CustomerId], [ExpireDate], [Status], [Money]) VALUES (3, N'256874521                                         ', CAST(N'2019-05-15T15:30:00.000' AS DateTime), 0, 3, CAST(N'2025-05-15T00:00:00.000' AS DateTime), 1, 2004485000.0000)
INSERT [dbo].[Account] ([AccountId], [AccountNumber], [CreateTime], [Type], [CustomerId], [ExpireDate], [Status], [Money]) VALUES (12, N'3232156465                                        ', CAST(N'2019-10-10T00:00:00.000' AS DateTime), 0, 15, CAST(N'2019-10-10T00:00:00.000' AS DateTime), 0, 1000000.0000)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [IDNumber], [IDPlace], [IDDate], [Address], [Phone]) VALUES (1, N'Admin', N'Admin', N'1', N'1', CAST(N'1990-05-15' AS Date), N'HN', N'0988097880')
INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [IDNumber], [IDPlace], [IDDate], [Address], [Phone]) VALUES (2, N'Thanh', N'Tú', N'2', N'2', CAST(N'1997-02-14' AS Date), N'HCM', N'0326662016')
INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [IDNumber], [IDPlace], [IDDate], [Address], [Phone]) VALUES (3, N'Anh ', N'Vũ', N'3', N'3', CAST(N'1997-07-06' AS Date), N'HCM', N'0382781177')
INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [IDNumber], [IDPlace], [IDDate], [Address], [Phone]) VALUES (15, N'Thanh', N'Phong', N'2', N'2', CAST(N'2019-05-17' AS Date), N'HCMM', N'0123448461')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Transaction] ([TransactionId], [AccountId], [UserId], [CustomerId], [Time], [Amount], [Fee], [Total], [Type], [Status], [ReceiptId]) VALUES (1, 2, NULL, NULL, CAST(N'2019-05-15T22:26:51.803' AS DateTime), 200000.0000, 6000.0000, 206000.0000, 1, NULL, 2)
INSERT [dbo].[Transaction] ([TransactionId], [AccountId], [UserId], [CustomerId], [Time], [Amount], [Fee], [Total], [Type], [Status], [ReceiptId]) VALUES (2, 2, NULL, NULL, CAST(N'2019-05-15T22:28:13.023' AS DateTime), 500000.0000, 5000.0000, 505000.0000, 0, NULL, 2)
INSERT [dbo].[Transaction] ([TransactionId], [AccountId], [UserId], [CustomerId], [Time], [Amount], [Fee], [Total], [Type], [Status], [ReceiptId]) VALUES (3, 2, NULL, NULL, CAST(N'2019-05-15T22:37:16.897' AS DateTime), 1000000.0000, 30000.0000, 1030000.0000, 1, NULL, 2)
INSERT [dbo].[Transaction] ([TransactionId], [AccountId], [UserId], [CustomerId], [Time], [Amount], [Fee], [Total], [Type], [Status], [ReceiptId]) VALUES (4, 2, NULL, NULL, CAST(N'2019-05-15T22:39:41.660' AS DateTime), 5000000.0000, 150000.0000, 5150000.0000, 1, NULL, 3)
INSERT [dbo].[Transaction] ([TransactionId], [AccountId], [UserId], [CustomerId], [Time], [Amount], [Fee], [Total], [Type], [Status], [ReceiptId]) VALUES (5, 2, NULL, NULL, CAST(N'2019-05-15T22:38:15.687' AS DateTime), 5000000.0000, 50000.0000, 5050000.0000, 0, NULL, 2)
INSERT [dbo].[Transaction] ([TransactionId], [AccountId], [UserId], [CustomerId], [Time], [Amount], [Fee], [Total], [Type], [Status], [ReceiptId]) VALUES (6, 2, NULL, NULL, CAST(N'2019-05-17T01:48:24.467' AS DateTime), 50000.0000, 500.0000, 50500.0000, 0, NULL, 2)
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Username], [Password], [FirstName], [LastName], [Type], [CustomerId]) VALUES (1, N'Admin', N'123456', N'Admin', N'Admin', N'1', 1)
INSERT [dbo].[User] ([UserId], [Username], [Password], [FirstName], [LastName], [Type], [CustomerId]) VALUES (2, N'ThanhTu', N'123456', N'Thanh', N'Tú', N'0', 2)
INSERT [dbo].[User] ([UserId], [Username], [Password], [FirstName], [LastName], [Type], [CustomerId]) VALUES (3, N'AnhVu', N'123456', N'Anh', N'Vũ', N'0', 3)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Customer]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Account]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Customer]
GO
/****** Object:  StoredProcedure [dbo].[AccAdd]    Script Date: 5/17/2019 2:08:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[AccAdd]

@Username nvarchar(50),
@Password varchar(1000),
@FirstName nvarchar(30),
@LastName nvarchar(50),
@Type varchar(50),
@CustomerId int
AS

 INSERT INTO [dbo].[User](Username, Password, FirstName, LastName, Type, CustomerId)
 VALUES (@Username, @Password, @FirstName, @LastName, @Type, @CustomerId)
GO
/****** Object:  StoredProcedure [dbo].[AtmAdd]    Script Date: 5/17/2019 2:08:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AtmAdd]


@AccountNumber nchar(50),
@CreateTime datetime,
@Type tinyint,
@CustomerId int,
@ExpireDate datetime,
@Status tinyint,
@Money money
AS

 INSERT INTO [dbo].[Account]( AccountNumber, CreateTime, Type, CustomerId, ExpireDate,Status,Money)
 VALUES ( @AccountNumber, @CreateTime, @Type, @CustomerId, @ExpireDate,@Status,@Money)
GO
/****** Object:  StoredProcedure [dbo].[sp_Giaodich]    Script Date: 5/17/2019 2:08:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_Giaodich]
@MAGD INT,
@TK_GIAODICH NCHAR(9),
@LOAIGD NCHAR(2),
@TK_NHAN NCHAR(9),
@SOTIEN MONEY

as
	DECLARE @RETURN int;
	BEGIN TRANSACTION [GDTrans]
	DECLARE @SODU MONEY
	DECLARE @FEE MONEY
	DECLARE @STATUS tinyint
	DECLARE @CHUYENRETURN int
	SELECT @SODU=[Money], @STATUS= [Status] FROM Account WHERE AccountId =@TK_GIAODICH
	SET @FEE = @SOTIEN* 0.03
	IF(@STATUS = 0)
		BEGIN
			ROLLBACK TRANSACTION [GDTrans]
						SET @CHUYENRETURN = 4
						RETURN @CHUYENRETURN
		END
	ELSE
		BEGIN
				IF(@SODU < (@SOTIEN+ @FEE))
				BEGIN
					ROLLBACK TRANSACTION [GDTrans]
						SET @CHUYENRETURN = 6
						RETURN @CHUYENRETURN
				END 
				ELSE
				BEGIN
					IF(@LOAIGD = 1)
					BEGIN
					DECLARE @CHECKMONEYS money
							SELECT @CHECKMONEYS = SUM([Total]) FROM [Transaction] WHERE AccountId = @TK_GIAODICH AND [Type] = 1 AND [Time] > CAST(CURRENT_TIMESTAMP AS DATE) and [Time] < DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE)) group by AccountId
						IF(@CHECKMONEYS>100000000)
						BEGIN
							ROLLBACK TRANSACTION[GDTrans]
							SET @CHUYENRETURN=2
							RETURN @CHUYENRETURN
						END
						IF(@SOTIEN > 100000000 OR @SOTIEN < 20000)
							BEGIN
								ROLLBACK TRANSACTION [GDTrans]
								SET @CHUYENRETURN = 5
								RETURN @CHUYENRETURN
							END
						ELSE
							BEGIN
								INSERT INTO [Quanlytaikhoannganhang].[dbo].[Transaction]
								(TransactionId,AccountId,Amount,[Time], Fee, Total, [Type], ReceiptId)
								values (@MAGD,@TK_GIAODICH, @SOTIEN,GETDATE(), @FEE, @SOTIEN+ @FEE, @LOAIGD, @TK_NHAN)

								UPDATE Account
								SET [Money] = @SODU - @SOTIEN - @FEE
								WHERE AccountId = @TK_GIAODICH

								SELECT @SODU = [Money] FROM Account WHERE AccountId = @TK_NHAN
								UPDATE Account
								SET [Money] = @SODU + @SOTIEN
								WHERE AccountId = @TK_NHAN 
							END
					END
					IF (@LOAIGD = 0)
						BEGIN
							SET @FEE = @SOTIEN* 0.01
							DECLARE @CHECKMONEY money
							SELECT @CHECKMONEY = SUM([Total]) FROM [Transaction] WHERE AccountId = @TK_GIAODICH AND [Type] = 0 AND [Time] > CAST(CURRENT_TIMESTAMP AS DATE) and [Time] < DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE)) group by AccountId
								IF(@CHECKMONEY > 50000000)
									BEGIN
										ROLLBACK TRANSACTION [GDTrans]
										SET @CHUYENRETURN = 3
										RETURN @CHUYENRETURN
									END
								IF(@SOTIEN > 5000000 OR @SOTIEN < 20000)
									BEGIN
										ROLLBACK TRANSACTION [GDTrans]
										SET @CHUYENRETURN = 2
										RETURN @CHUYENRETURN
									END
								ELSE
									BEGIN
										INSERT INTO [Quanlytaikhoannganhang].[dbo].[Transaction]
															(TransactionId,AccountId,Amount,[Time], Fee, Total, [Type], ReceiptId)
															values (@MAGD,@TK_GIAODICH, @SOTIEN,GETDATE(), @FEE, @SOTIEN+ @FEE, @LOAIGD, @TK_NHAN)

															UPDATE Account
															SET [Money] = @SODU - @SOTIEN - @FEE
															WHERE AccountId = @TK_GIAODICH
									END
					
						END
					END
						COMMIT TRANSACTION [GDTrans]
						SET @CHUYENRETURN = 0
						RETURN @CHUYENRETURN
			END
		

	


GO
USE [master]
GO
ALTER DATABASE [Quanlytaikhoannganhang] SET  READ_WRITE 
GO
