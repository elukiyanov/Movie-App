IF EXISTS(SELECT 1 FROM sysobjects WHERE ID = OBJECT_ID(N'[dbo].[SP_DeleteMovieByID]') AND TYPE IN (N'P', N'PC'))
	DROP PROCEDURE [dbo].[SP_DeleteMovieByID]
GO



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 
-- ********************************************************
--  Project Name   : Movie App
--	Location	   : MAN01-DY90FV1\SQLEXPRESS2012
--  DB             : MoviesDB			   					   
--  Item           : [SP_DeleteMovieByID]
--  Ref Number     : N/A
--  Description    : This stored procedure is used to delete a movie by ID
-- 
--  Configuration Record
-- 
--  Ver  Author     		Date		Change
--  0    Evgeny Lukiyanov	02-02-2014	Original Build
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_DeleteMovieByID](
			@ID INT
)

	AS
	BEGIN
		SET NOCOUNT ON 
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
		SET LOCK_TIMEOUT 10000 


	/*
		--SELECT * FROM Movies

		DECLARE @ID INT

		SET @ID = '14'

	--*/


		DELETE FROM dbo.Movies
		WHERE 1 = 1
		AND [ID] = @ID
		


	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

