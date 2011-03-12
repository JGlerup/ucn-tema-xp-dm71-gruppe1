--Movies
insert into Movie values('2010-05-10', 'Apokalypto', 'Warner Brothers', '2011-03-10', '2011-03-11', '01:30:00', 'Mel Gibson', 'Postmand Per', 'Masser af aztekere') 
insert into Movie values('2010-02-05', 'Tangled', 'Disney', '2011-03-12', '2011-03-15', '01:20:00', 'Mr. McDonald', 'Postmand Per', 'Masser af aztekere')
insert into Movie values('1989-06-05', 'Die Hard', 'Disney', '2011-02-10', '2011-02-11', '04:30:01', 'Erik G', 'Erik G', 'Blablabla')

--Show
insert into Show values('01:30:00', '2010-02-05', 1)
insert into Show values('01:40:00', '2010-02-05', 2)

--Cinema
insert into Cinema values(1, 42)
insert into Cinema values(2, 50)
insert into Cinema values(3, 1)

--Cinema_Show
insert into Cinema_Show values(1, 1)
insert into Cinema_Show values(2, 2)
insert into Cinema_Show values(2, 1)
insert into Cinema_Show values(1, 2)