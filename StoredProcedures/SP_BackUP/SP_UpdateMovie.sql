IF EXISTS(SELECT 1 FROM sysobjects WHERE ID = OBJECT_ID(N'[dbo].[SP_UpdateMovie]') AND TYPE IN (N'P', N'PC'))
	DROP PROCEDURE [dbo].[SP_UpdateMovie]
GO



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 
-- ********************************************************
--  Project Name   : Movie App
--	Location	   : MAN01-DY90FV1\SQLEXPRESS2012
--  DB             : MoviesDB			   					   
--  Item           : [SP_UpdateMovie]
--  Ref Number     : N/A
--  Description    : This stored procedure updates a movie
-- 
--  Configuration Record
-- 
--  Ver  Author     		Date		Change
--  0    Evgeny Lukiyanov	02-02-2014	Original Build
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_UpdateMovie](
			@ID INT,
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

		DECLARE @ID INT
		DECLARE @TITLE VARCHAR(100)
		DECLARE @RATING FLOAT
		DECLARE @RELEASE DATETIME

		SET @ID = '2'
		SET @TITLE = 'Die Hard '
		SET @RATING = 9.9
		SET @RELEASE = '01-01-1988'

	--*/


		UPDATE dbo.Movies
		SET [Title] = @Title, 
			[Rating] = @Rating, 
			[Release] = @Release 
		WHERE 1 = 1
		AND [ID] = @ID
		


	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

