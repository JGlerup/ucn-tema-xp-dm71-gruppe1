use dm71_2
CREATE TABLE [dbo].[Shows]
(
	shows_id int PRIMARY KEY IDENTITY,
	time_clock time NOT NULL, 
	time_date date NOT NULL,
	play_time time NOT NULL,
	cinema_nr int NOT NULL,
	movie_title varchar(100) NOT NULL
)
