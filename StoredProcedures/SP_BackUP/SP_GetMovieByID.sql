IF EXISTS(SELECT 1 FROM sysobjects WHERE ID = OBJECT_ID(N'[dbo].[SP_GetMovieByID]') AND TYPE IN (N'P', N'PC'))
	DROP PROCEDURE [dbo].[SP_GetMovieByID]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 
-- ********************************************************
--  Project Name   : Movie App
--	Location	   : MAN01-DY90FV1\SQLEXPRESS2012
--  DB             : MoviesDB			   					   
--  Item           : [SP_GetMovieByID]
--  Ref Number     : N/A
--  Description    : This stored procedure is used to return a movie when searched by ID
-- 
--  Configuration Record
-- 
--  Ver  Author     		Date		Change
--  0    Evgeny Lukiyanov	03-02-2014	Original Build
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_GetMovieByID](
			@ID INT
)

	AS
	BEGIN
		SET NOCOUNT ON 
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
		SET LOCK_TIMEOUT 10000 


	/*

		DECLARE @ID INT
		SET @ID = 5

	--*/


		SELECT ID, [Title], [Rating], [Release]
		FROM dbo.Movies
		WHERE 1 = 1
		AND ID= @ID
		

		
	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

