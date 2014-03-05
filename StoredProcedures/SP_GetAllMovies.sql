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
--  1	 Evgeny Lukiyanov	08-02-2014	Added order parameter.
--
--  Copyright Building-Blocks (UK) Limited 2014
-- *********************************************************



CREATE PROCEDURE [dbo].[SP_GetAllMovies](
					@ORDER INT
)

	AS
	BEGIN
		SET NOCOUNT ON 
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
		SET LOCK_TIMEOUT 10000 


	/*
		--SELECT * FROM Movies

		DECLARE @ORDER INT
		SET @ORDER = 6

	--*/


		SELECT ID, Title, Rating, Release, CoverImage, Genre, Director, Actors, Synopsis  
		FROM dbo.Movies
		WHERE 1 = 1
		ORDER BY 
				CASE WHEN @ORDER = 0 THEN ID END,
				CASE WHEN @ORDER = 1 THEN Title END,
				CASE WHEN @ORDER = 2 THEN Release END,
				CASE WHEN @ORDER = 3 THEN Release END DESC, --
				CASE WHEN @ORDER = 4 THEN Rating  END DESC,
				CASE WHEN @ORDER = 5 THEN Genre END,
				CASE WHEN @ORDER = 6 THEN CoverImage END DESC


	RETURN
	END

GO



----------------------------- Test Area ----------------------------------

