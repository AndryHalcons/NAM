CREATE TABLE `IP` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Vlan` int(11) NOT NULL,
  `IP` varchar(30) NOT NULL,
  `Location` varchar(150) DEFAULT NULL,
  `Mac` varchar(30) DEFAULT NULL,
  `DNS` varchar(150) DEFAULT NULL,
  `Description` varchar(150) DEFAULT NULL,
  `Revised_Hostname` varchar(150) DEFAULT NULL,
  `Hostname` varchar(150) DEFAULT NULL,
  `Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Work_Order` varchar(150) DEFAULT NULL,
  `User` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`,`IP`),
  UNIQUE KEY `IP_UNIQUE` (`IP`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) 
