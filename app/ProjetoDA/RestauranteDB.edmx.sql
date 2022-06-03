
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/27/2022 10:25:54
-- Generated from EDMX file: C:\Users\Goncalo Neves\Desktop\IPL\DA\ProjetoDA\ProjetoDA\ProjetoDA\RestauranteDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProjetoDA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenus] DROP CONSTRAINT [FK_CategoriaItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteTrabalhador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_RestauranteTrabalhador];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_PedidoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurantes] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_ClientePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoEstados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_PedidoEstados];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidos] DROP CONSTRAINT [FK_RestaurantePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas] DROP CONSTRAINT [FK_PessoaMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_MetodoPagamentos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentos] DROP CONSTRAINT [FK_MetodoPagamentos];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Moradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moradas];
GO
IF OBJECT_ID(N'[dbo].[Restaurantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurantes];
GO
IF OBJECT_ID(N'[dbo].[ItemMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenus];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Pedidos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedidos];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[MetodoPagamentoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodoPagamentoes];
GO
IF OBJECT_ID(N'[dbo].[Pagamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamentos];
GO
IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuRestaurante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuRestaurante];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Moradas'
CREATE TABLE [dbo].[Moradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Cod_Postal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Restaurantes'
CREATE TABLE [dbo].[Restaurantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenus'
CREATE TABLE [dbo].[ItemMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [Ativo] bit  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pedidos'
CREATE TABLE [dbo].[Pedidos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor_Total] float  NOT NULL,
    [EstadosId] int  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [Cliente_Id] int  NOT NULL,
    [Trabalhador_Id] int  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MetodoPagamentoes'
CREATE TABLE [dbo].[MetodoPagamentoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Metodo_Pagamento] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pagamentos'
CREATE TABLE [dbo].[Pagamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [MetodoPagamentoId] nvarchar(max)  NOT NULL,
    [PedidoId] int  NOT NULL,
    [MetodoPagamentoId1] int  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Trabalhador'
CREATE TABLE [dbo].[Pessoas_Trabalhador] (
    [Salario] float  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [Total_Gasto] float  NOT NULL,
    [Num_Contribuinte] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuRestaurante'
CREATE TABLE [dbo].[ItemMenuRestaurante] (
    [ItemMenus_Id] int  NOT NULL,
    [Restaurantes_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoItemMenu'
CREATE TABLE [dbo].[PedidoItemMenu] (
    [Pedidoes_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Moradas'
ALTER TABLE [dbo].[Moradas]
ADD CONSTRAINT [PK_Moradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [PK_Restaurantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [PK_ItemMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [PK_Pedidos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamentoes'
ALTER TABLE [dbo].[MetodoPagamentoes]
ADD CONSTRAINT [PK_MetodoPagamentoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [PK_Pagamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [PK_Pessoas_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ItemMenus_Id], [Restaurantes_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [PK_ItemMenuRestaurante]
    PRIMARY KEY CLUSTERED ([ItemMenus_Id], [Restaurantes_Id] ASC);
GO

-- Creating primary key on [Pedidoes_Id], [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [PK_PedidoItemMenu]
    PRIMARY KEY CLUSTERED ([Pedidoes_Id], [ItemMenus_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ItemMenus_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Restaurantes_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_Restaurante]
    FOREIGN KEY ([Restaurantes_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuRestaurante_Restaurante'
CREATE INDEX [IX_FK_ItemMenuRestaurante_Restaurante]
ON [dbo].[ItemMenuRestaurante]
    ([Restaurantes_Id]);
GO

-- Creating foreign key on [CategoriaId] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [FK_CategoriaItemMenu]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaItemMenu'
CREATE INDEX [IX_FK_CategoriaItemMenu]
ON [dbo].[ItemMenus]
    ([CategoriaId]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[Pessoas_Trabalhador]
    ([RestauranteId]);
GO

-- Creating foreign key on [PedidoId] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[Pagamentos]
    ([PedidoId]);
GO

-- Creating foreign key on [Morada_Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[Restaurantes]
    ([Morada_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[Pedidos]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Trabalhador_Id] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([Trabalhador_Id])
    REFERENCES [dbo].[Pessoas_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[Pedidos]
    ([Trabalhador_Id]);
GO

-- Creating foreign key on [EstadosId] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_PedidoEstados]
    FOREIGN KEY ([EstadosId])
    REFERENCES [dbo].[Estados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoEstados'
CREATE INDEX [IX_FK_PedidoEstados]
ON [dbo].[Pedidos]
    ([EstadosId]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pedidos'
ALTER TABLE [dbo].[Pedidos]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[Pedidos]
    ([RestauranteId]);
GO

-- Creating foreign key on [Morada_Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[Pessoas]
    ([Morada_Id]);
GO

-- Creating foreign key on [MetodoPagamentoId1] in table 'Pagamentos'
ALTER TABLE [dbo].[Pagamentos]
ADD CONSTRAINT [FK_MetodoPagamentos]
    FOREIGN KEY ([MetodoPagamentoId1])
    REFERENCES [dbo].[MetodoPagamentoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MetodoPagamentos'
CREATE INDEX [IX_FK_MetodoPagamentos]
ON [dbo].[Pagamentos]
    ([MetodoPagamentoId1]);
GO

-- Creating foreign key on [Pedidoes_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_Pedido]
    FOREIGN KEY ([Pedidoes_Id])
    REFERENCES [dbo].[Pedidos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoItemMenu_ItemMenu'
CREATE INDEX [IX_FK_PedidoItemMenu_ItemMenu]
ON [dbo].[PedidoItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------