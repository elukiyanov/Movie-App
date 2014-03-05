IF EXISTS(SELECT 1 FROM sysobjects WHERE ID = OBJECT_ID(N'[dbo].[SP_UpdateMovieImage]') AND TYPE IN (N'P', N'PC'))
	DROP PROCEDURE [dbo].[SP_UpdateMovieImage]
GO



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 
-- ********************************************************
--  Project Name   : Movie App
--	Location	   : MAN01-DY90FV1\SQLEXPRESS2012
--  DB             : MoviesDB			   					   
--  Item           : [SP_UpdateMovieImage]
--  Ref Number     : N/A
--  Description    : This stored procedure is used to update the image name
-- 
--  Configuration Record
-- 
--  Ver  Author     		Date		Change
--  0    Evgeny Lukiyanov	09-02-2014	Original Build
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_UpdateMovieImage](
					@ID INT,
					@IMAGE VARCHAR(255)
)

	AS
	BEGIN
		SET NOCOUNT ON 
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
		SET LOCK_TIMEOUT 10000 


	/*
		--SELECT * FROM Movies

		DECLARE @ID INT
		SET @ORDER = 6

	--*/


		UPDATE dbo.Movies
		SET CoverImage = @IMAGE
		WHERE 1 = 1
		AND ID = @ID


	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

