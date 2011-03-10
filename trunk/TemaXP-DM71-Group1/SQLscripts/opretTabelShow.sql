use dm71_2
create table show(
Id int not null,
Playtime time not null,
Date_ date not null,
Cinema varchar(50) not null,
Movie varchar(50) not null,
MovieId int not null
primary key(Id)
foreign key(MovieId) references film(Id)
)
