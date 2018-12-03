
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/02/2018 22:16:51
-- Generated from EDMX file: C:\Users\Josue\Documents\U\Topicos Selectos\Proyecto\ProyectoTopicos\ProyectoTopicos\ProyectoTopicos.Model\DataBaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TopicosSelectos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Articulos__categ__4CA06362]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK__Articulos__categ__4CA06362];
GO
IF OBJECT_ID(N'[dbo].[FK__Articulos__subCa__4D94879B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK__Articulos__subCa__4D94879B];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroD__categ__71D1E811]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroDePerdidas] DROP CONSTRAINT [FK__RegistroD__categ__71D1E811];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroD__codig__06CD04F7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroDevoluciones] DROP CONSTRAINT [FK__RegistroD__codig__06CD04F7];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroD__codig__07C12930]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroDevoluciones] DROP CONSTRAINT [FK__RegistroD__codig__07C12930];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroD__codig__70DDC3D8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroDePerdidas] DROP CONSTRAINT [FK__RegistroD__codig__70DDC3D8];
GO
IF OBJECT_ID(N'[dbo].[FK__RegistroD__subCa__72C60C4A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroDePerdidas] DROP CONSTRAINT [FK__RegistroD__subCa__72C60C4A];
GO
IF OBJECT_ID(N'[dbo].[FK__Usuarios__perfil__6E01572D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK__Usuarios__perfil__6E01572D];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Articulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Articulos];
GO
IF OBJECT_ID(N'[dbo].[CategoriasArticulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriasArticulos];
GO
IF OBJECT_ID(N'[dbo].[Perfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfiles];
GO
IF OBJECT_ID(N'[dbo].[RegistroDePerdidas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegistroDePerdidas];
GO
IF OBJECT_ID(N'[dbo].[RegistroDevoluciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegistroDevoluciones];
GO
IF OBJECT_ID(N'[dbo].[SubCategoriasArticulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubCategoriasArticulos];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Articulos'
CREATE TABLE [dbo].[Articulos] (
    [codigoArticulo] varchar(50)  NOT NULL,
    [nombre] varchar(50)  NOT NULL,
    [fechaIngreso] datetime  NOT NULL,
    [estado] varchar(50)  NOT NULL,
    [categoria] varchar(50)  NULL,
    [subCategoria] varchar(50)  NULL,
    [fechaEntrega] datetime  NULL,
    [descripcion] varchar(200)  NULL
);
GO

-- Creating table 'CategoriasArticulos'
CREATE TABLE [dbo].[CategoriasArticulos] (
    [codigoCategoria] varchar(50)  NOT NULL,
    [categoria] varchar(50)  NOT NULL
);
GO

-- Creating table 'RegistroDePerdidas'
CREATE TABLE [dbo].[RegistroDePerdidas] (
    [codigoUsuario] varchar(50)  NOT NULL,
    [categoria] varchar(50)  NOT NULL,
    [subCategoria] varchar(50)  NOT NULL,
    [descripcion] varchar(200)  NOT NULL
);
GO

-- Creating table 'SubCategoriasArticulos'
CREATE TABLE [dbo].[SubCategoriasArticulos] (
    [codigoSubCategoria] varchar(50)  NOT NULL,
    [subCategoria] varchar(50)  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [codigoUsuario] varchar(50)  NOT NULL,
    [nombre] varchar(50)  NOT NULL,
    [correo] varchar(50)  NULL,
    [perfil] varchar(50)  NULL
);
GO

-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [codigoPerfil] varchar(50)  NOT NULL,
    [perfil] varchar(50)  NOT NULL
);
GO

-- Creating table 'RegistroDevoluciones1Set'
CREATE TABLE [dbo].[RegistroDevoluciones1Set] (
    [codigoDevolucion] varchar(50)  NOT NULL,
    [codigoUsuario] varchar(50)  NOT NULL,
    [codigoArticulo] varchar(50)  NOT NULL
);
GO

-- Creating table 'RegistroDevoluciones'
CREATE TABLE [dbo].[RegistroDevoluciones] (
    [Usuarios_codigoUsuario] varchar(50)  NOT NULL,
    [Articulos_codigoArticulo] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [codigoArticulo] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [PK_Articulos]
    PRIMARY KEY CLUSTERED ([codigoArticulo] ASC);
GO

-- Creating primary key on [codigoCategoria] in table 'CategoriasArticulos'
ALTER TABLE [dbo].[CategoriasArticulos]
ADD CONSTRAINT [PK_CategoriasArticulos]
    PRIMARY KEY CLUSTERED ([codigoCategoria] ASC);
GO

-- Creating primary key on [codigoUsuario], [categoria], [subCategoria], [descripcion] in table 'RegistroDePerdidas'
ALTER TABLE [dbo].[RegistroDePerdidas]
ADD CONSTRAINT [PK_RegistroDePerdidas]
    PRIMARY KEY CLUSTERED ([codigoUsuario], [categoria], [subCategoria], [descripcion] ASC);
GO

-- Creating primary key on [codigoSubCategoria] in table 'SubCategoriasArticulos'
ALTER TABLE [dbo].[SubCategoriasArticulos]
ADD CONSTRAINT [PK_SubCategoriasArticulos]
    PRIMARY KEY CLUSTERED ([codigoSubCategoria] ASC);
GO

-- Creating primary key on [codigoUsuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([codigoUsuario] ASC);
GO

-- Creating primary key on [codigoPerfil] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([codigoPerfil] ASC);
GO

-- Creating primary key on [codigoDevolucion] in table 'RegistroDevoluciones1Set'
ALTER TABLE [dbo].[RegistroDevoluciones1Set]
ADD CONSTRAINT [PK_RegistroDevoluciones1Set]
    PRIMARY KEY CLUSTERED ([codigoDevolucion] ASC);
GO

-- Creating primary key on [Usuarios_codigoUsuario], [Articulos_codigoArticulo] in table 'RegistroDevoluciones'
ALTER TABLE [dbo].[RegistroDevoluciones]
ADD CONSTRAINT [PK_RegistroDevoluciones]
    PRIMARY KEY CLUSTERED ([Usuarios_codigoUsuario], [Articulos_codigoArticulo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [categoria] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK__Articulos__categ__3B75D760]
    FOREIGN KEY ([categoria])
    REFERENCES [dbo].[CategoriasArticulos]
        ([codigoCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Articulos__categ__3B75D760'
CREATE INDEX [IX_FK__Articulos__categ__3B75D760]
ON [dbo].[Articulos]
    ([categoria]);
GO

-- Creating foreign key on [subCategoria] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK__Articulos__subCa__3C69FB99]
    FOREIGN KEY ([subCategoria])
    REFERENCES [dbo].[SubCategoriasArticulos]
        ([codigoSubCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Articulos__subCa__3C69FB99'
CREATE INDEX [IX_FK__Articulos__subCa__3C69FB99]
ON [dbo].[Articulos]
    ([subCategoria]);
GO

-- Creating foreign key on [categoria] in table 'RegistroDePerdidas'
ALTER TABLE [dbo].[RegistroDePerdidas]
ADD CONSTRAINT [FK__RegistroD__categ__4222D4EF]
    FOREIGN KEY ([categoria])
    REFERENCES [dbo].[CategoriasArticulos]
        ([codigoCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroD__categ__4222D4EF'
CREATE INDEX [IX_FK__RegistroD__categ__4222D4EF]
ON [dbo].[RegistroDePerdidas]
    ([categoria]);
GO

-- Creating foreign key on [codigoUsuario] in table 'RegistroDePerdidas'
ALTER TABLE [dbo].[RegistroDePerdidas]
ADD CONSTRAINT [FK__RegistroD__codig__412EB0B6]
    FOREIGN KEY ([codigoUsuario])
    REFERENCES [dbo].[Usuarios]
        ([codigoUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [subCategoria] in table 'RegistroDePerdidas'
ALTER TABLE [dbo].[RegistroDePerdidas]
ADD CONSTRAINT [FK__RegistroD__subCa__4316F928]
    FOREIGN KEY ([subCategoria])
    REFERENCES [dbo].[SubCategoriasArticulos]
        ([codigoSubCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroD__subCa__4316F928'
CREATE INDEX [IX_FK__RegistroD__subCa__4316F928]
ON [dbo].[RegistroDePerdidas]
    ([subCategoria]);
GO

-- Creating foreign key on [Usuarios_codigoUsuario] in table 'RegistroDevoluciones'
ALTER TABLE [dbo].[RegistroDevoluciones]
ADD CONSTRAINT [FK_RegistroDevoluciones_Usuarios]
    FOREIGN KEY ([Usuarios_codigoUsuario])
    REFERENCES [dbo].[Usuarios]
        ([codigoUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Articulos_codigoArticulo] in table 'RegistroDevoluciones'
ALTER TABLE [dbo].[RegistroDevoluciones]
ADD CONSTRAINT [FK_RegistroDevoluciones_Articulos]
    FOREIGN KEY ([Articulos_codigoArticulo])
    REFERENCES [dbo].[Articulos]
        ([codigoArticulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RegistroDevoluciones_Articulos'
CREATE INDEX [IX_FK_RegistroDevoluciones_Articulos]
ON [dbo].[RegistroDevoluciones]
    ([Articulos_codigoArticulo]);
GO

-- Creating foreign key on [perfil] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK__Usuarios__perfil__6E01572D]
    FOREIGN KEY ([perfil])
    REFERENCES [dbo].[Perfiles]
        ([codigoPerfil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Usuarios__perfil__6E01572D'
CREATE INDEX [IX_FK__Usuarios__perfil__6E01572D]
ON [dbo].[Usuarios]
    ([perfil]);
GO

-- Creating foreign key on [codigoArticulo] in table 'RegistroDevoluciones1Set'
ALTER TABLE [dbo].[RegistroDevoluciones1Set]
ADD CONSTRAINT [FK__RegistroD__codig__07C12930]
    FOREIGN KEY ([codigoArticulo])
    REFERENCES [dbo].[Articulos]
        ([codigoArticulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroD__codig__07C12930'
CREATE INDEX [IX_FK__RegistroD__codig__07C12930]
ON [dbo].[RegistroDevoluciones1Set]
    ([codigoArticulo]);
GO

-- Creating foreign key on [codigoUsuario] in table 'RegistroDevoluciones1Set'
ALTER TABLE [dbo].[RegistroDevoluciones1Set]
ADD CONSTRAINT [FK__RegistroD__codig__06CD04F7]
    FOREIGN KEY ([codigoUsuario])
    REFERENCES [dbo].[Usuarios]
        ([codigoUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RegistroD__codig__06CD04F7'
CREATE INDEX [IX_FK__RegistroD__codig__06CD04F7]
ON [dbo].[RegistroDevoluciones1Set]
    ([codigoUsuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------