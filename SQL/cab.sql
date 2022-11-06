


CREATE TABLE `cab` (
  `regNo` varchar(10) NOT NULL,
  `cabType` varchar(15) DEFAULT NULL,
  `driverID` int DEFAULT NULL,
  PRIMARY KEY (`regNo`),
  KEY `FK_driverid` (`driverID`),
  CONSTRAINT `FK_driverid` FOREIGN KEY (`driverID`) REFERENCES `driver` (`driverID`)
);




CREATE TABLE `booking` (
  `userName` varchar(15) DEFAULT NULL,
  `driverID` int DEFAULT NULL,
  `bookingID` int NOT NULL AUTO_INCREMENT,
  `bookingDate` date DEFAULT NULL,
  `locationFrom` double DEFAULT NULL,
  `locationTo` double DEFAULT NULL,
  `fare` int DEFAULT NULL,
  PRIMARY KEY (`bookingID`),
  KEY `Fk_unsername` (`userName`),
  KEY `Fk_driverid_reg` (`driverID`),
  CONSTRAINT `Fk_driverid_reg` FOREIGN KEY (`driverID`) REFERENCES `driver` (`driverID`),
  CONSTRAINT `Fk_unsername` FOREIGN KEY (`userName`) REFERENCES `userreg` (`userName`)
);


CREATE TABLE `driver` (
  `licenceNo` varchar(10) DEFAULT NULL,
  `driverID` int NOT NULL,
  `name` varchar(10) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  PRIMARY KEY (`driverID`),
  UNIQUE KEY `licenceNo` (`licenceNo`)
);

