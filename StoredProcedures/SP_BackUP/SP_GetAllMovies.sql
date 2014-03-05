IF EXISTS(SELECT 1 FROM sysobjects WHERE ID = OBJECT_ID(N'[dbo].[SP_GetAllMovies]') AND TYPE IN (N'P', N'PC'))
	DROP PROCEDURE [dbo].[SP_GetAllMovies]
GO



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 
-- ********************************************************
--  Project Name   : Movie App
--	Location	   : MAN01-DY90FV1\SQLEXPRESS2012
--  DB             : MoviesDB			   					   
--  Item           : [SP_GetAllMovies]
--  Ref Number     : N/A
--  Description    : This stored procedure is used to ret all the movies from the dtabase.
-- 
--  Configuration Record
-- 
--  Ver  Author     		Date		Change
--  0    Evgeny Lukiyanov	04-02-2014	Original Build
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_GetAllMovies]

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


		SELECT ID, Title, Rating, Release 
		FROM dbo.Movies
		WHERE 1 = 1
		


	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

