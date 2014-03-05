IF EXISTS(SELECT 1 FROM sysobjects WHERE ID = OBJECT_ID(N'[dbo].[SP_CreateMovie]') AND TYPE IN (N'P', N'PC'))
	DROP PROCEDURE [dbo].[SP_CreateMovie]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 
-- ********************************************************
--  Project Name   : Movie App
--	Location	   : MAN01-DY90FV1\SQLEXPRESS2012
--  DB             : MoviesDB			   					   
--  Item           : [SP_CreateMovie]
--  Ref Number     : N/A
--  Description    : This stored procedure is used to add a new movie into the database.
-- 
--  Configuration Record
-- 
--  Ver  Author     		Date		Change
--  0    Evgeny Lukiyanov	02-02-2014	Original Build
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_CreateMovie](
			@TITLE VARCHAR(100),
			@RATING FLOAT,
			@RELEASE DATETIME
)

	AS
	BEGIN
		SET NOCOUNT ON 
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
		SET LOCK_TIMEOUT 10000 


	/*

		DECLARE @TITLE VARCHAR(100)
		DECLARE @RATING FLOAT
		DECLARE @RELEASE DATETIME


		SET @TITLE = 'Walter Mitty'
		SET @RATING = 5.5
		SET @RELEASE = '01-01-2013'

	--*/


		INSERT INTO Movies([Title], [Rating], [Release]) 
				   VALUES (@Title, @Rating, @Release)
		

		
	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

