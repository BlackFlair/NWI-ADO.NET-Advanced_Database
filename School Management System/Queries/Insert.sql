insert into Students (Name, DOB, Batch) values ('Raze', '01-Jan-2000', 2019)
insert into Students (Name, DOB, Batch) values ('Jett', '02-Feb-2000', 2019)
insert into Students (Name, DOB, Batch) values ('Reyna', '03-Jan-2000', 2019)
insert into Students (Name, DOB, Batch) values ('Omen', '04-Jan-2000', 2019)
insert into Students (Name, DOB, Batch) values ('Kay/o', '05-Jan-2000', 2019)


insert into Teachers (Name, Title, Subject) values ('Brimstone', 'Professor', 'Combat & Weapons')
insert into Teachers (Name, Title, Subject) values ('Breach', 'Professor', 'Flash & Push')
insert into Teachers (Name, Title, Subject) values ('Cypher', 'Professor', 'Surveillance & Intel Gathering')

insert into Subjects (Name) values ('Combat & Weapons')
insert into Subjects (Name) values ('Flash & Pushs')
insert into Subjects (Name) values ('Surveillance & Intel Gathering')
insert into Subjects (Name) values ('Art Of Healing')


insert into Classrooms values (1 , 1, 1)
insert into Classrooms values (2 ,2, 2)
insert into Classrooms values (3 ,3, 3)


insert into StudentClasses (ClassroomId, StudentId) values (1 , 1)
insert into StudentClasses (ClassroomId, StudentId) values (1 , 2)
insert into StudentClasses (ClassroomId, StudentId) values (2 , 3)
insert into StudentClasses (ClassroomId, StudentId) values (3 , 4)
insert into StudentClasses (ClassroomId, StudentId) values (3 , 5)