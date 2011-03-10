use dm71_2
create table cinema(
Id int not null,
NoOfCinema int not null,
NoOfSeats int not null,
ShowId int not null
primary key(Id)
foreign key(ShowId) references show(Id)
)
