/* --------------Creacion tabla parcheo PATCHING--------------- */

CREATE TABLE `patching` (
  `Building` varchar(45) NOT NULL,
  `Floor` int(11) NOT NULL,
  `Closet` varchar(45) DEFAULT NULL,
  `Panel` varchar(45) DEFAULT NULL,
  `Panel_Port` varchar(45) DEFAULT NULL,
  `Stack` varchar(45) DEFAULT NULL,
  `Switch` varchar(45) DEFAULT NULL,
  `Switch_Port` varchar(45) DEFAULT NULL,
  `Interfaz` varchar(45) DEFAULT NULL,
  `Link` varchar(45) DEFAULT NULL,
  `Speed` varchar(45) DEFAULT NULL,
  `Duplex` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Vlan` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `IP_Switch` varchar(45) DEFAULT NULL,
  `WORK_ORDER` varchar(150) DEFAULT NULL,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`,`Building`)
) 