USE [master]
GO
/****** Object:  Database [CinemaProject_v4]    Script Date: 11/3/2022 1:14:15 PM ******/
CREATE DATABASE [CinemaProject_v4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PRN2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PRN2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CinemaProject_v4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CinemaProject_v4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CinemaProject_v4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET ARITHABORT OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CinemaProject_v4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CinemaProject_v4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CinemaProject_v4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CinemaProject_v4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET RECOVERY FULL 
GO
ALTER DATABASE [CinemaProject_v4] SET  MULTI_USER 
GO
ALTER DATABASE [CinemaProject_v4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CinemaProject_v4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CinemaProject_v4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CinemaProject_v4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CinemaProject_v4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CinemaProject_v4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CinemaProject_v4', N'ON'
GO
ALTER DATABASE [CinemaProject_v4] SET QUERY_STORE = OFF
GO
USE [CinemaProject_v4]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [int] NOT NULL,
	[IDPeople] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Movie] [int] NOT NULL,
	[Ticket_type] [nvarchar](50) NOT NULL,
	[Seat_num] [varchar](50) NOT NULL,
	[FastFood] [int] NOT NULL,
	[Quantity_Fastfood] [int] NOT NULL,
	[Drink] [int] NOT NULL,
	[Quantity_Drink] [int] NOT NULL,
	[Total] [float] NOT NULL,
	[TicketID] [int] NOT NULL,
	[BookingDate] [date] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[phoneNum] [varchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Accumulated_point] [int] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FastFood]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FastFood](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Size] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Image] [varchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_FastFood] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Image] [varchar](max) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Main_Characters] [varchar](max) NOT NULL,
	[Duration] [int] NOT NULL,
	[Genres] [nvarchar](max) NOT NULL,
	[Genre_ID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revenue]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revenue](
	[Movie_ID] [int] NOT NULL,
	[Movie_name] [nvarchar](max) NOT NULL,
	[Premiere_date] [date] NOT NULL,
	[End_date] [date] NOT NULL,
	[numOfTicketSold] [int] NOT NULL,
	[Revenue] [float] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Seats] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShowTime]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShowTime](
	[Movie_ID] [int] NOT NULL,
	[Room_ID] [int] NOT NULL,
	[Show_date] [date] NOT NULL,
	[Ticket_price] [float] NOT NULL,
	[numOfTicketSold] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PhoneNum] [nchar](10) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 11/3/2022 1:14:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Movie] [int] NOT NULL,
	[Ticket_type] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (1, N'QuynhNN', N'quynh', 1, 1)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (2, N'HungNPV', N'hung', 1, 2)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (3, N'PhucNT', N'phuc', 1, 3)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (4, N'TamLM', N'tam', 1, 4)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (5, N'HungTND', N'hung', 1, 5)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (6, N'banhbeo', N'123456', 0, 0)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (7, N'airi', N'123456', 0, 0)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (8, N'tom', N'123456', 0, 0)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Role], [IDPeople]) VALUES (10, N'quynhxxx', N'123456', 0, 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (13, 1, N'Vip', N'T11', 1, 1, 4, 1, 10017, 1, CAST(N'2022-10-29' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (14, 1, N'Vip', N'T21', 1, 1, 4, 3, 10031, 1, CAST(N'2022-10-29' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (18, 1, N'Vip', N'A1', 1, 1, 4, 1, 10017, 1, CAST(N'2022-10-31' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (19, 1, N'Normal', N'A1', 1, 1, 4, 1, 5017, 2, CAST(N'2022-10-31' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (20, 1, N'Normal', N'A4', 1, 4, 4, 4, 5068, 2, CAST(N'2022-10-31' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (21, 2, N'Basic', N'A7', 1, 1, 4, 1, 20017, 6, CAST(N'2022-11-03' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (22, 4, N'Basic', N'A4', 1, 1, 4, 1, 37, 7, CAST(N'2022-11-03' AS Date))
INSERT [dbo].[Bill] ([ID], [ID_Movie], [Ticket_type], [Seat_num], [FastFood], [Quantity_Fastfood], [Drink], [Quantity_Drink], [Total], [TicketID], [BookingDate]) VALUES (23, 1, N'Normal', N'A2', 1, 1, 4, 1, 5017, 2, CAST(N'2022-11-03' AS Date))
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[FastFood] ON 

INSERT [dbo].[FastFood] ([ID], [Name], [Size], [Price], [Image], [Quantity]) VALUES (1, N'PopCorn', N'S', 10, N'https://www.twosisterscrafting.com/wp-content/uploads/2016/01/perfect-stovetop-popcorn-1200-featured-735x735.jpg', 0)
INSERT [dbo].[FastFood] ([ID], [Name], [Size], [Price], [Image], [Quantity]) VALUES (2, N'PopCorn', N'M', 12, N'https://www.twosisterscrafting.com/wp-content/uploads/2016/01/perfect-stovetop-popcorn-1200-featured-735x735.jpg', 0)
INSERT [dbo].[FastFood] ([ID], [Name], [Size], [Price], [Image], [Quantity]) VALUES (3, N'PopCorn', N'L', 15, N'https://www.twosisterscrafting.com/wp-content/uploads/2016/01/perfect-stovetop-popcorn-1200-featured-735x735.jpg', 0)
INSERT [dbo].[FastFood] ([ID], [Name], [Size], [Price], [Image], [Quantity]) VALUES (4, N'Coca', N'S', 7, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBDajhtrSmfbhEuWE7zeSsKyjAyzksykSbkO35wy-lzMcKijoC7bXBGRqDZ2GNLsMHJ8A&usqp=CAU', 0)
INSERT [dbo].[FastFood] ([ID], [Name], [Size], [Price], [Image], [Quantity]) VALUES (5, N'Coca', N'L', 10, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBDajhtrSmfbhEuWE7zeSsKyjAyzksykSbkO35wy-lzMcKijoC7bXBGRqDZ2GNLsMHJ8A&usqp=CAU', 0)
INSERT [dbo].[FastFood] ([ID], [Name], [Size], [Price], [Image], [Quantity]) VALUES (6, N'Coca', N'L', 13, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBDajhtrSmfbhEuWE7zeSsKyjAyzksykSbkO35wy-lzMcKijoC7bXBGRqDZ2GNLsMHJ8A&usqp=CAU', 0)
SET IDENTITY_INSERT [dbo].[FastFood] OFF
GO
INSERT [dbo].[Genres] ([ID], [Name]) VALUES (1, N'Action')
INSERT [dbo].[Genres] ([ID], [Name]) VALUES (2, N'Romance')
INSERT [dbo].[Genres] ([ID], [Name]) VALUES (3, N'Family')
INSERT [dbo].[Genres] ([ID], [Name]) VALUES (4, N'Animation')
INSERT [dbo].[Genres] ([ID], [Name]) VALUES (5, N'Comedy')
INSERT [dbo].[Genres] ([ID], [Name]) VALUES (6, N'Horror')
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (1, N'Venom: Let There Be Carnage', N'~/img/imgMovie/1.jpg', N'Venom: Let There Be Carnage is a 2021 American superhero film featuring the Marvel Comics character Venom, produced by Columbia Pictures in association with Marvel. Distributed by Sony Pictures Releasing, it is the second film in Sony''s Spider-Man Universe and the sequel to Venom (2018). The film was directed by Andy Serkis from a screenplay by Kelly Marcel, based on a story she wrote with Tom Hardy, who stars as Eddie Brock and Venom alongside Michelle Williams, Naomie Harris, Reid Scott, Stephen Graham, and Woody Harrelson. In the film, Brock and the alien symbiote Venom must face serial killer Cletus Kasady (Harrelson) after he becomes the host of an offshoot of Venom named Carnage.', N'Tom Hardy, Woody Harrelson, Michelle Williams, Naomie Harris, Reid Scott, Stephen Graham, Peggy Lu, Sian Webber', 90, N'Action, Sci-fi, Adventure', 1, 4)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (2, N'Spider-Man: No Way Home
', N'~/img/imgMovie/2.jpg', N'Spider-Man: No Way Home is a 2021 superhero film, based on the Marvel Comics superhero of the same name. The film is a sequel to Spider-Man: Homecoming and Spider-Man: Far From Home, as well as a crossover/sequel to the Spider-Man trilogy and The Amazing Spider-Man duology. It is the twenty-seventh film in the Marvel Cinematic Universe, and the nineth installment of Phase Four. The film was released in the United States on December 17, 2021, and re-released in theaters for one week under the title Spider-Man: No Way Home - The More Fun Stuff Version on September 2, 2022.
', N'Tom Holland, Zendaya, Benedict Cumberbatch, Jacob Batalon, Jon Favreau, Jamie Foxx, Willem Dafoe, Tobey Maguire, Andrew Garfield
', 159, N'Action, Fantasy, Adventure
', 1, 8)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (4, N'The Dark Knight Rises
', N'~/img/imgMovie/4.jpg', N'The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer. The film is based on the DC Comics character Batman, it is the final installment in Nolan''s The Dark Knight trilogy, and the sequel to The Dark Knight (2008). The film stars Christian Bale as Bruce Wayne / Batman, alongside Michael Caine, Gary Oldman, Anne Hathaway, Tom Hardy, Marion Cotillard, Joseph Gordon Levitt, and Morgan Freeman. Eight years after the events of The Dark Knight, the revolutionary Bane forces Bruce Wayne to resume his role as Batman and save Gotham City from nuclear destruction.
', N'Christian Bale, Tom Hardy, Anne Hathaway, Gary Oldman, Joseph Gordon-Levitt, Marion Cotillard, Morgan Freeman, Michael Caine
', 164, N'Action, Drama
', 1, 8)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (5, N'Zombieland
', N'~/img/imgMovie/5.jpg', N'Zombieland is a 2009 American zombie comedy film directed by Ruben Fleischer in his theatrical debut and written by Rhett Reese and Paul Wernick. The film follows a geeky college student (Jesse Eisenberg) making his way through a post-apocalyptic zombie apocalypse, meeting three strangers (Woody Harrelson, Emma Stone, and Abigail Breslin) along the way and together taking an extended road trip across the Southwestern United States in an attempt to find a sanctuary free from zombies.
', N'Jesse Eisenberg, Emma Stone, Woody Harrelson, Abigail Breslin, Amber Heard, Bill Murray,
', 88, N'Action, Comedy, Horror
', 1, 9)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (7, N'Eternal Sunshine of the Spotless Mind
', N'~/img/imgMovie/7.jpg', N'Eternal Sunshine of the Spotless Mind (also simply known as Eternal Sunshine) is a 2004 American romantic science fiction drama film written by Charlie Kaufman, directed by Michel Gondry, and starring Jim Carrey and Kate Winslet. Pierre Bismuth created the story with Kaufman and Gondry. The film features an ensemble supporting cast that includes Kirsten Dunst, Mark Ruffalo, Elijah Wood, and Tom Wilkinson. The title of the film is a quotation from the 1717 poem Eloisa to Abelard by Alexander Pope. The picture uses elements of psychological drama, science fiction and a nonlinear narrative to explore the nature of memory and romantic love.
', N'Jim Carrey, Kate Winslet, Tom Wilkinson, Gerry Robert Byrne, Elijah Wood, Thomas Jay Ryan, Mark Ruffalo, Jane Adams
', 108, N'Romance, Drama, Sci-fi
', 2, 9)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (8, N'Before Sunrise
', N'~/img/imgMovie/8.jpg', N'Before Sunrise is a 1995 romantic drama film directed by Richard Linklater and co-written by Linklater and Kim Krizan. The first installment in the Before trilogy, it follows Jesse (Ethan Hawke) and Céline (Julie Delpy) as they meet on a Eurail train and disembark in Vienna to spend the night together.
', N'Ethan Hawke, Julie Delpy, Andrea Eckert, Hanno Pöschl, Karl Bruckschwaiger, Tex Rubinowitz, Erni Mangold, Dominik Castell
', 101, N'Romance, Drama
', 2, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (9, N'The Shape of Water
', N'~/img/imgMovie/9.jpg', N'The Shape of Water is a 2017 American romantic fantasy film directed by Guillermo del Toro and written by del Toro and Vanessa Taylor. It stars Sally Hawkins, Michael Shannon, Richard Jenkins, Doug Jones, Michael Stuhlbarg, and Octavia Spencer. Set in 1962 Baltimore, Maryland, the film follows a mute cleaner at a high-security government laboratory who falls in love with a captured humanoid amphibian creature, and decides to help him escape from death at the hands of an evil colonel. Filming took place on location in Ontario, Canada, from August to November 2016.
', N'Sally Hawkins, Octavia Spencer, Michael Shannon, Doug Jones, Richard Jenkins, Michael Stuhlbarg, David Hewlett, Nick Searcy
', 123, N'Romance, Drama, Fantasy
', 2, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (10, N'Slumdog Millionaire
', N'~/img/imgMovie/10.jpg', N'Slumdog Millionaire is a 2008 British drama film that is a loose adaptation of the novel Q & A (2005) by Indian author Vikas Swarup. It narrates the story of 18-year-old Jamal Malik from the Juhu slums of Mumbai. Starring Dev Patel as Jamal, and filmed in India, the film was directed by Danny Boyle, written by Simon Beaufoy, and produced by Christian Colson, with Loveleen Tandan credited as co-director. As a contestant on Kaun Banega Crorepati, an Indian-Hindi version of Who Wants to Be a Millionaire?, Jamal surprises everyone by being able to answer every question correctly, winning ?20 million. Accused of cheating, Jamal recounts his life story to the police, illustrating how he is able to answer each question correctly.
', N'Dev Patel, Freida Pinto, Saurabh Shukla, Anil Kapoor, Raj Zutshi, Jeneva Talwar, Irrfan Khan, Azharuddin Mohammed Ismail
', 120, N'Romance, Drama, Crime
', 2, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (11, N'Titanic
', N'~/img/imgMovie/11.jpg', N'Titanic is a 1997 American epic romance and disaster film directed, written, produced, and co-edited by James Cameron. Incorporating both historical and fictionalized aspects, it is based on accounts of the sinking of the RMS Titanic, and stars Leonardo DiCaprio and Kate Winslet as members of different social classes who fall in love aboard the ship during its ill-fated maiden voyage. Also starring are Billy Zane, Kathy Bates, Frances Fisher, Gloria Stuart, Bernard Hill, Jonathan Hyde, Victor Garber, and Bill Paxton.
', N'Leonardo DiCaprio, Kate Winslet, Billy Zane, Kathy Bates, Frances Fisher, Gloria Stuart, Bill Paxton, Bernard Hill
', 195, N'Romance, Drama
', 2, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (12, N'The Big Sick
', N'~/img/imgMovie/12.jpg', N'The Big Sick is a 2017 American romantic comedy film directed by Michael Showalter and written by Emily V. Gordon and Kumail Nanjiani. It stars Nanjiani, Zoe Kazan, Holly Hunter, Ray Romano, Adeel Akhtar, and Anupam Kher. The film is inspired by the relationship between Nanjiani and Gordon, and follows an interethnic couple who must deal with cultural differences after Emily (Kazan) becomes ill.
', N'Kumail Nanjiani, Zoe Kazan, Holly Hunter, Ray Romano, Anupam Kher, Zenobia Shroff, Adeel Akhtar, Bo Burnham
', 120, N'Romance, Drama, Comedy
', 2, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (13, N'Harry Potter and the Sorcerer''s Stone
', N'~/img/imgMovie/13.jpg', N'Harry Potter and the Philosopher''s Stone (released in the United States, India and the Philippines as Harry Potter and the Sorcerer''s Stone) is a 2001 fantasy film directed by Chris Columbus and distributed by Warner Bros. Pictures, based on J. K. Rowling''s 1997 novel of the same name. Produced by David Heyman and written by Steve Kloves, it is the first instalment of the Harry Potter film series. The film stars Daniel Radcliffe as Harry Potter, with Rupert Grint as Ron Weasley, and Emma Watson as Hermione Granger. Its story follows Harry''s first year at Hogwarts School of Witchcraft and Wizardry as he discovers that he is a famous wizard and begins his formal wizarding education
', N'Daniel Radcliffe, Rupert Grint, Richard Harris, Maggie Smith, Robbie Coltrane, Saunders Triplets, Fiona Shaw, Harry Melling
', 152, N'Family, Adventure, Fantasy
', 3, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (14, N'E.T. the Extra-Terrestrial
', N'~/img/imgMovie/14.jpg', N'E.T. the Extra-Terrestrial (or simply E.T.) is a 1982 American science fiction film produced and directed by Steven Spielberg and written by Melissa Mathison. It tells the story of Elliott, a boy who befriends an extraterrestrial, dubbed E.T., who is left behind on Earth. Along with his friends and family, Elliott must find a way to help E.T. find his way home. The film stars Dee Wallace, Henry Thomas, Peter Coyote, Robert MacNaughton, Drew Barrymore and Erika Eleniak.
', N'Henry Thomas, Drew Barrymore, Peter Coyote, Dee Wallace, Robert MacNaughton, K.C. Martel, Sean Frye, C. Thomas Howell
', 114, N'Family, Adventure, Sci-Fi
', 3, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (15, N'The Goonies
', N'~/img/imgMovie/15.jpg', N'The Goonies is a 1985 American adventure comedy film co-produced and directed by Richard Donner from a screenplay by Chris Columbus, based on a story by Steven Spielberg. In the film, kids who live in the "Goon Docks" neighborhood of Astoria, Oregon, attempt to save their homes from foreclosure and, in doing so, they discover an old treasure map that takes them on an adventure to unearth the long-lost fortune of One-Eyed Willy, a legendary 17th-century pirate. During the adventure, they are chased by a family of criminals who want the treasure for themselves.
', N'Sean Astin, Josh Brolin, Jeff Cohen, Corey Feldman, Kerri Green, Martha Plimpton, Ke Huy Quan, John Matuszak
', 114, N'Family, Adventure, Comedy
', 3, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (16, N'Home Alone
', N'~/img/imgMovie/16.jpg', N'Home Alone is a 1990 American Christmas comedy film directed by Chris Columbus and written and produced by John Hughes. The first film in the Home Alone franchise, the film stars Macaulay Culkin, Joe Pesci, Daniel Stern, John Heard, and Catherine O''Hara. Culkin plays Kevin McCallister, a boy who defends his suburban Chicago home from burglars after his family accidentally leaves him behind on their Christmas vacation to Paris.
', N'Macaulay Culkin, Joe Pesci, Daniel Stern, John Heard, Roberts Blossom, Catherine O''Hara, Angela Goethals, Devin Ratray
', 103, N'Family, Comedy
', 3, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (17, N'A Christmas Story
', N'~/img/imgMovie/17.jpg', N'A Christmas Story is a 1983 Christmas comedy film directed by Bob Clark and based on Jean Shepherd''s semi-fictional anecdotes in his 1966 book In God We Trust: All Others Pay Cash, with some elements from his 1971 book Wanda Hickey''s Night of Golden Memories And Other Disasters. It stars Melinda Dillon, Darren McGavin, and Peter Billingsley and is a seasonal classic in North America. It has been shown in a marathon annually on TNT since 1997 and on TBS since 2004 titled "24 Hours of A Christmas Story", consisting of 12 consecutive airings of the film from the evening of Christmas Eve to the evening of Christmas Day annually. It is often ranked as one of the best Christmas films.
', N'Peter Billingsley, Melinda Dillon, Darren McGavin, Scott Schwartz, Ian Petrella, Tedde Moore, R.D. Robb, Zack Ward, Yano Anaya, Jeff Gillen
', 152, N'Family, Comedy
', 3, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (18, N'Jumanji
', N'~/img/imgMovie/18.jpg', N'Jumanji is a 1995 American fantasy adventure film directed by Joe Johnston from a screenplay by Jonathan Hensleigh, Greg Taylor, and Jim Strain. Loosely based on Chris Van Allsburg''s picture book of the same name, the film is the first installment of the Jumanji franchise. It stars Robin Williams, Bonnie Hunt, Kirsten Dunst, Jonathan Hyde, and David Alan Grier.
', N'Robin Williams, Kirsten Dunst, Bonnie Hunt, Jonathan Hyde, Bradley Pierce, Bebe Neuwirth, David Alan Grier, Patricia Clarkson
', 104, N'Family, Adventure, Comedy
', 3, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (19, N'Spirited Away
', N'~/img/imgMovie/19.jpg', N'Spirited Away (Japanese: ????????, Hepburn: Sen to Chihiro no Kamikakushi, lit. ''Sen and Chihiro''s Spiriting Away'') is a 2001 Japanese animated fantasy film written and directed by Hayao Miyazaki, animated by Studio Ghibli for Tokuma Shoten, Nippon Television Network, Dentsu, Buena Vista Home Entertainment, Tohokushinsha Film, and Mitsubishi and distributed by Toho. The film features the voices of Rumi Hiiragi, Miyu Irino, Mari Natsuki, Takeshi Naito, Yasuko Sawaguchi, Tsunehiko Kamijo, Takehiko Ono, and Bunta Sugawara. Spirited Away tells the story of Chihiro Ogino (Hiiragi), a ten-year-old girl who, while moving to a new neighborhood, enters the world of Kami (spirits of Japanese Shinto folklore). After her parents are turned into pigs by the witch Yubaba (Natsuki), Chihiro takes a job working in Yubaba''s bathhouse to find a way to free herself and her parents and return to the human world.
', N'Miyu Irino, Rumi Hiiragi, Mari Natsuki, Takashi Naitô, Yasuko Sawaguchi, Tatsuya Gashûin, Ryûnosuke Kamiki, Yumi Tamai, Yô Ôizumi
', 125, N'Animation, Adventure, Family
', 4, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (20, N'My Neighbor Totoro
', N'~/img/imgMovie/20.jpg', N'My Neighbor Totoro (Japanese: ???????, Hepburn: Tonari no Totoro) is a 1988 Japanese animated fantasy film written and directed by Hayao Miyazaki and animated by Studio Ghibli for Tokuma Shoten. The film—which stars the voice actors Noriko Hidaka, Chika Sakamoto, and Hitoshi Takagi—tells the story of a professor''s two young daughters (Satsuki and Mei) and their interactions with friendly wood spirits in postwar rural Japan.
', N'Hitoshi Takagi, Noriko Hidaka, Chika Sakamoto, Shigesato Itoi, Sumi Shimamoto, Tanie Kitabayashi, Yûko Maruyama, Machiko Washio
', 86, N'Animation, Adventure, Comedy
', 4, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (21, N'Toy Story
', N'~/img/imgMovie/21.jpg', N'Toy Story is a 1995 American computer-animated comedy film directed by John Lasseter (in his feature directorial debut), produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. It was written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Jim Varney, Wallace Shawn, John Ratzenberger, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten.
', N'Tom Hanks, Tim Allen, Don Rickles, Jim Varney, Wallace Shawn, John Ratzenberger, Annie Potts, John Morris,
', 81, N'Animation, Adventure, Comedy
', 4, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (22, N'The Incredibles
', N'~/img/imgMovie/22.jpg', N'The Incredibles is a 2004 American computer-animated superhero film produced by Pixar Animation Studios and released by Walt Disney Pictures. Written and directed by Brad Bird, it stars the voices of Craig T. Nelson, Holly Hunter, Sarah Vowell, Spencer Fox, Jason Lee, Samuel L. Jackson, and Elizabeth Peña. Set in a retro-futuristic version of the 1960s, the film follows Bob and Helen Parr, a couple of superheroes, known as Mr. Incredible and Elastigirl, who hide their powers in accordance with a government mandate, and attempt to live a quiet suburban life with their three children. However, Bob''s desire to help people draws the entire family into a confrontation with a vengeful fan-turned-foe.
', N'Craig T. Nelson, Samuel L. Jackson, Holly Hunter, Jason Lee, Dominique Louis, Teddy Newton, Jean Sincere, Eli Fucile
', 115, N'Animation, Action, Adventure
', 4, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (23, N'The Iron Giant
', N'~/img/imgMovie/23.jpg', N'The Iron Giant is a 1999 American animated science fiction film produced by Warner Bros. Feature Animation and directed by Brad Bird in his directorial debut. It is based on the 1968 novel The Iron Man by Ted Hughes (which was published in the United States as The Iron Giant) and was scripted by Tim McCanlies from a story treatment by Bird. The film stars the voices of Jennifer Aniston, Harry Connick Jr., Vin Diesel, James Gammon, Cloris Leachman, John Mahoney, Eli Marienthal, Christopher McDonald, and M. Emmet Walsh. Set during the Cold War in 1957, the film centers on a young boy named Hogarth Hughes, who discovers and befriends a giant alien robot. With the help of a beatnik artist named Dean McCoppin, Hogarth attempts to prevent the U.S. military and Kent Mansley, a paranoid federal agent, from finding and destroying the Giant.
', N'Eli Marienthal, Harry Connick Jr., Jennifer Aniston, Vin Diesel, James Gammon, Cloris Leachman, Christopher McDonald, John Mahoney
', 87, N'Animation, Action, Adventure
', 4, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (24, N'The Nightmare Before Christmas
', N'~/img/imgMovie/24.jpg', N'The Nightmare Before Christmas (also known as Tim Burton''s The Nightmare Before Christmas) is a 1993 American stop-motion animated musical dark fantasy film directed by Henry Selick (in his feature directorial debut) and produced and conceived by Tim Burton. It tells the story of Jack Skellington, the King of "Halloween Town" who stumbles upon "Christmas Town" and schemes to take over the holiday. Danny Elfman wrote the songs and score, and provided the singing voice of Jack. The principal voice cast also includes Chris Sarandon, Catherine O''Hara, William Hickey, Ken Page, Paul Reubens, Glenn Shadix, and Ed Ivory
', N'Danny Elfman, Chris Sarandon, Catherine O''Hara, William Hickey, Glenn Shadix, Paul Reubens, Ken Page, Edward Ivory
', 75, N'Animation, Family, Fantasy
', 4, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (25, N'White Chicks
', N'~/img/imgMovie/25.jpg', N'White Chicks is a 2004 American comedy film directed by Keenen Ivory Wayans. It stars Shawn Wayans and Marlon Wayans as two FBI agents who go undercover as women by using whiteface to solve a kidnapping plot. The film was theatrically released in the United States on June 23, 2004, and grossed $113.1 million worldwide against a budget of $37 million
', N'Marlon Wayans, Shawn Wayans, Busy Philipps, Maitland Ward, Jaime King, Frankie Faison, Lochlyn Munro, John Heard
', 75, N'Comedy, Crime
', 5, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (26, N'Step Brothers
', N'~/img/imgMovie/26.jpg', N'Step Brothers is a 2008 American comedy film directed by Adam McKay, produced by Jimmy Miller and Judd Apatow, and written by Will Ferrell and McKay from a story by Ferrell, McKay, and John C. Reilly. It follows Brennan (Ferrell) and Dale (Reilly), two grown men who are forced to live together as brothers after their single parents, with whom they still live, marry each other. Richard Jenkins, Mary Steenburgen, Adam Scott, and Kathryn Hahn also star.
', N'Will Ferrell, John C. Reilly, Mary Steenburgen, Richard Jenkins, Adam Scott, Kathryn Hahn, Andrea Savage, Lurie Poston
', 95, N'Comedy
', 5, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (27, N'Jumanji: Welcome to the Jungle
', N'~/img/imgMovie/27.jpg', N'Jumanji: Welcome to the Jungle is a 2017 American fantasy adventure comedy film directed by Jake Kasdan, co-written by Chris McKenna, Erik Sommers, Scott Rosenberg, and Jeff Pinkner, and starring Dwayne Johnson, Jack Black, Kevin Hart, Karen Gillan, Nick Jonas, and Bobby Cannavale. It is the third installment of the Jumanji franchise, after Zathura: A Space Adventure (2005), and a direct sequel to Jumanji (1995), which was based on the 1981 children''s book of the same name by Chris Van Allsburg. The story focuses on a group of teenagers who come across Jumanji, now transformed into a video game twenty-two years after the events of the 1995 film. They find themselves trapped in the game as a set of adult avatars, seeking to complete a quest alongside another player who has been trapped since 1996.
', N'Dwayne Johnson, Karen Gillan, Kevin Hart, Jack Black, Rhys Darby, Bobby Cannavale, Nick Jonas, Alex Wolff
', 119, N'Comedy, Adventure, Action
', 5, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (28, N'Ted
', N'~/img/imgMovie/28.jpg', N'Ted is a 2012 American adult comedy film directed by Seth MacFarlane in his directorial debut and written by MacFarlane, Alec Sulkin, and Wellesley Wild. The film stars Mark Wahlberg and Mila Kunis, with Joel McHale and Giovanni Ribisi in supporting roles, and MacFarlane providing the voice and motion capture of the title character. The film tells the story of John Bennett, a Boston native whose childhood wish brings his teddy bear friend Ted to life. However, in adulthood, Ted and John''s friendship begins to interfere with the progression of John''s relationship with his girlfriend, Lori Collins.
', N'Mark Wahlberg, Mila Kunis, Seth MacFarlane, Joel McHale, Giovanni Ribisi, Patrick Warburton, Matt Walsh, Jessica Barth
', 112, N'Comedy
', 5, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (29, N'Shazam!
', N'~/img/imgMovie/29.jpg', N'Shazam! is a 2019 superhero film based on the DC Comics character of the same name, produced by New Line Cinema and distributed by Warner Bros. Pictures, it is the seventh installment in the DC Extended Universe (DCEU). It was directed by David F. Sandberg from a screenplay by Henry Gayden who co-wrote the story with Darren Lemke, and stars Zachary Levi, Mark Strong, Asher Angel, Jack Dylan Grazer, and Djimon Hounsou. The film follows teenager Billy Batson (Angel) as he is chosen by the ancient wizard Shazam (Hounsou) to be his new champion by saying the name "Shazam", allowing him to transform into an adult superhero (Levi) with various superpowers. Billy and his foster brother Freddy Freeman (Grazer) must discover Billy''s new powers in order to stop the evil Dr. Thaddeus Sivana (Strong) and the Seven Deadly Sins.
', N'Zachary Levi, Mark Strong, Asher Angel, Jack Dylan Grazer, Adam Brody, Djimon Hounsou, Faithe Herman, Meagan Good
', 132, N'Comedy, Adventure, Action
', 5, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (30, N'21 Jump Street
', N'~/img/imgMovie/30.jpg', N'21 Jump Street is a 2012 American buddy cop action comedy film directed by Phil Lord and Christopher Miller (in their live action directional debuts), written by Jonah Hill and Michael Bacall, and starring Hill and Channing Tatum.[7] An adaptation of the 1987–1991 television series of the same name by Stephen J. Cannell and Patrick Hasburgh, the film follows police officers Schmidt and Jenko, who are forced to relive high school when they are assigned to go undercover as high school students to prevent the outbreak of a new synthetic drug and arrest its supplier.
', N'Jonah Hill, Channing Tatum, Ice Cube, Brie Larson, Dave Franco, Rob Riggle, DeRay Davis, Dax Flame
', 109, N'Comedy, Action, Crime
', 5, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (31, N'It
', N'~/img/imgMovie/31.jpg', N'It (titled onscreen as It Chapter One) is a 2017 American supernatural horror film directed by Andy Muschietti and written by Chase Palmer, Cary Fukunaga and Gary Dauberman. The film was produced by New Line Cinema, KatzSmith Productions, Lin Pictures, and Vertigo Entertainment.[4][5] It is the first of a two-part adaptation of the 1986 novel of the same name by Stephen King, primarily covering the first chronological half of the book. The film stars Bill Skarsgård, Jaeden Lieberher, Jeremy Ray Taylor, Sophia Lillis, Finn Wolfhard, Wyatt Oleff, Chosen Jacobs, Jack Dylan Grazer, Nicholas Hamilton, and Jackson Robert Scott. Set in Derry, Maine, the film tells the story of The Losers'' Club, a group of seven outcast children who are terrorized by the eponymous being which emerges from the sewer, only to face their own personal demons in the process.
', N'Bill Skarsgård, Jaeden Martell, Finn Wolfhard, Sophia Lillis, Jeremy Ray Taylor, Chosen Jacobs, Jack Dylan Grazer, Wyatt Oleff
', 135, N'Horror
', 6, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (32, N'Insidious
', N'~/img/imgMovie/32.jpg', N'Insidious is a 2010 supernatural horror film directed by James Wan, written by Leigh Whannell, and starring Patrick Wilson, Rose Byrne, and Barbara Hershey. It is the first installment in the Insidious franchise, and the third in terms of the series'' in-story chronology. The story centers on a couple whose son inexplicably enters a comatose state and becomes a vessel for a variety of malevolent entities in an astral plane.
', N'Patrick Wilson, Rose Byrne, Ty Simpkins, Lin Shaye, Leigh Whannell, Angus Sampson, Barbara Hershey, Andrew Astor
', 101, N'Horror, Mystery, Thriller
', 6, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (33, N'Texas Chainsaw Massacre
', N'~/img/imgMovie/33.jpg', N'The Texas Chain Saw Massacre[note 1] is a 1974 American horror film produced and directed by Tobe Hooper from a story and screenplay by Hooper and Kim Henkel. It stars Marilyn Burns, Paul A. Partain, Edwin Neal, Jim Siedow and Gunnar Hansen, who respectively portray Sally Hardesty, Franklin Hardesty, the hitchhiker, the proprietor, and Leatherface. The film follows a group of friends who fall victim to a family of cannibals while on their way to visit an old homestead. The film was marketed as being based on true events to attract a wider audience and to act as a subtle commentary on the era''s political climate; although the character of Leatherface and minor story details were inspired by the crimes of murderer Ed Gein, its plot is largely fictional. It is the first film of the Texas Chainsaw Massacre franchise.
', N'Sarah Yarkin, Elsie Fisher, Mark Burnham, Jacob Latimore, Moe Dunford, Olwen Fouéré, Jessica Allain, Nell Hudson
', 82, N'Horror, Thriller, Crime
', 6, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (34, N'The Conjuring
', N'~/img/imgMovie/34.jpg', N'The Conjuring is a 2013 American supernatural horror film directed by James Wan and written by Chad Hayes and Carey W. Hayes. It is the inaugural film in The Conjuring Universe franchise.[4] Patrick Wilson and Vera Farmiga star as Ed and Lorraine Warren, paranormal investigators and authors associated with prominent cases of haunting. Their purportedly real-life reports inspired The Amityville Horror story and film franchise.[5] The Warrens come to the assistance of the Perron family, who experienced increasingly disturbing events in their newly occupied farmhouse in Rhode Island in 1971. With Ed and Lorraine Warren''s investigation, the Perron case became the first witch curse in Harrisville, Rhode Island.
', N'Patrick Wilson, Vera Farmiga, Ron Livingston, Lili Taylor, Shanley Caswell, Hayley McFarland, Joey King, Mackenzie Foy
', 112, N'Horror, Mystery, Thriller
', 6, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (35, N'The Exorcist
', N'~/img/imgMovie/35.jpg', N'The Exorcist is a 1973 American supernatural horror film directed by William Friedkin and written for the screen by William Peter Blatty, based on his 1971 novel of the same name. It stars Ellen Burstyn, Max von Sydow, Lee J. Cobb, Kitty Winn, Jack MacGowran (in his final film role), Jason Miller and Linda Blair. It follows the demonic possession of a young girl and her mother''s attempt to rescue her through an exorcism conducted by a pair of Catholic priests.
', N'Ellen Burstyn, Max von Sydow, Linda Blair, Lee J. Cobb, Kitty Winn, Jack MacGowran, Jason Miller, William O''Malley
', 132, N'Horror
', 6, 0)
INSERT [dbo].[Movie] ([ID], [Name], [Image], [Description], [Main_Characters], [Duration], [Genres], [Genre_ID], [Rating]) VALUES (36, N'Us
', N'~/img/imgMovie/36.jpg', N'Us is a 2019 American horror film written and directed by Jordan Peele, starring Lupita Nyong''o, Winston Duke, Elisabeth Moss, and Tim Heidecker. The film follows Adelaide Wilson (Nyong''o) and her family, who are attacked by a group of menacing doppelgängers.
', N'Lupita Nyong''o, Winston Duke, Elisabeth Moss, Tim Heidecker, Shahadi Wright Joseph, Evan Alex, Yahya Abdul-Mateen II, Anna Diop
', 116, N'Horror, Mystery, Thriller
', 6, 0)
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([ID], [Seats]) VALUES (1, N'30')
INSERT [dbo].[Room] ([ID], [Seats]) VALUES (2, N'30')
INSERT [dbo].[Room] ([ID], [Seats]) VALUES (3, N'30')
INSERT [dbo].[Room] ([ID], [Seats]) VALUES (4, N'30')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([ID], [Name], [PhoneNum], [Address], [Image], [Status]) VALUES (1, N'Nguyen Nhu Quynh', N'0949891610', N'Soc Trang', N'~/img/imgStaff/quynh.jpg', 1)
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNum], [Address], [Image], [Status]) VALUES (2, N'Nguyen Phan Vinh Hung', N'0845914368', N'Vinh Long', N'~/img/imgStaff/vinhhung.jpg', 1)
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNum], [Address], [Image], [Status]) VALUES (3, N'Nguyen Trong Phuc', N'0902400883', N'Soc Trang', N'~/img/imgStaff/trongphuc.png', 1)
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNum], [Address], [Image], [Status]) VALUES (4, N'Le Minh Tam', N'0123456789', N'Vinh Long', N'~/img/imgStaff/tam.jpg', 1)
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNum], [Address], [Image], [Status]) VALUES (5, N'Tran Nguyen Dai Hung', N'0789456123', N'Tra Vinh', N'~/img/imgStaff/daihung.jpg', 1)
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 

INSERT [dbo].[Ticket] ([ID], [ID_Movie], [Ticket_type], [Price], [Quantity]) VALUES (1, 1, N'Vip', 10000, 10)
INSERT [dbo].[Ticket] ([ID], [ID_Movie], [Ticket_type], [Price], [Quantity]) VALUES (2, 1, N'Normal', 5000, 50)
INSERT [dbo].[Ticket] ([ID], [ID_Movie], [Ticket_type], [Price], [Quantity]) VALUES (5, 2, N'Vip', 50000, 30)
INSERT [dbo].[Ticket] ([ID], [ID_Movie], [Ticket_type], [Price], [Quantity]) VALUES (6, 2, N'Basic', 20000, 20)
INSERT [dbo].[Ticket] ([ID], [ID_Movie], [Ticket_type], [Price], [Quantity]) VALUES (7, 4, N'Basic', 20, 10)
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Movie] FOREIGN KEY([ID_Movie])
REFERENCES [dbo].[Movie] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Movie]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Genres] FOREIGN KEY([Genre_ID])
REFERENCES [dbo].[Genres] ([ID])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Genres]
GO
ALTER TABLE [dbo].[Revenue]  WITH CHECK ADD  CONSTRAINT [FK_Revenue_Movie] FOREIGN KEY([Movie_ID])
REFERENCES [dbo].[Movie] ([ID])
GO
ALTER TABLE [dbo].[Revenue] CHECK CONSTRAINT [FK_Revenue_Movie]
GO
ALTER TABLE [dbo].[ShowTime]  WITH CHECK ADD  CONSTRAINT [FK_ShowTime_Movie] FOREIGN KEY([Movie_ID])
REFERENCES [dbo].[Movie] ([ID])
GO
ALTER TABLE [dbo].[ShowTime] CHECK CONSTRAINT [FK_ShowTime_Movie]
GO
ALTER TABLE [dbo].[ShowTime]  WITH CHECK ADD  CONSTRAINT [FK_ShowTime_Room] FOREIGN KEY([Room_ID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[ShowTime] CHECK CONSTRAINT [FK_ShowTime_Room]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Movie] FOREIGN KEY([ID_Movie])
REFERENCES [dbo].[Movie] ([ID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Movie]
GO
USE [master]
GO
ALTER DATABASE [CinemaProject_v4] SET  READ_WRITE 
GO
