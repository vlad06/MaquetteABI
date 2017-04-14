
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/14/2017 11:03:56
-- Generated from EDMX file: C:\Users\DL-CDI\Documents\Visual Studio 2015\Projects\MaquetteABI\WindowsFormsApplication1\ModelABI.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABIdatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TContact_TClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TContact] DROP CONSTRAINT [FK_TContact_TClient];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TClient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TClient];
GO
IF OBJECT_ID(N'[dbo].[TContact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TContact];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TClient'
CREATE TABLE [dbo].[TClient] (
    [IdClient] int  NOT NULL,
    [RaisonSociale] varchar(50)  NOT NULL,
    [TypeSociete] varchar(50)  NOT NULL,
    [Activite] varchar(50)  NOT NULL,
    [Adresse] varchar(50)  NOT NULL,
    [Telephone] varchar(50)  NOT NULL,
    [Nature] varchar(50)  NOT NULL,
    [Ca] decimal(19,4)  NOT NULL,
    [Effectif] int  NOT NULL,
    [CommentComm] varchar(800)  NULL
);
GO

-- Creating table 'TContact'
CREATE TABLE [dbo].[TContact] (
    [IdContact] int  NOT NULL,
    [NomContact] varchar(50)  NOT NULL,
    [PrenomContact] varchar(50)  NOT NULL,
    [TelContact] varchar(50)  NOT NULL,
    [FonctionContact] varchar(50)  NOT NULL,
    [TotalHeuresContact] decimal(8,2)  NULL,
    [IdClient] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [IdClient] in table 'TClient'
ALTER TABLE [dbo].[TClient]
ADD CONSTRAINT [PK_TClient]
    PRIMARY KEY CLUSTERED ([IdClient] ASC);
GO

-- Creating primary key on [IdContact] in table 'TContact'
ALTER TABLE [dbo].[TContact]
ADD CONSTRAINT [PK_TContact]
    PRIMARY KEY CLUSTERED ([IdContact] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdClient] in table 'TContact'
ALTER TABLE [dbo].[TContact]
ADD CONSTRAINT [FK_TContact_TClient]
    FOREIGN KEY ([IdClient])
    REFERENCES [dbo].[TClient]
        ([IdClient])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TContact_TClient'
CREATE INDEX [IX_FK_TContact_TClient]
ON [dbo].[TContact]
    ([IdClient]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------