CREATE TABLE [dbo].[Account] (
  [loginid] [int] NOT NULL,
  [account] [varchar](50) NULL,
  [password] [varchar](50) NULL,
  CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([loginid])
)
ON [PRIMARY]
GO