
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/04/2018 15:17:06
-- Generated from EDMX file: C:\Users\DanielS\Documents\Visual Studio 2017\Projects\WooSahCodex\WooSahCodexEFLoader\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WooSahCodex];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[WooSah]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WooSah];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WooSahs'
CREATE TABLE [dbo].[WooSahs] (
    [WooSahId] bigint  NOT NULL,
    [Model] nvarchar(50)  NOT NULL,
    [Etching] nvarchar(50)  NOT NULL,
    [Color] nvarchar(50)  NOT NULL,
    [Material] nvarchar(50)  NOT NULL,
    [Finish] nvarchar(50)  NOT NULL,
    [IsValid] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [WooSahId] in table 'WooSahs'
ALTER TABLE [dbo].[WooSahs]
ADD CONSTRAINT [PK_WooSahs]
    PRIMARY KEY CLUSTERED ([WooSahId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------