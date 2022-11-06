 

select  * from customers;
select  * from location;
select  * from zipcode;




select name,email,age,location,zip  from location l, customers c , zipcode z where c.id = l.id and l.location_id = z.location_id and c.email = 'sert1o@engadget.com';

select name,location_id from customers c inner join location l on c.id = l.id;

select name,location_id from customers c right join location l on c.id = l.id;


create table products( id int primary key auto_increment,name varchar(50) not null,price int not null default 0);


select name,email,age,location from customers c join location l on c.id = l.id join zipcode z on z.location_id = l.location_id  ;  


select name,email,age,location from customers c,location l, zipcode z where c.id = l.id and z.location_id = l.location_id;

