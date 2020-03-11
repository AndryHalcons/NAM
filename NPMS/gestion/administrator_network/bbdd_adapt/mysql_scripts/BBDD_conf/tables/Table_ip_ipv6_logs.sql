/* --------------Creacion tabla logs IPv4--------------- */

CREATE TABLE `log_ip_ipv6` (
  `ID` INT(20) NOT NULL AUTO_INCREMENT,
  `IP` varchar(30) NOT NULL,
  `Accion` varchar(45) DEFAULT NULL,
  `Vlan` int(11) NOT NULL,
  `Location` varchar(150) DEFAULT NULL,
  `Mac` varchar(40) DEFAULT NULL,
  `DNS` varchar(150) DEFAULT NULL,
  `Description` varchar(150) DEFAULT NULL,
  `Revised_Hostname` varchar(150) DEFAULT NULL,
  `Hostname` varchar(150) DEFAULT NULL,
  `Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Work_Order` varchar(150) DEFAULT NULL,
  `User` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`)
)