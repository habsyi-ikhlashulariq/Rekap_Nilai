/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [npm]
      ,[nm_mhs]
      ,[kelas]
      ,[alamat]
  FROM [db_akademik].[dbo].[tb_mhs]
  
  Delete FROM tb_mhs