use dm71_2
create table Movie(
	Id int PRIMARY KEY IDENTITY,
	ReleaseDate varchar(50),
	Title varchar(50),
	Distributor varchar(50),
	ArrivalDate varchar(50),
	ReturnDate varchar(50),
	Duration time,
	Director varchar(50),
	Actors varchar(50),
	MovieDescription varchar(50))

create table Show(
	Id int PRIMARY KEY IDENTITY,
	MovieStartTime time not null,
	ShowDate date not null,
	MovieId int not null,
	foreign key(MovieID) references Movie(Id))

create table Cinema(
	Id int PRIMARY KEY IDENTITY,
	NoOfCinema int not null,
	NoOfSeats int not null,)
	
create table Cinema_Show(
	Id int PRIMARY KEY IDENTITY,
	ShowID int not null,
	CinemaID int not null,
	foreign key(ShowID) references Show(Id),
	foreign key(CinemaID) references Cinema(Id))
	
