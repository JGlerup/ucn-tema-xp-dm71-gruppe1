use dm71_2
create table Movie(
	Id int PRIMARY KEY IDENTITY,
	ReleaseDate date,
	Title varchar(50),
	Distributor varchar(50),
	ArrivalDate date,
	ReturnDate date,
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
	CinemaName varchar(50) not null,
	NoOfSeats int not null,
	NoOfRows int not null,
	unique(CinemaName))

create table Row(
	Id int PRIMARY KEY IDENTITY,
	RowNo int not null,
	NoOfSeats int not null,
	CinemaID int not null,
	unique(RowNo,CinemaID),
	foreign key(CinemaID) references Cinema(Id))
	
create table Seat(
	Id int PRIMARY KEY IDENTITY,
	SeatNo int not null,
	RowID int not null,
	Taken varchar(10) not null,
	Reserved varchar(10) not null,
	unique(SeatNo,RowId),
	foreign key(RowID) references Row(Id))	
	
create table Cinema_Show(
	Id int PRIMARY KEY IDENTITY,
	ShowID int not null,
	CinemaID int not null,
	foreign key(ShowID) references Show(Id),
	foreign key(CinemaID) references Cinema(Id))
	
	
