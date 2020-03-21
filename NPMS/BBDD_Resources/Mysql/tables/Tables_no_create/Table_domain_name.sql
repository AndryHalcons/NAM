CREATE TABLE `domain_name` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Vlan` int(11) NOT NULL,
  `IP` varchar(150) NOT NULL,
  `DNS` varchar(150) DEFAULT NULL,
  `Hostname` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`,`IP`),
  UNIQUE KEY `IP_UNIQUE` (`IP`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) 
