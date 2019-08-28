use convenience;
show tables;

create table pos(
   barcode varchar(15) primary key not null,
    pnum int unique auto_increment,
    pname varchar(15) not null,
    price int default 0,
    event11 boolean default 0,
    event22 boolean default 0,
    amount int
);
create table money
(
   price int
);


create table buy(
   tnum int primary key auto_increment,
   times varchar(30),
    productText text,
    totalprice int ,
    cash int default 0,
    card int default 0
);


create table inquiry (
    days varchar(20),
    tnum int primary key auto_increment,
    times varchar(20),
    Price int
);
delete from inquiry;
delete from buy;

drop table buy;
drop table inquiry;
drop table pos;

select * from money;
select *from buy;
select * from inquiry;
select *from pos;

insert into money value(100000);
insert into pos(barcode,pname,price,event11,event22,amount) value('88002798','BananaMilk',1400,false,true,30);
insert into pos(barcode,pname,price,event11,event22,amount) value('8801104221467','Strawberrymilk',1300,false,true,30);
insert into pos(barcode,pname,price,event11,event22,amount) value('8801056193010','PepsiCoke',1000, true, false,37);
insert into pos(barcode,pname,price,event11,event22,amount) value();
insert into pos(barcode,pnum,pname,price,amount) value('0',101,'bag',20,0);
insert into pos(barcode,pnum,pname,price,amount) value('1',102,'Jongryangje 20L',500,0);
insert into pos(barcode,pnum,pname,price,amount) value('2',103,'Jongryangje 50L',1150,0);
insert into pos(barcode,pnum,pname,price,amount) value('3',104,'lighter',500,0);
insert into pos(barcode,pnum,pname,price,amount) value('4',105,'Turbolighter',1000,0);

update pos set barcode = '88002798',pname = 'BananaMilk' where pnum = 3;
