
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/19/2017 08:56:21
-- Generated from EDMX file: C:\Users\Kristiyan\Desktop\THINGS\School Things\SEP 4\Dot Net Memes\Via cinema project Lyubomir Kristiyan\WebsiteTest\WebsiteTest\CinemaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Cinema];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CartTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CartTable];
GO
IF OBJECT_ID(N'[dbo].[MovieTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieTable];
GO
IF OBJECT_ID(N'[dbo].[UserTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserTable];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CartTables'
CREATE TABLE [dbo].[CartTables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [movie_name] varchar(50)  NOT NULL,
    [ticket_price] float  NOT NULL
);
GO

-- Creating table 'MovieTables'
CREATE TABLE [dbo].[MovieTables] (
    [Id] int  NOT NULL,
    [movie_name] varchar(50)  NOT NULL,
    [ticket_price] float  NOT NULL
);
GO

-- Creating table 'UserTables'
CREATE TABLE [dbo].[UserTables] (
    [Id] int  NOT NULL,
    [user_name] varchar(50)  NOT NULL,
    [password] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CartTables'
ALTER TABLE [dbo].[CartTables]
ADD CONSTRAINT [PK_CartTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MovieTables'
ALTER TABLE [dbo].[MovieTables]
ADD CONSTRAINT [PK_MovieTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserTables'
ALTER TABLE [dbo].[UserTables]
ADD CONSTRAINT [PK_UserTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------