
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/01/2022 20:12:21
-- Generated from EDMX file: C:\Users\nguye\OneDrive\Desktop\Final_Project\Final\Context\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Final_Project];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[orders];
GO
IF OBJECT_ID(N'[dbo].[products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[products];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'orders'
CREATE TABLE [dbo].[orders] (
    [order_id] decimal(18,0)  NOT NULL,
    [order_name] varchar(255)  NULL,
    [order_date] datetime  NULL,
    [users_id] decimal(18,0)  NOT NULL,
    [pd_id] decimal(18,0)  NOT NULL,
    [voucher_id] decimal(18,0)  NOT NULL,
    [total_price] float  NULL
);
GO

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [pd_id] decimal(18,0)  NOT NULL,
    [pd_name] nvarchar(255)  NULL,
    [pd_detail] nvarchar(4000)  NULL,
    [pd_price] float  NULL,
    [qty] int  NULL,
    [status] int  NULL,
    [pd_image] varbinary(max)  NULL,
    [pd_added] datetime  NULL,
    [pd_imagePath] nvarchar(1000)  NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [users_id] decimal(18,0)  NOT NULL,
    [users_password] nvarchar(255)  NULL,
    [users_email] nvarchar(255)  NULL,
    [users_fullname] nvarchar(255)  NULL,
    [users_phone] nvarchar(255)  NULL,
    [users_gender] int  NULL,
    [users_birthday] datetime  NULL,
    [role_id] int  NULL,
    [status] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [order_id] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [PK_orders]
    PRIMARY KEY CLUSTERED ([order_id] ASC);
GO

-- Creating primary key on [pd_id] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([pd_id] ASC);
GO

-- Creating primary key on [users_id] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([users_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------