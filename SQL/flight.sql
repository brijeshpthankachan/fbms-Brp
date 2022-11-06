


CREATE TABLE `flight_schedule` (
  `flight_no` int DEFAULT NULL,
  `flight_from` varchar(25) DEFAULT NULL,
  `flight_to` varchar(25) DEFAULT NULL,
  `date_` date DEFAULT NULL,
  `cost` int DEFAULT NULL,
  KEY `FK_flight_no` (`flight_no`),
  CONSTRAINT `FK_flight_no` FOREIGN KEY (`flight_no`) REFERENCES `flights` (`flight_no`)
);



CREATE TABLE `flights` (
  `flight_no` int NOT NULL,
  `flight_from` varchar(50) DEFAULT NULL,
  `flight_desc` varchar(50) DEFAULT NULL,
  `seat` int DEFAULT NULL,
  PRIMARY KEY (`flight_no`)
);



CREATE TABLE `passenger` (
  `id` int NOT NULL DEFAULT '0',
  `name` varchar(15) DEFAULT NULL,
  `email` varchar(40) NOT NULL,
  `dob` date DEFAULT NULL,
  PRIMARY KEY (`id`)
);



CREATE TABLE `booked_ticket` (
  `ticket_number` int NOT NULL,
  `booking_date` date DEFAULT NULL,
  `travel_date` date DEFAULT NULL,
  `flight_to` varchar(25) DEFAULT NULL,
  `flight_time` time DEFAULT NULL,
  `boarding_time` time DEFAULT NULL,
  `seat` int DEFAULT NULL,
  `flight_no` int DEFAULT NULL,
  PRIMARY KEY (`ticket_number`),
  KEY `FK_flight_no_book` (`flight_no`),
  CONSTRAINT `FK_flight_no_book` FOREIGN KEY (`flight_no`) REFERENCES `flights` (`flight_no`)
);


-- ________________________________________________________________________________________________________________________________



-- Field      |Type       |Null|Key|Default|Extra|
-- -----------+-----------+----+---+-------+-----+
-- flight_no  |int        |NO  |PRI|       |     |
-- flight_from|varchar(50)|YES |   |       |     |
-- flight_desc|varchar(50)|YES |   |       |     |
-- seat       |int        |YES |   |       |     |
-- 
-- 
-- 
-- Field      |Type       |Null|Key|Default|Extra|
-- -----------+-----------+----+---+-------+-----+
-- flight_no  |int        |YES |MUL|       |     |
-- flight_from|varchar(25)|YES |   |       |     |
-- flight_to  |varchar(25)|YES |   |       |     |
-- date_      |date       |YES |   |       |     |
-- cost       |int        |YES |   |       |     |
-- 


-- Field        |Type       |Null|Key|Default|Extra|
-- -------------+-----------+----+---+-------+-----+
-- ticket_number|int        |NO  |PRI|       |     |
-- booking_date |date       |YES |   |       |     |
-- travel_date  |date       |YES |   |       |     |
-- flight_to    |varchar(25)|YES |   |       |     |
-- flight_time  |time       |YES |   |       |     |
-- boarding_time|time       |YES |   |       |     |
-- seat         |int        |YES |   |       |     |
-- flight_no    |int        |YES |MUL|       |     |

-- 
-- Field|Type       |Null|Key|Default|Extra|
-- -----+-----------+----+---+-------+-----+
-- id   |int        |NO  |PRI|0      |     |
-- name |varchar(15)|YES |   |       |     |
-- email|varchar(40)|NO  |   |       |     |
-- dob  |date       |YES |   |       |     |
-- 


