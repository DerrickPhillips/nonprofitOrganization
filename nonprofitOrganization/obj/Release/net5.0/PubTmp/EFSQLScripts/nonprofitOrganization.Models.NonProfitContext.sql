IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [Firstname] nvarchar(max) NULL,
        [Lastname] nvarchar(max) NULL,
        [MemberID] int NOT NULL IDENTITY,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id]),
        CONSTRAINT [AK_AspNetUsers_MemberID] UNIQUE ([MemberID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [Donors] (
        [DonorID] int NOT NULL IDENTITY,
        [Address] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [ContactPreference] nvarchar(max) NULL,
        CONSTRAINT [PK_Donors] PRIMARY KEY ([DonorID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [Events] (
        [EventID] int NOT NULL IDENTITY,
        [MemberID] int NOT NULL,
        [EventName] nvarchar(max) NOT NULL,
        [EventDescription] nvarchar(max) NOT NULL,
        [EventDate] datetime2 NOT NULL,
        [EventLocation] nvarchar(max) NOT NULL,
        [EventLeader] nvarchar(max) NOT NULL,
        [GuestList] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Events] PRIMARY KEY ([EventID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [News] (
        [NewsID] int NOT NULL IDENTITY,
        [DatePosted] datetime2 NOT NULL,
        [NewsAuthor] nvarchar(max) NULL,
        [NewsTitle] nvarchar(max) NOT NULL,
        [Body] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_News] PRIMARY KEY ([NewsID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [Members] (
        [MemberID] nvarchar(450) NOT NULL,
        [UserId] nvarchar(450) NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [Phone] nvarchar(max) NULL,
        [Address] nvarchar(max) NOT NULL,
        [Dues] float NOT NULL,
        [PaymentType] nvarchar(max) NOT NULL,
        [DueDate] datetime2 NOT NULL,
        [MailingListMember] nvarchar(max) NOT NULL,
        [Comments] nvarchar(max) NULL,
        [ContactPref] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Members] PRIMARY KEY ([MemberID]),
        CONSTRAINT [FK_Members_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [Donations] (
        [DonationID] int NOT NULL IDENTITY,
        [DateDonated] datetime2 NOT NULL,
        [Comments] nvarchar(max) NULL,
        [DonorID] int NOT NULL,
        [Amount] float NOT NULL,
        CONSTRAINT [PK_Donations] PRIMARY KEY ([DonationID]),
        CONSTRAINT [FK_Donations_Donors_DonorID] FOREIGN KEY ([DonorID]) REFERENCES [Donors] ([DonorID]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE TABLE [Funds] (
        [FundID] int NOT NULL IDENTITY,
        [Amount] float NOT NULL,
        [DonationID] int NULL,
        [Dues] float NOT NULL,
        [MemberID] nvarchar(450) NULL,
        CONSTRAINT [PK_Funds] PRIMARY KEY ([FundID]),
        CONSTRAINT [FK_Funds_Donations_DonationID] FOREIGN KEY ([DonationID]) REFERENCES [Donations] ([DonationID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Funds_Members_MemberID] FOREIGN KEY ([MemberID]) REFERENCES [Members] ([MemberID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] ON;
    EXEC(N'INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
    VALUES (N''1'', N''b14eb6f6-5087-410b-9197-beccd9f22b05'', N''Admin'', N''ADMIN''),
    (N''2'', N''33613fa6-a3a1-4f5b-a599-ac21752d5d7d'', N''Member'', N''MEMBER''),
    (N''3'', N''c801c33c-2040-4b2c-8e78-2e796fdab84d'', N''Donor'', N''DONOR''),
    (N''4'', N''abad8dec-91b7-4f32-9e9c-f0309026cc5e'', N''Staff'', N''STAFF'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'Firstname', N'Lastname', N'LockoutEnabled', N'LockoutEnd', N'MemberID', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] ON;
    EXEC(N'INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [Firstname], [Lastname], [LockoutEnabled], [LockoutEnd], [MemberID], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
    VALUES (N''1'', 0, N''8dc59662-f846-4eaf-94eb-65c1c613a35d'', N''simmonsb218569@my.gvltec.edu'', CAST(1 AS bit), NULL, NULL, CAST(0 AS bit), NULL, 1, N''SIMMONSB218569@MY.GVLTEC.EDU'', N''ADMIN@CPT275.BEAUSANDERS.ORG'', N''AQAAAAEAACcQAAAAEGQuWo67JfdSx7THeTUk0ReVA7q6fE0PHRRn2khUIQl4T1F21KAQBXyARXq7lbBkAQ=='', NULL, CAST(0 AS bit), N''1f6e9044-38fa-4483-9e3a-7dd8ca2afe4c'', CAST(0 AS bit), N''admin@cpt275.beausanders.org'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'Firstname', N'Lastname', N'LockoutEnabled', N'LockoutEnd', N'MemberID', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
        SET IDENTITY_INSERT [AspNetUserRoles] ON;
    EXEC(N'INSERT INTO [AspNetUserRoles] ([RoleId], [UserId])
    VALUES (N''1'', N''1'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
        SET IDENTITY_INSERT [AspNetUserRoles] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE UNIQUE INDEX [IX_AspNetUsers_MemberID] ON [AspNetUsers] ([MemberID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_Donations_DonorID] ON [Donations] ([DonorID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_Funds_DonationID] ON [Funds] ([DonationID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_Funds_MemberID] ON [Funds] ([MemberID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    CREATE INDEX [IX_Members_UserId] ON [Members] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000100_Inital')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210404000100_Inital', N'5.0.4');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000118_AddIdentityTables')
BEGIN
    EXEC(N'UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N''748bfb18-ac48-416c-81a5-41cc4757b944''
    WHERE [Id] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000118_AddIdentityTables')
BEGIN
    EXEC(N'UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N''de996fcd-86ad-4557-8148-a6c23357fa61''
    WHERE [Id] = N''2'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000118_AddIdentityTables')
BEGIN
    EXEC(N'UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N''4049b0a2-2f6a-407e-a67a-8629dcb98579''
    WHERE [Id] = N''3'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000118_AddIdentityTables')
BEGIN
    EXEC(N'UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N''65d51704-de1d-4234-aa1b-a0c431a83fda''
    WHERE [Id] = N''4'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000118_AddIdentityTables')
BEGIN
    EXEC(N'UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N''1a8acf83-c64c-421a-ade6-81cfc582e3cb'', [PasswordHash] = N''AQAAAAEAACcQAAAAENGDJzn8SLcGIYSG0sUj8j0poHGgKayctIovs6HiQQF1PY19W+OXdggOM4C4oqxNeQ=='', [SecurityStamp] = N''f0aa1f9b-683b-47bb-8f4d-adec40d06d2e''
    WHERE [Id] = N''1'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210404000118_AddIdentityTables')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210404000118_AddIdentityTables', N'5.0.4');
END;
GO

COMMIT;
GO

